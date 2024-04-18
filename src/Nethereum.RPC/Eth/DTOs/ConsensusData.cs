using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nethereum.RPC.Eth.DTOs
{
    public class ConsensusData
    {
        [JsonProperty(PropertyName = "data")]
        public BlockConsensusData Data { get; set; }

        [JsonProperty(PropertyName = "extendedConsensusPackets")]
        public ExtendedConsensusPacket[] ExtendedConsensusPackets { get; set; }
    }
}
