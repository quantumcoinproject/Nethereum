using Nethereum.Hex.HexTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nethereum.RPC.Eth.DTOs
{
    public class ValidatorDetails
    {
        /// <summary>
        ///     Validator address
        /// </summary>
        [JsonProperty(PropertyName = "validator")]
        public string Validator { get; set; }

        /// <summary>
        ///     Depositor address
        /// </summary>
        [JsonProperty(PropertyName = "depositor")]
        public string Depositor { get; set; }

        /// <summary>
        /// Deposited Balance
        /// </summary>
        [JsonProperty(PropertyName = "balance")]
        public HexBigInteger Balance { get; set; }

        /// <summary>
        /// Net Deposited Balance (Deposit + rewards - slashings)
        /// </summary>
        [JsonProperty(PropertyName = "netBalance")]
        public HexBigInteger NetBalance { get; set; }

        /// <summary>
        /// Block Mining Rewards
        /// </summary>
        [JsonProperty(PropertyName = "blockRewards")]
        public HexBigInteger BlockRewards { get; set; }

        /// <summary>
        /// Slashings (penalty / fine)
        /// </summary>
        [JsonProperty(PropertyName = "slashings")]
        public HexBigInteger Slashings { get; set; }

        /// <summary>
        /// Is Validation Paused
        /// </summary>
        [JsonProperty(PropertyName = "isValidationPaused")]
        public Boolean IsValidationPaused { get; set; }

        /// <summary>
        /// Withdrawal Block
        /// </summary>
        [JsonProperty(PropertyName = "withdrawalBlock")]
        public HexBigInteger Value { get; set; }
    }
}
