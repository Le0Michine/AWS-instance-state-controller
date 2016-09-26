using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Contract
{
    public interface IInstanceService
    {
        event EventHandler<IEnumerable<InstanceInfo>> OnDataUpdate;

        Task StopInstanceAsync(InstanceInfo instance);

        Task StartInstanceAsync(InstanceInfo instance);
    }
}
