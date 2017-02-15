// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Azure;
    using Management;
    using Network;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class BgpPeerStatus
    {
        /// <summary>
        /// Initializes a new instance of the BgpPeerStatus class.
        /// </summary>
        public BgpPeerStatus() { }

        /// <summary>
        /// Initializes a new instance of the BgpPeerStatus class.
        /// </summary>
        /// <param name="localAddress">The virtual network gateway's local
        /// address</param>
        /// <param name="neighbor">The remote BGP peer</param>
        /// <param name="asn">The autonomous system number of the remote BGP
        /// peer</param>
        /// <param name="state">The BGP peer state. Possible values include:
        /// 'Unknown', 'Stopped', 'Idle', 'Connecting', 'Connected'</param>
        /// <param name="connectedDuration">For how long the peering has been
        /// up</param>
        /// <param name="routesReceived">The number of routes learned from this
        /// peer</param>
        /// <param name="messagesSent">The number of BGP messages sent</param>
        /// <param name="messagesReceived">The number of BGP messages
        /// received</param>
        public BgpPeerStatus(string localAddress = default(string), string neighbor = default(string), int? asn = default(int?), string state = default(string), string connectedDuration = default(string), long? routesReceived = default(long?), long? messagesSent = default(long?), int? messagesReceived = default(int?))
        {
            LocalAddress = localAddress;
            Neighbor = neighbor;
            Asn = asn;
            State = state;
            ConnectedDuration = connectedDuration;
            RoutesReceived = routesReceived;
            MessagesSent = messagesSent;
            MessagesReceived = messagesReceived;
        }

        /// <summary>
        /// Gets the virtual network gateway's local address
        /// </summary>
        [JsonProperty(PropertyName = "localAddress")]
        public string LocalAddress { get; protected set; }

        /// <summary>
        /// Gets the remote BGP peer
        /// </summary>
        [JsonProperty(PropertyName = "neighbor")]
        public string Neighbor { get; protected set; }

        /// <summary>
        /// Gets the autonomous system number of the remote BGP peer
        /// </summary>
        [JsonProperty(PropertyName = "asn")]
        public int? Asn { get; protected set; }

        /// <summary>
        /// Gets the BGP peer state. Possible values include: 'Unknown',
        /// 'Stopped', 'Idle', 'Connecting', 'Connected'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; protected set; }

        /// <summary>
        /// Gets for how long the peering has been up
        /// </summary>
        [JsonProperty(PropertyName = "connectedDuration")]
        public string ConnectedDuration { get; protected set; }

        /// <summary>
        /// Gets the number of routes learned from this peer
        /// </summary>
        [JsonProperty(PropertyName = "routesReceived")]
        public long? RoutesReceived { get; protected set; }

        /// <summary>
        /// Gets the number of BGP messages sent
        /// </summary>
        [JsonProperty(PropertyName = "messagesSent")]
        public long? MessagesSent { get; protected set; }

        /// <summary>
        /// Gets the number of BGP messages received
        /// </summary>
        [JsonProperty(PropertyName = "messagesReceived")]
        public int? MessagesReceived { get; protected set; }

    }
}
