using Ninject.Modules;

namespace ViewModel.DI
{
    public class ViewModelModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IInstancesListViewModel>().To<InstancesListViewModel>();
        }
    }
}
