using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.EC2;
using Amazon.EC2.Model;
using Service.Contract;
using Service.Mappings;
using Ninject;

namespace Service
{
    public class InstanceService : IInstanceService, IDisposable
    {
        private List<InstanceStatus> _statuses;
        private readonly IAmazonEC2 _ec2Client;
        private readonly CancellationTokenSource _cancellationTokenSource;
        private bool _isDisposed;

        public event EventHandler<IEnumerable<InstanceInfo>> OnDataUpdate;

        private async void StartListening()
        {
            while (true)
            {
                try
                {
                    _statuses = await RefreshInstances();

                    RiseOnDataUpdate(_statuses.ConvertAll(x => x.ToInstanceInfo()));
                    await Task.Delay(TimeSpan.FromSeconds(3), _cancellationTokenSource.Token);
                }
                catch (AggregateException)
                {
                    return;
                }
            }
        }

        private void RiseOnDataUpdate(IEnumerable<InstanceInfo> data)
        {
            if (OnDataUpdate != null)
            {
                OnDataUpdate(this, data);
            }
        }

        private async Task<List<InstanceStatus>> RefreshInstances()
        {
            var result = await _ec2Client.DescribeInstanceStatusAsync(new DescribeInstanceStatusRequest { IncludeAllInstances = true }, _cancellationTokenSource.Token);
            var instancesStates = result.InstanceStatuses.ToList();
            while (result.NextToken != null)
            {
                result = await _ec2Client.DescribeInstanceStatusAsync(new DescribeInstanceStatusRequest
                {
                    IncludeAllInstances = true,
                    NextToken = result.NextToken
                }, _cancellationTokenSource.Token);
                instancesStates.AddRange(result.InstanceStatuses);
            }
            return instancesStates;
        }

        private void ChangeInstanceState(List<InstanceStateChange> stateChanges)
        {
            foreach (var stateChange in stateChanges)
            {
                _statuses.First(x => x.InstanceId == stateChange.InstanceId).InstanceState = stateChange.CurrentState;
            }
            RiseOnDataUpdate(_statuses.ConvertAll(x => x.ToInstanceInfo()));
        }

        [Inject]
        public InstanceService(IAmazonEC2 ec2Client)
        {
            _ec2Client = ec2Client;
            _cancellationTokenSource = new CancellationTokenSource();
            _cancellationTokenSource.Token.ThrowIfCancellationRequested();
            StartListening();
        }

        public async Task StopInstanceAsync(InstanceInfo instance)
        {
            if (instance.State != InstanceStateType.Running)
            {
                Console.WriteLine(string.Format("Unable to stop instance with state {0}", instance.State));
                return;
            }
            try
            {
                var result = await _ec2Client.StopInstancesAsync(
                    new StopInstancesRequest {InstanceIds = new List<string> {instance.InstanceId}},
                    _cancellationTokenSource.Token);
                if (result.HttpStatusCode == HttpStatusCode.OK)
                {
                    ChangeInstanceState(result.StoppingInstances);
                }
            }
            catch (AggregateException)
            {
                Console.WriteLine("Request was cancelled");
            }
        }

        public async Task StartInstanceAsync(InstanceInfo instance)
        {
            if (instance.State != InstanceStateType.Stopped)
            {
                Console.WriteLine(string.Format("Unable to start instance with state {0}", instance.State));
            }
            try
            {
                var result = await _ec2Client.StartInstancesAsync(
                    new StartInstancesRequest { InstanceIds = new List<string> { instance.InstanceId } },
                    _cancellationTokenSource.Token);
                if (result.HttpStatusCode == HttpStatusCode.OK)
                {
                    ChangeInstanceState(result.StartingInstances);
                }
            }
            catch (AggregateException)
            {
                Console.WriteLine("Request was cancelled");
            }
        }

        public void Dispose()
        {
            if (!_isDisposed)
            {
                _isDisposed = true;
                _cancellationTokenSource.Cancel();
                _cancellationTokenSource.Dispose();
            }
        }
    }
}
