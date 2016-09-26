using Ninject;
using Service.Contract;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using ViewModel.Commands;
using ViewModel.Mappings;

namespace ViewModel
{
    public class InstancesListViewModel: ViewModelBase, IInstancesListViewModel
    {
        private IInstanceService _instancesService;
        private string _selectedId;
        private ICommand _switchCommand;
        private readonly ObservableCollection<InstanceViewModel> _instances;

        public ObservableCollection<InstanceViewModel> Instances
        {
            get { return _instances; }
        }

        public string SwitchAction
        {
            get
            {
                return SelectedItem != null ? SelectedItem.SwitchAction : "Not applicable";
            }
        }

        public string InstanceState
        {
            get
            {
                return SelectedItem != null ? SelectedItem.StateName.ToString() : "state";
            }
        }

        public InstanceViewModel SelectedItem
        {
            get
            {
                return Instances.FirstOrDefault(x => x.InstanceId.Equals(_selectedId));
            }
            set
            {
                _selectedId = value.InstanceId;
                Select(value);
            }
        }

        public ICommand SwitchCommand
        {
            get
            {
                if (_switchCommand == null)
                {
                    _switchCommand = new RelayCommand(x =>
                    {
                        SwitchState(SelectedItem);
                    },
                    x =>
                    {
                        return SelectedItem != null ? SelectedItem.SwitchActionIsEnabled : false;
                    });
                }
                return _switchCommand;
            }
        }

        [Inject]
        public InstancesListViewModel(IInstanceService service)
        {
            _instances = new ObservableCollection<InstanceViewModel>();
            _instancesService = service;
            _instancesService.OnDataUpdate += OnUpdate;
        }

        public void Select(InstanceViewModel item)
        {
            _selectedId = item.InstanceId;
            Refresh();
        }

        private void Refresh()
        {
            OnPropertyChanged("SwitchAction");
            OnPropertyChanged("InstanceState");
            OnPropertyChanged("SwitchButtonIsEnabled");
            CommandManager.InvalidateRequerySuggested();
        }

        private void OnUpdate(object sender, IEnumerable<InstanceInfo> instances)
        {
            var toRemove = Instances.Select(x => x.InstanceId).Except(instances.Select(x => x.InstanceId)).ToList();
            toRemove.ForEach(id => Instances.Remove(Instances.First(x => x.InstanceId.Equals(id))));
            foreach (var instance in instances.Select(x => x.ToInstanceViewModel()))
            {
                var toUpdate = Instances.FirstOrDefault(x => x.InstanceId.Equals(instance.InstanceId));
                if (toUpdate != null)
                {
                    toUpdate.StateName = instance.StateName;
                }
                else
                {
                    Instances.Add(instance);
                }
            }
            OnPropertyChanged("Instances");
            Refresh();
        }

        private void SwitchState(InstanceViewModel instance)
        {
            if (instance.StateName == InstanceStateType.Running)
            {
                _instancesService.StopInstanceAsync(instance.ToInstanceInfo());
            }
            else if (instance.StateName == InstanceStateType.Stopped)
            {
                _instancesService.StartInstanceAsync(instance.ToInstanceInfo());
            }
        }
    }
}
