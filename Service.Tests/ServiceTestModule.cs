using Amazon.EC2;
using Ninject.Modules;
using Service.Contract;
using Service.Mock;

namespace Service.Tests.DI
{
    public class ServiceTestModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IInstanceService>().To<InstanceService>();
            Bind<IAmazonEC2>().To<AmazonEC2ClientMock>();
        }
    }
}
