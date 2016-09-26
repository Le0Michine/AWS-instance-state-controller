using Amazon;
using Amazon.EC2;
using Amazon.Runtime;
using System;
using System.Threading.Tasks;
using Amazon.EC2.Model;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace Service.Mock
{
    public class AmazonEC2ClientMock : IAmazonEC2, IDisposable
    {
        public IClientConfig Config
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public AcceptVpcPeeringConnectionResponse AcceptVpcPeeringConnection(AcceptVpcPeeringConnectionRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<AcceptVpcPeeringConnectionResponse> AcceptVpcPeeringConnectionAsync(AcceptVpcPeeringConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public AllocateAddressResponse AllocateAddress()
        {
            throw new NotImplementedException();
        }

        public AllocateAddressResponse AllocateAddress(AllocateAddressRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<AllocateAddressResponse> AllocateAddressAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<AllocateAddressResponse> AllocateAddressAsync(AllocateAddressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public AllocateHostsResponse AllocateHosts(AllocateHostsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<AllocateHostsResponse> AllocateHostsAsync(AllocateHostsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public AssignPrivateIpAddressesResponse AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddressesAsync(AssignPrivateIpAddressesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public AssociateAddressResponse AssociateAddress(AssociateAddressRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<AssociateAddressResponse> AssociateAddressAsync(AssociateAddressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public AssociateDhcpOptionsResponse AssociateDhcpOptions(AssociateDhcpOptionsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<AssociateDhcpOptionsResponse> AssociateDhcpOptionsAsync(AssociateDhcpOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public AssociateRouteTableResponse AssociateRouteTable(AssociateRouteTableRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<AssociateRouteTableResponse> AssociateRouteTableAsync(AssociateRouteTableRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public AttachClassicLinkVpcResponse AttachClassicLinkVpc(AttachClassicLinkVpcRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<AttachClassicLinkVpcResponse> AttachClassicLinkVpcAsync(AttachClassicLinkVpcRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public AttachInternetGatewayResponse AttachInternetGateway(AttachInternetGatewayRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<AttachInternetGatewayResponse> AttachInternetGatewayAsync(AttachInternetGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public AttachNetworkInterfaceResponse AttachNetworkInterface(AttachNetworkInterfaceRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<AttachNetworkInterfaceResponse> AttachNetworkInterfaceAsync(AttachNetworkInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public AttachVolumeResponse AttachVolume(AttachVolumeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<AttachVolumeResponse> AttachVolumeAsync(AttachVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public AttachVpnGatewayResponse AttachVpnGateway(AttachVpnGatewayRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<AttachVpnGatewayResponse> AttachVpnGatewayAsync(AttachVpnGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<AuthorizeSecurityGroupEgressResponse> AuthorizeSecurityGroupEgressAsync(AuthorizeSecurityGroupEgressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public AuthorizeSecurityGroupIngressResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<AuthorizeSecurityGroupIngressResponse> AuthorizeSecurityGroupIngressAsync(AuthorizeSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public BundleInstanceResponse BundleInstance(BundleInstanceRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<BundleInstanceResponse> BundleInstanceAsync(BundleInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CancelBundleTaskResponse CancelBundleTask(CancelBundleTaskRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CancelBundleTaskResponse> CancelBundleTaskAsync(CancelBundleTaskRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CancelConversionTaskResponse CancelConversionTask(CancelConversionTaskRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CancelConversionTaskResponse> CancelConversionTaskAsync(CancelConversionTaskRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CancelExportTaskResponse> CancelExportTaskAsync(CancelExportTaskRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CancelImportTaskResponse CancelImportTask(CancelImportTaskRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CancelImportTaskResponse> CancelImportTaskAsync(CancelImportTaskRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CancelReservedInstancesListingResponse CancelReservedInstancesListing(CancelReservedInstancesListingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CancelReservedInstancesListingResponse> CancelReservedInstancesListingAsync(CancelReservedInstancesListingRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CancelSpotFleetRequestsResponse CancelSpotFleetRequests(CancelSpotFleetRequestsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CancelSpotFleetRequestsResponse> CancelSpotFleetRequestsAsync(CancelSpotFleetRequestsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CancelSpotInstanceRequestsResponse CancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CancelSpotInstanceRequestsResponse> CancelSpotInstanceRequestsAsync(CancelSpotInstanceRequestsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ConfirmProductInstanceResponse ConfirmProductInstance(ConfirmProductInstanceRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ConfirmProductInstanceResponse> ConfirmProductInstanceAsync(ConfirmProductInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CopyImageResponse CopyImage(CopyImageRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CopyImageResponse> CopyImageAsync(CopyImageRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CopySnapshotResponse CopySnapshot(CopySnapshotRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateCustomerGatewayResponse CreateCustomerGateway(CreateCustomerGatewayRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateCustomerGatewayResponse> CreateCustomerGatewayAsync(CreateCustomerGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateDhcpOptionsResponse CreateDhcpOptions(CreateDhcpOptionsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateDhcpOptionsResponse> CreateDhcpOptionsAsync(CreateDhcpOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateFlowLogsResponse CreateFlowLogs(CreateFlowLogsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateFlowLogsResponse> CreateFlowLogsAsync(CreateFlowLogsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateImageResponse CreateImage(CreateImageRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateInstanceExportTaskResponse CreateInstanceExportTask(CreateInstanceExportTaskRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateInstanceExportTaskResponse> CreateInstanceExportTaskAsync(CreateInstanceExportTaskRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateInternetGatewayResponse CreateInternetGateway()
        {
            throw new NotImplementedException();
        }

        public CreateInternetGatewayResponse CreateInternetGateway(CreateInternetGatewayRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateInternetGatewayResponse> CreateInternetGatewayAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<CreateInternetGatewayResponse> CreateInternetGatewayAsync(CreateInternetGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateNatGatewayResponse CreateNatGateway(CreateNatGatewayRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateNatGatewayResponse> CreateNatGatewayAsync(CreateNatGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateNetworkAclResponse CreateNetworkAcl(CreateNetworkAclRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateNetworkAclResponse> CreateNetworkAclAsync(CreateNetworkAclRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateNetworkAclEntryResponse CreateNetworkAclEntry(CreateNetworkAclEntryRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateNetworkAclEntryResponse> CreateNetworkAclEntryAsync(CreateNetworkAclEntryRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateNetworkInterfaceResponse CreateNetworkInterface(CreateNetworkInterfaceRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateNetworkInterfaceResponse> CreateNetworkInterfaceAsync(CreateNetworkInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreatePlacementGroupResponse CreatePlacementGroup(CreatePlacementGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreatePlacementGroupResponse> CreatePlacementGroupAsync(CreatePlacementGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateReservedInstancesListingResponse CreateReservedInstancesListing(CreateReservedInstancesListingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateReservedInstancesListingResponse> CreateReservedInstancesListingAsync(CreateReservedInstancesListingRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateRouteResponse CreateRoute(CreateRouteRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateRouteResponse> CreateRouteAsync(CreateRouteRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateRouteTableResponse CreateRouteTable(CreateRouteTableRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateRouteTableResponse> CreateRouteTableAsync(CreateRouteTableRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateSpotDatafeedSubscriptionResponse CreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateSpotDatafeedSubscriptionResponse> CreateSpotDatafeedSubscriptionAsync(CreateSpotDatafeedSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateSubnetResponse CreateSubnet(CreateSubnetRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateSubnetResponse> CreateSubnetAsync(CreateSubnetRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateVolumeResponse CreateVolume(CreateVolumeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateVolumeResponse> CreateVolumeAsync(CreateVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateVpcResponse CreateVpc(CreateVpcRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateVpcResponse> CreateVpcAsync(CreateVpcRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateVpcEndpointResponse CreateVpcEndpoint(CreateVpcEndpointRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateVpcEndpointResponse> CreateVpcEndpointAsync(CreateVpcEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateVpcPeeringConnectionResponse CreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateVpcPeeringConnectionResponse> CreateVpcPeeringConnectionAsync(CreateVpcPeeringConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateVpnConnectionResponse> CreateVpnConnectionAsync(CreateVpnConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateVpnConnectionRouteResponse CreateVpnConnectionRoute(CreateVpnConnectionRouteRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateVpnConnectionRouteResponse> CreateVpnConnectionRouteAsync(CreateVpnConnectionRouteRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public CreateVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CreateVpnGatewayResponse> CreateVpnGatewayAsync(CreateVpnGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteCustomerGatewayResponse DeleteCustomerGateway(DeleteCustomerGatewayRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteCustomerGatewayResponse> DeleteCustomerGatewayAsync(DeleteCustomerGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteDhcpOptionsResponse DeleteDhcpOptions(DeleteDhcpOptionsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteDhcpOptionsResponse> DeleteDhcpOptionsAsync(DeleteDhcpOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteFlowLogsResponse DeleteFlowLogs(DeleteFlowLogsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteFlowLogsResponse> DeleteFlowLogsAsync(DeleteFlowLogsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteInternetGatewayResponse DeleteInternetGateway(DeleteInternetGatewayRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteInternetGatewayResponse> DeleteInternetGatewayAsync(DeleteInternetGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteKeyPairResponse> DeleteKeyPairAsync(DeleteKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteNatGatewayResponse DeleteNatGateway(DeleteNatGatewayRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteNatGatewayResponse> DeleteNatGatewayAsync(DeleteNatGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteNetworkAclResponse DeleteNetworkAcl(DeleteNetworkAclRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteNetworkAclResponse> DeleteNetworkAclAsync(DeleteNetworkAclRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteNetworkAclEntryResponse DeleteNetworkAclEntry(DeleteNetworkAclEntryRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteNetworkAclEntryResponse> DeleteNetworkAclEntryAsync(DeleteNetworkAclEntryRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteNetworkInterfaceResponse DeleteNetworkInterface(DeleteNetworkInterfaceRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterfaceAsync(DeleteNetworkInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeletePlacementGroupResponse DeletePlacementGroup(DeletePlacementGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeletePlacementGroupResponse> DeletePlacementGroupAsync(DeletePlacementGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteRouteResponse DeleteRoute(DeleteRouteRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteRouteResponse> DeleteRouteAsync(DeleteRouteRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteRouteTableResponse DeleteRouteTable(DeleteRouteTableRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteRouteTableResponse> DeleteRouteTableAsync(DeleteRouteTableRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription()
        {
            throw new NotImplementedException();
        }

        public DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteSpotDatafeedSubscriptionResponse> DeleteSpotDatafeedSubscriptionAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DeleteSpotDatafeedSubscriptionResponse> DeleteSpotDatafeedSubscriptionAsync(DeleteSpotDatafeedSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteSubnetResponse> DeleteSubnetAsync(DeleteSubnetRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteVpcResponse DeleteVpc(DeleteVpcRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteVpcResponse> DeleteVpcAsync(DeleteVpcRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteVpcEndpointsResponse DeleteVpcEndpoints(DeleteVpcEndpointsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteVpcEndpointsResponse> DeleteVpcEndpointsAsync(DeleteVpcEndpointsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteVpcPeeringConnectionResponse DeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteVpcPeeringConnectionResponse> DeleteVpcPeeringConnectionAsync(DeleteVpcPeeringConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteVpnConnectionResponse DeleteVpnConnection(DeleteVpnConnectionRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteVpnConnectionResponse> DeleteVpnConnectionAsync(DeleteVpnConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteVpnConnectionRouteResponse DeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteVpnConnectionRouteResponse> DeleteVpnConnectionRouteAsync(DeleteVpnConnectionRouteRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeleteVpnGatewayResponse DeleteVpnGateway(DeleteVpnGatewayRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteVpnGatewayResponse> DeleteVpnGatewayAsync(DeleteVpnGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DeregisterImageResponse DeregisterImage(DeregisterImageRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DeregisterImageResponse> DeregisterImageAsync(DeregisterImageRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeAccountAttributesResponse DescribeAccountAttributes()
        {
            throw new NotImplementedException();
        }

        public DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeAddressesResponse DescribeAddresses()
        {
            throw new NotImplementedException();
        }

        public DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeAddressesResponse> DescribeAddressesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeAddressesResponse> DescribeAddressesAsync(DescribeAddressesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeAvailabilityZonesResponse DescribeAvailabilityZones()
        {
            throw new NotImplementedException();
        }

        public DescribeAvailabilityZonesResponse DescribeAvailabilityZones(DescribeAvailabilityZonesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeAvailabilityZonesResponse> DescribeAvailabilityZonesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeAvailabilityZonesResponse> DescribeAvailabilityZonesAsync(DescribeAvailabilityZonesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeBundleTasksResponse DescribeBundleTasks()
        {
            throw new NotImplementedException();
        }

        public DescribeBundleTasksResponse DescribeBundleTasks(DescribeBundleTasksRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeBundleTasksResponse> DescribeBundleTasksAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeBundleTasksResponse> DescribeBundleTasksAsync(DescribeBundleTasksRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeClassicLinkInstancesResponse DescribeClassicLinkInstances(DescribeClassicLinkInstancesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeClassicLinkInstancesResponse> DescribeClassicLinkInstancesAsync(DescribeClassicLinkInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeConversionTasksResponse DescribeConversionTasks()
        {
            throw new NotImplementedException();
        }

        public DescribeConversionTasksResponse DescribeConversionTasks(DescribeConversionTasksRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeConversionTasksResponse> DescribeConversionTasksAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeConversionTasksResponse> DescribeConversionTasksAsync(DescribeConversionTasksRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeCustomerGatewaysResponse DescribeCustomerGateways()
        {
            throw new NotImplementedException();
        }

        public DescribeCustomerGatewaysResponse DescribeCustomerGateways(DescribeCustomerGatewaysRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeCustomerGatewaysResponse> DescribeCustomerGatewaysAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeCustomerGatewaysResponse> DescribeCustomerGatewaysAsync(DescribeCustomerGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeDhcpOptionsResponse DescribeDhcpOptions()
        {
            throw new NotImplementedException();
        }

        public DescribeDhcpOptionsResponse DescribeDhcpOptions(DescribeDhcpOptionsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeDhcpOptionsResponse> DescribeDhcpOptionsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeDhcpOptionsResponse> DescribeDhcpOptionsAsync(DescribeDhcpOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeExportTasksResponse DescribeExportTasks()
        {
            throw new NotImplementedException();
        }

        public DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeExportTasksResponse> DescribeExportTasksAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeFlowLogsResponse DescribeFlowLogs(DescribeFlowLogsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeFlowLogsResponse> DescribeFlowLogsAsync(DescribeFlowLogsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeHostReservationOfferingsResponse DescribeHostReservationOfferings(DescribeHostReservationOfferingsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeHostReservationOfferingsResponse> DescribeHostReservationOfferingsAsync(DescribeHostReservationOfferingsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeHostReservationsResponse DescribeHostReservations(DescribeHostReservationsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeHostReservationsResponse> DescribeHostReservationsAsync(DescribeHostReservationsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeHostsResponse DescribeHosts(DescribeHostsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeHostsResponse> DescribeHostsAsync(DescribeHostsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeIdentityIdFormatResponse DescribeIdentityIdFormat(DescribeIdentityIdFormatRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeIdentityIdFormatResponse> DescribeIdentityIdFormatAsync(DescribeIdentityIdFormatRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeIdFormatResponse DescribeIdFormat(DescribeIdFormatRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeIdFormatResponse> DescribeIdFormatAsync(DescribeIdFormatRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeImageAttributeResponse DescribeImageAttribute(DescribeImageAttributeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeImageAttributeResponse> DescribeImageAttributeAsync(DescribeImageAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeImagesResponse DescribeImages()
        {
            throw new NotImplementedException();
        }

        public DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeImagesResponse> DescribeImagesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeImportImageTasksResponse DescribeImportImageTasks(DescribeImportImageTasksRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeImportImageTasksResponse> DescribeImportImageTasksAsync(DescribeImportImageTasksRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeImportSnapshotTasksResponse DescribeImportSnapshotTasks(DescribeImportSnapshotTasksRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeImportSnapshotTasksResponse> DescribeImportSnapshotTasksAsync(DescribeImportSnapshotTasksRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeAsync(DescribeInstanceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeInstancesResponse DescribeInstances()
        {
            throw new NotImplementedException();
        }

        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeInstancesResponse> DescribeInstancesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeInstanceStatusResponse DescribeInstanceStatus()
        {
            throw new NotImplementedException();
        }

        public DescribeInstanceStatusResponse DescribeInstanceStatus(DescribeInstanceStatusRequest request)
        {
            return DescribeInstanceStatusAsync(request).Result;
        }

        public Task<DescribeInstanceStatusResponse> DescribeInstanceStatusAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeInstanceStatusAsync(null, cancellationToken);
        }

        public async Task<DescribeInstanceStatusResponse> DescribeInstanceStatusAsync(DescribeInstanceStatusRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Delay(100);
            var response = new DescribeInstanceStatusResponse
            {
                HttpStatusCode = System.Net.HttpStatusCode.OK,
                ContentLength = 2,
                NextToken = null,
                InstanceStatuses = new List<InstanceStatus>
                {
                    new InstanceStatus
                    {
                        InstanceId = "test-instance-a",
                        InstanceState = new InstanceState
                        {
                            Name = InstanceStateName.Stopped
                        }
                    },
                    new InstanceStatus
                    {
                        InstanceId = "test-instance-b",
                        InstanceState = new InstanceState
                        {
                            Name = InstanceStateName.Running
                        }
                    }
                }
            };
            return response;
        }

        public DescribeInternetGatewaysResponse DescribeInternetGateways()
        {
            throw new NotImplementedException();
        }

        public DescribeInternetGatewaysResponse DescribeInternetGateways(DescribeInternetGatewaysRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeInternetGatewaysResponse> DescribeInternetGatewaysAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeInternetGatewaysResponse> DescribeInternetGatewaysAsync(DescribeInternetGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeKeyPairsResponse DescribeKeyPairs()
        {
            throw new NotImplementedException();
        }

        public DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(DescribeKeyPairsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeMovingAddressesResponse DescribeMovingAddresses(DescribeMovingAddressesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeMovingAddressesResponse> DescribeMovingAddressesAsync(DescribeMovingAddressesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeNatGatewaysResponse DescribeNatGateways(DescribeNatGatewaysRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeNatGatewaysResponse> DescribeNatGatewaysAsync(DescribeNatGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeNetworkAclsResponse DescribeNetworkAcls()
        {
            throw new NotImplementedException();
        }

        public DescribeNetworkAclsResponse DescribeNetworkAcls(DescribeNetworkAclsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeNetworkAclsResponse> DescribeNetworkAclsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeNetworkAclsResponse> DescribeNetworkAclsAsync(DescribeNetworkAclsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeNetworkInterfaceAttributeResponse DescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeNetworkInterfaceAttributeResponse> DescribeNetworkInterfaceAttributeAsync(DescribeNetworkInterfaceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeNetworkInterfacesResponse DescribeNetworkInterfaces()
        {
            throw new NotImplementedException();
        }

        public DescribeNetworkInterfacesResponse DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(DescribeNetworkInterfacesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribePlacementGroupsResponse DescribePlacementGroups()
        {
            throw new NotImplementedException();
        }

        public DescribePlacementGroupsResponse DescribePlacementGroups(DescribePlacementGroupsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribePlacementGroupsResponse> DescribePlacementGroupsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribePlacementGroupsResponse> DescribePlacementGroupsAsync(DescribePlacementGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribePrefixListsResponse DescribePrefixLists(DescribePrefixListsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribePrefixListsResponse> DescribePrefixListsAsync(DescribePrefixListsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeRegionsResponse DescribeRegions()
        {
            throw new NotImplementedException();
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeRegionsResponse> DescribeRegionsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeReservedInstancesResponse DescribeReservedInstances()
        {
            throw new NotImplementedException();
        }

        public DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(DescribeReservedInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings()
        {
            throw new NotImplementedException();
        }

        public DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeReservedInstancesListingsResponse> DescribeReservedInstancesListingsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeReservedInstancesListingsResponse> DescribeReservedInstancesListingsAsync(DescribeReservedInstancesListingsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications()
        {
            throw new NotImplementedException();
        }

        public DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeReservedInstancesModificationsResponse> DescribeReservedInstancesModificationsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeReservedInstancesModificationsResponse> DescribeReservedInstancesModificationsAsync(DescribeReservedInstancesModificationsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings()
        {
            throw new NotImplementedException();
        }

        public DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeReservedInstancesOfferingsResponse> DescribeReservedInstancesOfferingsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeReservedInstancesOfferingsResponse> DescribeReservedInstancesOfferingsAsync(DescribeReservedInstancesOfferingsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeRouteTablesResponse DescribeRouteTables()
        {
            throw new NotImplementedException();
        }

        public DescribeRouteTablesResponse DescribeRouteTables(DescribeRouteTablesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeRouteTablesResponse> DescribeRouteTablesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeRouteTablesResponse> DescribeRouteTablesAsync(DescribeRouteTablesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeScheduledInstanceAvailabilityResponse DescribeScheduledInstanceAvailability(DescribeScheduledInstanceAvailabilityRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeScheduledInstanceAvailabilityResponse> DescribeScheduledInstanceAvailabilityAsync(DescribeScheduledInstanceAvailabilityRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeScheduledInstancesResponse DescribeScheduledInstances(DescribeScheduledInstancesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeScheduledInstancesResponse> DescribeScheduledInstancesAsync(DescribeScheduledInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeSecurityGroupReferencesResponse DescribeSecurityGroupReferences(DescribeSecurityGroupReferencesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeSecurityGroupReferencesResponse> DescribeSecurityGroupReferencesAsync(DescribeSecurityGroupReferencesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeSecurityGroupsResponse DescribeSecurityGroups()
        {
            throw new NotImplementedException();
        }

        public DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(DescribeSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeSnapshotAttributeResponse DescribeSnapshotAttribute(DescribeSnapshotAttributeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeSnapshotAttributeResponse> DescribeSnapshotAttributeAsync(DescribeSnapshotAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeSnapshotsResponse DescribeSnapshots()
        {
            throw new NotImplementedException();
        }

        public DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription()
        {
            throw new NotImplementedException();
        }

        public DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeSpotDatafeedSubscriptionResponse> DescribeSpotDatafeedSubscriptionAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeSpotDatafeedSubscriptionResponse> DescribeSpotDatafeedSubscriptionAsync(DescribeSpotDatafeedSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeSpotFleetInstancesResponse DescribeSpotFleetInstances(DescribeSpotFleetInstancesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeSpotFleetInstancesResponse> DescribeSpotFleetInstancesAsync(DescribeSpotFleetInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeSpotFleetRequestHistoryResponse DescribeSpotFleetRequestHistory(DescribeSpotFleetRequestHistoryRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeSpotFleetRequestHistoryResponse> DescribeSpotFleetRequestHistoryAsync(DescribeSpotFleetRequestHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeSpotFleetRequestsResponse DescribeSpotFleetRequests(DescribeSpotFleetRequestsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeSpotFleetRequestsResponse> DescribeSpotFleetRequestsAsync(DescribeSpotFleetRequestsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests()
        {
            throw new NotImplementedException();
        }

        public DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeSpotInstanceRequestsResponse> DescribeSpotInstanceRequestsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeSpotInstanceRequestsResponse> DescribeSpotInstanceRequestsAsync(DescribeSpotInstanceRequestsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory()
        {
            throw new NotImplementedException();
        }

        public DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeSpotPriceHistoryResponse> DescribeSpotPriceHistoryAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeSpotPriceHistoryResponse> DescribeSpotPriceHistoryAsync(DescribeSpotPriceHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeStaleSecurityGroupsResponse DescribeStaleSecurityGroups(DescribeStaleSecurityGroupsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeStaleSecurityGroupsResponse> DescribeStaleSecurityGroupsAsync(DescribeStaleSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeSubnetsResponse DescribeSubnets()
        {
            throw new NotImplementedException();
        }

        public DescribeSubnetsResponse DescribeSubnets(DescribeSubnetsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeSubnetsResponse> DescribeSubnetsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeSubnetsResponse> DescribeSubnetsAsync(DescribeSubnetsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeTagsResponse DescribeTags()
        {
            throw new NotImplementedException();
        }

        public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeTagsResponse> DescribeTagsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeVolumeAttributeResponse DescribeVolumeAttribute(DescribeVolumeAttributeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeVolumeAttributeResponse> DescribeVolumeAttributeAsync(DescribeVolumeAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeVolumesResponse DescribeVolumes()
        {
            throw new NotImplementedException();
        }

        public DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeVolumesResponse> DescribeVolumesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeVolumeStatusResponse DescribeVolumeStatus()
        {
            throw new NotImplementedException();
        }

        public DescribeVolumeStatusResponse DescribeVolumeStatus(DescribeVolumeStatusRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeVolumeStatusResponse> DescribeVolumeStatusAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeVolumeStatusResponse> DescribeVolumeStatusAsync(DescribeVolumeStatusRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeVpcAttributeResponse DescribeVpcAttribute(DescribeVpcAttributeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeVpcAttributeResponse> DescribeVpcAttributeAsync(DescribeVpcAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeVpcClassicLinkResponse DescribeVpcClassicLink(DescribeVpcClassicLinkRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeVpcClassicLinkResponse> DescribeVpcClassicLinkAsync(DescribeVpcClassicLinkRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeVpcClassicLinkDnsSupportResponse DescribeVpcClassicLinkDnsSupport(DescribeVpcClassicLinkDnsSupportRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeVpcClassicLinkDnsSupportResponse> DescribeVpcClassicLinkDnsSupportAsync(DescribeVpcClassicLinkDnsSupportRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeVpcEndpointsResponse DescribeVpcEndpoints(DescribeVpcEndpointsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeVpcEndpointsResponse> DescribeVpcEndpointsAsync(DescribeVpcEndpointsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeVpcEndpointServicesResponse DescribeVpcEndpointServices(DescribeVpcEndpointServicesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeVpcEndpointServicesResponse> DescribeVpcEndpointServicesAsync(DescribeVpcEndpointServicesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections()
        {
            throw new NotImplementedException();
        }

        public DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(DescribeVpcPeeringConnectionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeVpcsResponse DescribeVpcs()
        {
            throw new NotImplementedException();
        }

        public DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeVpcsResponse> DescribeVpcsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeVpcsResponse> DescribeVpcsAsync(DescribeVpcsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeVpnConnectionsResponse DescribeVpnConnections()
        {
            throw new NotImplementedException();
        }

        public DescribeVpnConnectionsResponse DescribeVpnConnections(DescribeVpnConnectionsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeVpnConnectionsResponse> DescribeVpnConnectionsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeVpnConnectionsResponse> DescribeVpnConnectionsAsync(DescribeVpnConnectionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DescribeVpnGatewaysResponse DescribeVpnGateways()
        {
            throw new NotImplementedException();
        }

        public DescribeVpnGatewaysResponse DescribeVpnGateways(DescribeVpnGatewaysRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DescribeVpnGatewaysResponse> DescribeVpnGatewaysAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<DescribeVpnGatewaysResponse> DescribeVpnGatewaysAsync(DescribeVpnGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DetachClassicLinkVpcResponse DetachClassicLinkVpc(DetachClassicLinkVpcRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DetachClassicLinkVpcResponse> DetachClassicLinkVpcAsync(DetachClassicLinkVpcRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DetachInternetGatewayResponse DetachInternetGateway(DetachInternetGatewayRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DetachInternetGatewayResponse> DetachInternetGatewayAsync(DetachInternetGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DetachNetworkInterfaceResponse DetachNetworkInterface(DetachNetworkInterfaceRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DetachNetworkInterfaceResponse> DetachNetworkInterfaceAsync(DetachNetworkInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DetachVolumeResponse DetachVolume(DetachVolumeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DetachVolumeResponse> DetachVolumeAsync(DetachVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DetachVpnGatewayResponse DetachVpnGateway(DetachVpnGatewayRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DetachVpnGatewayResponse> DetachVpnGatewayAsync(DetachVpnGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DisableVgwRoutePropagationResponse DisableVgwRoutePropagation(DisableVgwRoutePropagationRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DisableVgwRoutePropagationResponse> DisableVgwRoutePropagationAsync(DisableVgwRoutePropagationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DisableVpcClassicLinkResponse DisableVpcClassicLink(DisableVpcClassicLinkRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DisableVpcClassicLinkResponse> DisableVpcClassicLinkAsync(DisableVpcClassicLinkRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DisableVpcClassicLinkDnsSupportResponse DisableVpcClassicLinkDnsSupport(DisableVpcClassicLinkDnsSupportRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DisableVpcClassicLinkDnsSupportResponse> DisableVpcClassicLinkDnsSupportAsync(DisableVpcClassicLinkDnsSupportRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DisassociateAddressResponse DisassociateAddress(DisassociateAddressRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DisassociateAddressResponse> DisassociateAddressAsync(DisassociateAddressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public DisassociateRouteTableResponse DisassociateRouteTable(DisassociateRouteTableRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DisassociateRouteTableResponse> DisassociateRouteTableAsync(DisassociateRouteTableRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public EnableVgwRoutePropagationResponse EnableVgwRoutePropagation(EnableVgwRoutePropagationRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<EnableVgwRoutePropagationResponse> EnableVgwRoutePropagationAsync(EnableVgwRoutePropagationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public EnableVolumeIOResponse EnableVolumeIO(EnableVolumeIORequest request)
        {
            throw new NotImplementedException();
        }

        public Task<EnableVolumeIOResponse> EnableVolumeIOAsync(EnableVolumeIORequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public EnableVpcClassicLinkResponse EnableVpcClassicLink(EnableVpcClassicLinkRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<EnableVpcClassicLinkResponse> EnableVpcClassicLinkAsync(EnableVpcClassicLinkRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public EnableVpcClassicLinkDnsSupportResponse EnableVpcClassicLinkDnsSupport(EnableVpcClassicLinkDnsSupportRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<EnableVpcClassicLinkDnsSupportResponse> EnableVpcClassicLinkDnsSupportAsync(EnableVpcClassicLinkDnsSupportRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public GetConsoleOutputResponse GetConsoleOutput(GetConsoleOutputRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<GetConsoleOutputResponse> GetConsoleOutputAsync(GetConsoleOutputRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public GetConsoleScreenshotResponse GetConsoleScreenshot(GetConsoleScreenshotRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<GetConsoleScreenshotResponse> GetConsoleScreenshotAsync(GetConsoleScreenshotRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public GetHostReservationPurchasePreviewResponse GetHostReservationPurchasePreview(GetHostReservationPurchasePreviewRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<GetHostReservationPurchasePreviewResponse> GetHostReservationPurchasePreviewAsync(GetHostReservationPurchasePreviewRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public GetPasswordDataResponse GetPasswordData(GetPasswordDataRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<GetPasswordDataResponse> GetPasswordDataAsync(GetPasswordDataRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ImportImageResponse ImportImage(ImportImageRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ImportImageResponse> ImportImageAsync(ImportImageRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ImportInstanceResponse ImportInstance(ImportInstanceRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ImportInstanceResponse> ImportInstanceAsync(ImportInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ImportSnapshotResponse ImportSnapshot(ImportSnapshotRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ImportSnapshotResponse> ImportSnapshotAsync(ImportSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ImportVolumeResponse ImportVolume(ImportVolumeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ImportVolumeResponse> ImportVolumeAsync(ImportVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ModifyHostsResponse ModifyHosts(ModifyHostsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ModifyHostsResponse> ModifyHostsAsync(ModifyHostsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ModifyIdentityIdFormatResponse ModifyIdentityIdFormat(ModifyIdentityIdFormatRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ModifyIdentityIdFormatResponse> ModifyIdentityIdFormatAsync(ModifyIdentityIdFormatRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ModifyIdFormatResponse ModifyIdFormat(ModifyIdFormatRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ModifyIdFormatResponse> ModifyIdFormatAsync(ModifyIdFormatRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ModifyImageAttributeResponse> ModifyImageAttributeAsync(ModifyImageAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeAsync(ModifyInstanceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ModifyInstancePlacementResponse ModifyInstancePlacement(ModifyInstancePlacementRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ModifyInstancePlacementResponse> ModifyInstancePlacementAsync(ModifyInstancePlacementRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ModifyNetworkInterfaceAttributeResponse> ModifyNetworkInterfaceAttributeAsync(ModifyNetworkInterfaceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ModifyReservedInstancesResponse ModifyReservedInstances(ModifyReservedInstancesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ModifyReservedInstancesResponse> ModifyReservedInstancesAsync(ModifyReservedInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ModifySnapshotAttributeResponse> ModifySnapshotAttributeAsync(ModifySnapshotAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ModifySpotFleetRequestResponse ModifySpotFleetRequest(ModifySpotFleetRequestRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ModifySpotFleetRequestResponse> ModifySpotFleetRequestAsync(ModifySpotFleetRequestRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ModifySubnetAttributeResponse ModifySubnetAttribute(ModifySubnetAttributeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ModifySubnetAttributeResponse> ModifySubnetAttributeAsync(ModifySubnetAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ModifyVolumeAttributeResponse ModifyVolumeAttribute(ModifyVolumeAttributeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ModifyVolumeAttributeResponse> ModifyVolumeAttributeAsync(ModifyVolumeAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ModifyVpcAttributeResponse ModifyVpcAttribute(ModifyVpcAttributeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ModifyVpcAttributeResponse> ModifyVpcAttributeAsync(ModifyVpcAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ModifyVpcEndpointResponse ModifyVpcEndpoint(ModifyVpcEndpointRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ModifyVpcEndpointResponse> ModifyVpcEndpointAsync(ModifyVpcEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ModifyVpcPeeringConnectionOptionsResponse ModifyVpcPeeringConnectionOptions(ModifyVpcPeeringConnectionOptionsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ModifyVpcPeeringConnectionOptionsResponse> ModifyVpcPeeringConnectionOptionsAsync(ModifyVpcPeeringConnectionOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public MonitorInstancesResponse MonitorInstances(MonitorInstancesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<MonitorInstancesResponse> MonitorInstancesAsync(MonitorInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public MoveAddressToVpcResponse MoveAddressToVpc(MoveAddressToVpcRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<MoveAddressToVpcResponse> MoveAddressToVpcAsync(MoveAddressToVpcRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public PurchaseHostReservationResponse PurchaseHostReservation(PurchaseHostReservationRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<PurchaseHostReservationResponse> PurchaseHostReservationAsync(PurchaseHostReservationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<PurchaseReservedInstancesOfferingResponse> PurchaseReservedInstancesOfferingAsync(PurchaseReservedInstancesOfferingRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public PurchaseScheduledInstancesResponse PurchaseScheduledInstances(PurchaseScheduledInstancesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<PurchaseScheduledInstancesResponse> PurchaseScheduledInstancesAsync(PurchaseScheduledInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public RebootInstancesResponse RebootInstances(RebootInstancesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<RebootInstancesResponse> RebootInstancesAsync(RebootInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public RegisterImageResponse RegisterImage(RegisterImageRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<RegisterImageResponse> RegisterImageAsync(RegisterImageRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public RejectVpcPeeringConnectionResponse RejectVpcPeeringConnection(RejectVpcPeeringConnectionRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<RejectVpcPeeringConnectionResponse> RejectVpcPeeringConnectionAsync(RejectVpcPeeringConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ReleaseAddressResponse ReleaseAddress(ReleaseAddressRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ReleaseAddressResponse> ReleaseAddressAsync(ReleaseAddressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ReleaseHostsResponse ReleaseHosts(ReleaseHostsRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ReleaseHostsResponse> ReleaseHostsAsync(ReleaseHostsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ReplaceNetworkAclAssociationResponse ReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ReplaceNetworkAclAssociationResponse> ReplaceNetworkAclAssociationAsync(ReplaceNetworkAclAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ReplaceNetworkAclEntryResponse ReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ReplaceNetworkAclEntryResponse> ReplaceNetworkAclEntryAsync(ReplaceNetworkAclEntryRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ReplaceRouteResponse ReplaceRoute(ReplaceRouteRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ReplaceRouteResponse> ReplaceRouteAsync(ReplaceRouteRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ReplaceRouteTableAssociationResponse> ReplaceRouteTableAssociationAsync(ReplaceRouteTableAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ReportInstanceStatusResponse ReportInstanceStatus(ReportInstanceStatusRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ReportInstanceStatusResponse> ReportInstanceStatusAsync(ReportInstanceStatusRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public RequestSpotFleetResponse RequestSpotFleet(RequestSpotFleetRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<RequestSpotFleetResponse> RequestSpotFleetAsync(RequestSpotFleetRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public RequestSpotInstancesResponse RequestSpotInstances(RequestSpotInstancesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<RequestSpotInstancesResponse> RequestSpotInstancesAsync(RequestSpotInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ResetImageAttributeResponse ResetImageAttribute(ResetImageAttributeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ResetImageAttributeResponse> ResetImageAttributeAsync(ResetImageAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ResetInstanceAttributeResponse ResetInstanceAttribute(ResetInstanceAttributeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ResetInstanceAttributeResponse> ResetInstanceAttributeAsync(ResetInstanceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ResetNetworkInterfaceAttributeResponse ResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ResetNetworkInterfaceAttributeResponse> ResetNetworkInterfaceAttributeAsync(ResetNetworkInterfaceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public ResetSnapshotAttributeResponse ResetSnapshotAttribute(ResetSnapshotAttributeRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ResetSnapshotAttributeResponse> ResetSnapshotAttributeAsync(ResetSnapshotAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public RestoreAddressToClassicResponse RestoreAddressToClassic(RestoreAddressToClassicRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<RestoreAddressToClassicResponse> RestoreAddressToClassicAsync(RestoreAddressToClassicRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<RevokeSecurityGroupEgressResponse> RevokeSecurityGroupEgressAsync(RevokeSecurityGroupEgressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public RevokeSecurityGroupIngressResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<RevokeSecurityGroupIngressResponse> RevokeSecurityGroupIngressAsync(RevokeSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public RunInstancesResponse RunInstances(RunInstancesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<RunInstancesResponse> RunInstancesAsync(RunInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public RunScheduledInstancesResponse RunScheduledInstances(RunScheduledInstancesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<RunScheduledInstancesResponse> RunScheduledInstancesAsync(RunScheduledInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public StartInstancesResponse StartInstances(StartInstancesRequest request)
        {
            return StartInstancesAsync(request).Result;
        }

        public async Task<StartInstancesResponse> StartInstancesAsync(StartInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Delay(100);
            var response = new StartInstancesResponse
            {
                HttpStatusCode = System.Net.HttpStatusCode.OK,
                ContentLength = 1,
                StartingInstances = request.InstanceIds.Select(x => new InstanceStateChange
                {
                    InstanceId = x,
                    CurrentState = new InstanceState { Name = InstanceStateName.Running },
                    PreviousState = new InstanceState { Name = InstanceStateName.Stopped }
                }).ToList()
            };
            return response;
        }

        public StopInstancesResponse StopInstances(StopInstancesRequest request)
        {
            return StopInstancesAsync(request).Result;
        }

        public async Task<StopInstancesResponse> StopInstancesAsync(StopInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Delay(100);
            var response = new StopInstancesResponse
            {
                HttpStatusCode = System.Net.HttpStatusCode.OK,
                ContentLength = 1,
                StoppingInstances = request.InstanceIds.Select(x => new InstanceStateChange
                {
                    InstanceId = x,
                    CurrentState = new InstanceState { Name = InstanceStateName.Stopped },
                    PreviousState = new InstanceState { Name = InstanceStateName.Running }
                }).ToList()
            };
            return response;
        }

        public TerminateInstancesResponse TerminateInstances(TerminateInstancesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<TerminateInstancesResponse> TerminateInstancesAsync(TerminateInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public UnassignPrivateIpAddressesResponse UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<UnassignPrivateIpAddressesResponse> UnassignPrivateIpAddressesAsync(UnassignPrivateIpAddressesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public UnmonitorInstancesResponse UnmonitorInstances(UnmonitorInstancesRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<UnmonitorInstancesResponse> UnmonitorInstancesAsync(UnmonitorInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
    }
}
