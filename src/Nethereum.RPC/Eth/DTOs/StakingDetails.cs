using Nethereum.Hex.HexTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nethereum.RPC.Eth.DTOs
{
    public class StakingDetails
    {
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }
        /// <summary>
        /// Total Deposited Balance by all depositors
        /// </summary>
        [JsonProperty(PropertyName = "totalDepositedBalance")]
        public HexBigInteger TotalDepositedBalance { get; set; }

        /// <summary>
        /// List of Validators
        /// </summary>
        [JsonProperty(PropertyName = "validators")]
        public List<ValidatorDetails> Validators { get; set; }
    }
}
