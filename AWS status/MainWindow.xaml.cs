using Ninject;
using System.Windows;
using AWS_status.Properties;
using ViewModel;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IInstancesListViewModel InstancesViewModel { get; set; }

        public MainWindow()
        {
            var kernel = new StandardKernel(new ViewModel.DI.ViewModelModule(),
                new Service.DI.ServiceModule(Settings.Default.UserID, Settings.Default.SecretKey));
            InstancesViewModel = kernel.Get<IInstancesListViewModel>();
            DataContext = InstancesViewModel;
            InitializeComponent();
        }
    }
}
