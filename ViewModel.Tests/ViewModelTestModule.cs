using Amazon.EC2;
using Ninject;
using Ninject.Modules;
using Service.Contract;
using Service.Mock;
using ViewModel;

namespace ViewModel.Tests.DI
{
    public class ViewModelTestModule : NinjectModule
    {
        public override void Load()
        {
            Bind<InstanceServiceMock>().ToSelf().InSingletonScope();
            Bind<IInstanceService>().ToMethod(c => c.Kernel.Get<InstanceServiceMock>());
            Bind<IInstanceServiceMock>().ToMethod(c => c.Kernel.Get<InstanceServiceMock>());
            Bind<InstanceViewModel>().To<InstanceViewModel>();
            Bind<IInstancesListViewModel>().To<InstancesListViewModel>();
            Bind<IAmazonEC2>().To<AmazonEC2ClientMock>();
        }
    }
}
