using System.Collections.Generic;
using System.Threading.Tasks;
using Nethereum.JsonRpc.Client;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.RPC.Infrastructure;

namespace Nethereum.RPC.Eth.ProofOfStake
{
    public interface IEthGetStakingDetails : IGenericRpcRequestResponseHandlerNoParam<StakingDetails>
    {

    }
}
