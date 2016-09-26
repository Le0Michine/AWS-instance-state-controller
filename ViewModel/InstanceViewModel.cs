using Service.Contract;

namespace ViewModel
{
    public class InstanceViewModel : ViewModelBase
    {
        private string _instanceId;
        private InstanceStateType _stateName;

        public string InstanceId
        {
            get
            {
                return _instanceId;
            }
            set
            {
                _instanceId = value;
                OnPropertyChanged("InstanceId");
            }
        }

        public InstanceStateType StateName
        {
            get
            {
                return _stateName;
            }
            set
            {
                _stateName = value;
                OnPropertyChanged("StateName");
            }
        }

        public string SwitchAction
        {
            get
            {
                return StateName == InstanceStateType.Stopped ||
                       StateName == InstanceStateType.Stopping
                    ? "Start"
                    : StateName == InstanceStateType.Running ||
                      StateName == InstanceStateType.Pending
                        ? "Stop"
                        : "Not applicable";
            }
        }

        public bool SwitchActionIsEnabled
        {
            get { return StateName == InstanceStateType.Stopped || StateName == InstanceStateType.Running; }
        }
    }
}
