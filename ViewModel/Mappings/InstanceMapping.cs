using Service.Contract;

namespace ViewModel.Mappings
{
    public static  class InstanceMapping
    {
        public static InstanceViewModel ToInstanceViewModel(this InstanceInfo instanceInfo)
        {
            return new InstanceViewModel { InstanceId = instanceInfo.InstanceId, StateName = instanceInfo.State };
        }

        public static InstanceInfo ToInstanceInfo(this InstanceViewModel viewModel)
        {
            return new InstanceInfo { InstanceId = viewModel.InstanceId, State = viewModel.StateName };
        }
    }
}
