using System;
using System.Collections.Generic;
using System.Text;
using Nethereum.JsonRpc.Client;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.RPC.Eth.ProofOfStake;

namespace Nethereum.RPC.Eth.Services
{
    public class EthApiProofOfStakeService : RpcClientWrapper, IEthApiProofOfStakeService
    {
        public EthApiProofOfStakeService(IClient client) : base(client)
        {
            GetStakingDetails = new ProofOfStakeStakingDetails(client);
            GetBlockConsensusData = new ProofOfStakeGetBlockConsensusData(client);
            GetStakingDetailsByValidator = new ProofOfStakeStakingDetailsByValidator(client);
            GetStakingDetailsByDepositor = new ProofOfStakeStakingDetailsByDepositor(client);
        }

        public IProofOfStakeGetStakingDetails GetStakingDetails { get; }

        public IProofOfStakeGetStakingDetailsByValidator GetStakingDetailsByValidator { get; }

        public IProofOfStakeGetStakingDetailsByDepositor GetStakingDetailsByDepositor { get; }

        public IProofOfStakeGetBlockConsensusData GetBlockConsensusData { get; }
    }
}
