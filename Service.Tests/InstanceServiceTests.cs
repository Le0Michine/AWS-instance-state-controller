using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using Service.Contract;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using Amazon.EC2.Model;
using Amazon.EC2;

namespace Service.Tests
{
    [TestClass]
    public class InstanceServiceTests : UnitTestBase
    {
        [TestInitialize]
        public override void Initialize()
        {
            base.Initialize();
        }

        [TestCleanup]
        public override void Cleanup()
        {
            base.Cleanup();
        }

        [TestMethod]
        public void GetInstances()
        {
            var service = _kernel.Get<IInstanceService>();

            var taskSource = WaitForDataUpdate(service);

            Assert.IsTrue(taskSource.Task.IsCompleted, "Timeout exceeded");
            Assert.AreEqual(2, taskSource.Task.Result.Count);
            Assert.AreEqual(InstanceStateType.Stopped, taskSource.Task.Result.Single(x => x.InstanceId.Equals("test-instance-a")).State);
            Assert.AreEqual(InstanceStateType.Running, taskSource.Task.Result.Single(x => x.InstanceId.Equals("test-instance-b")).State);
        }

        [TestMethod]
        public void StartInstance()
        {
            var service = _kernel.Get<IInstanceService>();
            var taskSource = WaitForDataUpdate(service);

            service.StartInstanceAsync(new InstanceInfo { InstanceId = "test-instance-a", State = InstanceStateType.Stopped });
            taskSource = WaitForDataUpdate(service);

            Assert.AreEqual(InstanceStateType.Running, taskSource.Task.Result.Single(x => x.InstanceId.Equals("test-instance-a")).State);
        }

        [TestMethod]
        public void StopInstance()
        {
            var service = _kernel.Get<IInstanceService>();
            var taskSource = WaitForDataUpdate(service);

            service.StopInstanceAsync(new InstanceInfo { InstanceId = "test-instance-b", State = InstanceStateType.Running });
            taskSource = WaitForDataUpdate(service);

            Assert.AreEqual(InstanceStateType.Stopped, taskSource.Task.Result.Single(x => x.InstanceId.Equals("test-instance-b")).State);
        }

        private TaskCompletionSource<List<InstanceInfo>> WaitForDataUpdate(IInstanceService service)
        {
            var taskSource = new TaskCompletionSource<List<InstanceInfo>>();
            EventHandler<IEnumerable<InstanceInfo>> handler = (sender, eventArgs) =>
            {
                taskSource.SetResult(eventArgs.ToList());
            };
            service.OnDataUpdate += handler;
            taskSource.Task.ContinueWith(x => service.OnDataUpdate -= handler);
            Task.WaitAny(Task.Delay(500), taskSource.Task);
            return taskSource;
        }
    }
}
