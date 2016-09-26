using System;
namespace Service.Contract
{
    public enum InstanceStateType
    {
        Pending,
        Running,
        ShuttingDown,
        Stopped,
        Stopping,
        Terminated
    }
}
