using Amazon.EC2;
using Amazon.EC2.Model;
using Service.Contract;

namespace Service.Mappings
{
    public static class EC2InstanceMapping
    {
        public static InstanceInfo ToInstanceInfo(this InstanceStatus instanceStatus)
        {
            return new InstanceInfo { InstanceId = instanceStatus.InstanceId, State = instanceStatus.InstanceState.ToInstanceStateType() };
        }

        public static InstanceStatus ToEC2Status(this InstanceInfo viewModel)
        {
            return new InstanceStatus { InstanceId = viewModel.InstanceId, InstanceState = viewModel.State.ToInstanceState() };
        }

        public static InstanceState ToInstanceState(this InstanceStateType type)
        {
            InstanceStateName stateName = InstanceStateName.Terminated;
            switch (type)
            {
                case InstanceStateType.Pending:
                    stateName = InstanceStateName.Pending;
                    break;
                case InstanceStateType.Running:
                    stateName = InstanceStateName.Running;
                    break;
                case InstanceStateType.ShuttingDown:
                    stateName = InstanceStateName.ShuttingDown;
                    break;
                case InstanceStateType.Stopped:
                    stateName = InstanceStateName.Stopped;
                    break;
                case InstanceStateType.Stopping:
                    stateName = InstanceStateName.Stopping;
                    break;
                case InstanceStateType.Terminated:
                    stateName = InstanceStateName.Terminated;
                    break;
            }
            return new InstanceState { Name = stateName };
        }

        public static InstanceStateType ToInstanceStateType(this InstanceState state)
        {
            if (state.Name == InstanceStateName.Pending)
            {
                return InstanceStateType.Pending;
            }
            if (state.Name == InstanceStateName.Running)
            {
                return InstanceStateType.Running;
            }
            if (state.Name == InstanceStateName.ShuttingDown)
            {
                return InstanceStateType.ShuttingDown;
            }
            if (state.Name == InstanceStateName.Stopped)
            {
                return InstanceStateType.Stopped;
            }
            if (state.Name == InstanceStateName.Stopping)
            {
                return InstanceStateType.Stopping;
            }
            return InstanceStateType.Terminated;
        }
    }
}
