using Nethereum.RPC.Eth.DTOs;
using Nethereum.RPC.Eth.ProofOfStake;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nethereum.RPC.Eth.Services
{
    public interface IEthApiProofOfStakeService
    {
        IProofOfStakeGetStakingDetails GetStakingDetails { get; }

        IProofOfStakeGetStakingDetailsByValidator GetStakingDetailsByValidator { get; }

        IProofOfStakeGetStakingDetailsByDepositor GetStakingDetailsByDepositor { get; }

        IProofOfStakeGetBlockConsensusData GetBlockConsensusData { get; }
    }
}
