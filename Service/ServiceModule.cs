using Amazon;
using Amazon.EC2;
using Ninject.Modules;
using Service.Contract;

namespace Service.DI
{
    public class ServiceModule : NinjectModule
    {
        private readonly string _userId;
        private readonly string _secretKey;

        public ServiceModule(string userId = null, string secretKey = null)
        {
            _userId = userId;
            _secretKey = secretKey;
        }
        public override void Load()
        {
            Bind<IInstanceService>().To<InstanceService>().InSingletonScope();
            if (!string.IsNullOrWhiteSpace(_secretKey) && !string.IsNullOrWhiteSpace(_userId))
            {
                Bind<IAmazonEC2>().ToConstructor(ctorArg => new AmazonEC2Client(_userId, _secretKey, RegionEndpoint.EUWest1));
            }
            else
            {
                Bind<IAmazonEC2>().ToConstructor(ctorArg => new AmazonEC2Client(RegionEndpoint.EUWest1));
            }
        }
    }
}
