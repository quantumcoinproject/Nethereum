using System.Collections.Generic;
using System.Threading.Tasks;
using Nethereum.JsonRpc.Client;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.RPC.Infrastructure;
using Nethereum.Hex.HexTypes;
using Nethereum.JsonRpc.Client;
using Nethereum.RPC.Eth.DTOs;

namespace Nethereum.RPC.Eth.ProofOfStake
{
    public interface IProofOfStakeGetStakingDetails
    {
        RpcRequest BuildRequest(HexBigInteger number, object id = null);

        Task<StakingDetails> SendRequestAsync(HexBigInteger number, object id = null);
    }
}
