using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service.Contract;

namespace Service.Mock
{
    public class InstanceServiceMock : IInstanceService, IInstanceServiceMock, IDisposable
    {
        private IEnumerable<InstanceInfo> _data;
        public event EventHandler<IEnumerable<InstanceInfo>> OnDataUpdate;

        private void FireOnDataUpdate()
        {
            if (OnDataUpdate != null)
            {
                OnDataUpdate(this, _data);
            }
        }

        public void Dispose()
        {
        }

        public void PutData(IEnumerable<InstanceInfo> data)
        {
            _data = data;
            FireOnDataUpdate();
        }

        public async Task StartInstanceAsync(InstanceInfo instance)
        {
            var toStart = _data.FirstOrDefault(x => x.InstanceId.Equals(instance.InstanceId));
            toStart.State = InstanceStateType.Running;
            FireOnDataUpdate();
        }

        public async Task StopInstanceAsync(InstanceInfo instance)
        {
            var toStop = _data.FirstOrDefault(x => x.InstanceId.Equals(instance.InstanceId));
            toStop.State = InstanceStateType.Stopped;
            FireOnDataUpdate();
        }
    }
}
