using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace ViewModel
{
    public interface IInstancesListViewModel: INotifyPropertyChanged
    {
        string SwitchAction { get; }

        string InstanceState { get; }

        ICommand SwitchCommand { get; }

        ObservableCollection<InstanceViewModel> Instances { get; }

        InstanceViewModel SelectedItem { get; set; }

        void Select(InstanceViewModel item);
    }
}
