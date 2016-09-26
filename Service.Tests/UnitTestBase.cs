using Ninject;
using Service.DI;
using Service.Tests.DI;

namespace Service.Tests
{
    public class UnitTestBase
    {
        protected IKernel _kernel;

        public virtual void Initialize()
        {
            _kernel = new StandardKernel(new ServiceTestModule());
        }

        public virtual void Cleanup()
        {
            _kernel.Dispose();
        }
    }
}
