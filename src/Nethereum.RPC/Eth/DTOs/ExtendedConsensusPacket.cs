using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nethereum.RPC.Eth.DTOs
{
    public enum ConsensusPacketType
    {
        ProposeBlock = 0,
        AckBlockProposal = 1,
        PrecommitBlock = 2,
        CommitBlock = 3
    }

    /// <summary>
    /// This class represents the packets sent between validators as part of block voting.
    /// </summary>
    public class ExtendedConsensusPacket
    {
        /// <summary>
        ///     The signer (validator) address
        /// </summary>
        [JsonProperty(PropertyName = "signer")]
        public string Signer { get; set; }

        /// <summary>
        ///     The type of the consensus packet
        /// </summary>
        [JsonProperty(PropertyName = "packetType")]
        public ConsensusPacketType PacketType { get; set; }

        /// <summary>
        ///     The round of the block voting
        /// </summary>
        [JsonProperty(PropertyName = "round")]
        public byte Round { get; set; }
    }
}
