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
            GetStakingDetails = new EthStakingDetails(client);
        }

        public IEthGetStakingDetails GetStakingDetails { get; }

    }
}
