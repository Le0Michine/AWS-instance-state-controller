using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service.Contract;
using Ninject;
using Service.Mock;
using System.Collections.Generic;
using System.Linq;

namespace ViewModel.Tests
{
    [TestClass]
    public class InstancesListViewModelTest: UnitTestBase
    {
        private IEnumerable<InstanceInfo> _testInstances = new List<InstanceInfo>
        {
            new InstanceInfo { InstanceId = "test-istance-1", State = InstanceStateType.Stopped },
            new InstanceInfo { InstanceId = "test-istance-2", State = InstanceStateType.Running }
        };

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
        public void PutInstances()
        {
            var onChangeFired = false;
            var viewModel = _kernel.Get<IInstancesListViewModel>();
            var service = _kernel.Get<IInstanceServiceMock>();
            viewModel.PropertyChanged += (sender, eventArgs) => {
                onChangeFired = true;
            };

            service.PutData(_testInstances);

            Assert.IsTrue(onChangeFired);
            Assert.AreEqual(2, viewModel.Instances.Count);
            Assert.AreEqual("test-istance-1", viewModel.Instances[0].InstanceId);
            Assert.AreEqual(InstanceStateType.Stopped, viewModel.Instances[0].StateName);
            Assert.AreEqual("test-istance-2", viewModel.Instances[1].InstanceId);
            Assert.AreEqual(InstanceStateType.Running, viewModel.Instances[1].StateName);
        }

        [TestMethod]
        public void StartInstance()
        {
            var onChangeFired = false;
            var viewModel = _kernel.Get<IInstancesListViewModel>();
            var service = _kernel.Get<IInstanceServiceMock>();
            service.PutData(_testInstances);

            viewModel.PropertyChanged += (sender, eventArgs) => {
                onChangeFired = true;
            };

            viewModel.Select(viewModel.Instances.Single(x => x.InstanceId.Equals("test-istance-1")));
            viewModel.SwitchCommand.Execute(null);

            Assert.IsTrue(onChangeFired);
            Assert.AreEqual(InstanceStateType.Running, viewModel.Instances.Single(x => x.InstanceId.Equals("test-istance-1")).StateName);
        }

        [TestMethod]
        public void StopInstance()
        {
            var onChangeFired = false;
            var viewModel = _kernel.Get<IInstancesListViewModel>();
            var service = _kernel.Get<IInstanceServiceMock>();
            service.PutData(_testInstances);

            viewModel.PropertyChanged += (sender, eventArgs) => {
                onChangeFired = true;
            };

            viewModel.Select(viewModel.Instances.Single(x => x.InstanceId.Equals("test-istance-2")));
            viewModel.SwitchCommand.Execute(null);

            Assert.IsTrue(onChangeFired);
            Assert.AreEqual(InstanceStateType.Stopped, viewModel.Instances.Single(x => x.InstanceId.Equals("test-istance-2")).StateName);
        }

        [TestMethod]
        public void SelectInstance()
        {
            var onChangeFired = false;
            var viewModel = _kernel.Get<IInstancesListViewModel>();
            var service = _kernel.Get<IInstanceServiceMock>();
            service.PutData(_testInstances);

            viewModel.PropertyChanged += (sender, eventArgs) => {
                onChangeFired = true;
            };

            viewModel.Select(viewModel.Instances.Single(x => x.InstanceId.Equals("test-istance-2")));

            Assert.IsTrue(onChangeFired);
            Assert.AreEqual("test-istance-2", viewModel.SelectedItem.InstanceId);
            Assert.AreEqual("Stop", viewModel.SwitchAction);
            Assert.AreEqual("Running", viewModel.InstanceState);
        }
    }
}
