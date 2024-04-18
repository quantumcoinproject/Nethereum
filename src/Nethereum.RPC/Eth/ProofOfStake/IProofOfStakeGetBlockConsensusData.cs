using System.Collections.Generic;
using System.Threading.Tasks;
using Nethereum.JsonRpc.Client;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.RPC.Infrastructure;
using Nethereum.Hex.HexTypes;

namespace Nethereum.RPC.Eth.ProofOfStake
{
    public interface IProofOfStakeGetBlockConsensusData
    {
        RpcRequest BuildRequest(HexBigInteger number, object id = null);

        Task<ConsensusData> SendRequestAsync(HexBigInteger number, object id = null);
    }
}
