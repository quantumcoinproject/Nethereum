using System.Collections.Generic;
using System.Threading.Tasks;
using Nethereum.JsonRpc.Client;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.RPC.Infrastructure;
using Nethereum.Hex.HexTypes;


namespace Nethereum.RPC.Eth.ProofOfStake
{
    public interface IProofOfStakeGetStakingDetailsByValidator
    {
        RpcRequest BuildRequest(string validator, HexBigInteger number, object id = null);

        Task<ValidatorDetails> SendRequestAsync(string validator, HexBigInteger number, object id = null);
    }
}
