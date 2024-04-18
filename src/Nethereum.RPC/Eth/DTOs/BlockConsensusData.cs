using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nethereum.RPC.Eth.DTOs
{
    public enum VoteType
    {
        VoteTypeOk = 1,
        VoteTypeNil = 2
    }

    public class BlockConsensusData
    {
        /// <summary>
        ///     BlockProposer address, will be ZEERO ADDRESS for NIL blocks
        /// </summary>
        [JsonProperty(PropertyName = "blockProposer")]
        public string BlockProposer { get; set; }

        /// <summary>
        ///     VoteType, OK or NIL of the Block.
        /// </summary>
        [JsonProperty(PropertyName = "voteType")]
        public VoteType VoteType { get; set; }

        /// <summary>
        ///     ProposalHash of the block
        /// </summary>
        [JsonProperty(PropertyName = "proposalHash")]
        public string ProposalHash { get; set; }

        /// <summary>
        ///     PrecommitHash of the block
        /// </summary>
        [JsonProperty(PropertyName = "precommitHash")]
        public string PrecommitHash { get; set; }

        /// <summary>
        ///     Array - Array of block proposers who got slashed (penalty/fine)
        /// </summary>
        [JsonProperty(PropertyName = "nilvotedBlockProposers")]
        public string[] SlashedBlockProposers { get; set; }

        /// <summary>
        ///     The total number of rounds of voting.
        /// </summary>
        [JsonProperty(PropertyName = "round")]
        public byte Round { get; set; }

        /// <summary>
        ///     Array - Array of transactions selected to be included in the block. Not all transactions might actually be included due to issues like gas.
        /// </summary>
        [JsonProperty(PropertyName = "selectedTransactions")]
        public string[] SelectedTransactions { get; set; }
    }
}
