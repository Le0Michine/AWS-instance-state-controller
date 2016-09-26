using Ninject;
using ViewModel.Tests.DI;

namespace ViewModel.Tests
{
    public class UnitTestBase
    {
        protected IKernel _kernel;

        public virtual void Initialize()
        {
            _kernel = new StandardKernel(new ViewModelTestModule());
        }

        public virtual void Cleanup()
        {
            _kernel.Dispose();
        }
    }
}
