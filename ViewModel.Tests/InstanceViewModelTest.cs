using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service.Contract;
using Ninject;

namespace ViewModel.Tests
{
    [TestClass]
    public class InstanceViewModelTest: UnitTestBase
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
        public void ChangeInstanceId()
        {
            var onChangeFired = false;
            var viewModel = _kernel.Get<InstanceViewModel>();
            viewModel.PropertyChanged += (sender, eventArgs) => {
                onChangeFired = true;
            };
            viewModel.InstanceId = "new ID";

            Assert.IsTrue(onChangeFired);
            Assert.AreEqual("new ID", viewModel.InstanceId);
        }

        [TestMethod]
        public void ChangeInstanceState()
        {
            var onChangeFired = false;
            var viewModel = _kernel.Get<InstanceViewModel>();
            viewModel.PropertyChanged += (sender, eventArgs) => {
                onChangeFired = true;
            };
            viewModel.StateName = InstanceStateType.Pending;

            Assert.IsTrue(onChangeFired);
            Assert.AreEqual(InstanceStateType.Pending, viewModel.StateName);
        }

        [TestMethod]
        public void CheckSwitchAction()
        {
            var viewModel = _kernel.Get<InstanceViewModel>();

            viewModel.StateName = InstanceStateType.Pending;
            Assert.AreEqual("Stop", viewModel.SwitchAction);
            viewModel.StateName = InstanceStateType.Running;
            Assert.AreEqual("Stop", viewModel.SwitchAction);
            viewModel.StateName = InstanceStateType.Stopping;
            Assert.AreEqual("Start", viewModel.SwitchAction);
            viewModel.StateName = InstanceStateType.Stopped;
            Assert.AreEqual("Start", viewModel.SwitchAction);
            viewModel.StateName = InstanceStateType.ShuttingDown;
            Assert.AreEqual("Not applicable", viewModel.SwitchAction);
            viewModel.StateName = InstanceStateType.Terminated;
            Assert.AreEqual("Not applicable", viewModel.SwitchAction);
        }

        [TestMethod]
        public void SwitchActionEnabled()
        {
            var viewModel = _kernel.Get<InstanceViewModel>();

            viewModel.StateName = InstanceStateType.Running;
            Assert.IsTrue(viewModel.SwitchActionIsEnabled);
            viewModel.StateName = InstanceStateType.Stopped;
            Assert.IsTrue(viewModel.SwitchActionIsEnabled);
            viewModel.StateName = InstanceStateType.Pending;
            Assert.IsFalse(viewModel.SwitchActionIsEnabled);
            viewModel.StateName = InstanceStateType.Stopping;
            Assert.IsFalse(viewModel.SwitchActionIsEnabled);
            viewModel.StateName = InstanceStateType.Terminated;
            Assert.IsFalse(viewModel.SwitchActionIsEnabled);
            viewModel.StateName = InstanceStateType.ShuttingDown;
            Assert.IsFalse(viewModel.SwitchActionIsEnabled);
        }
    }
}
