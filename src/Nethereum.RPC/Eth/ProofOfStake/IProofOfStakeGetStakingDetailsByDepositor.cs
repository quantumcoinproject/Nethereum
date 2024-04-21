using System.Collections.Generic;
using System.Threading.Tasks;
using Nethereum.JsonRpc.Client;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.RPC.Infrastructure;
using Nethereum.Hex.HexTypes;


namespace Nethereum.RPC.Eth.ProofOfStake
{
    public interface IProofOfStakeGetStakingDetailsByDepositor
    {
        RpcRequest BuildRequest(string depositor, HexBigInteger number, object id = null);

        Task<ValidatorDetails> SendRequestAsync(string depositor, HexBigInteger number, object id = null);
    }
}
