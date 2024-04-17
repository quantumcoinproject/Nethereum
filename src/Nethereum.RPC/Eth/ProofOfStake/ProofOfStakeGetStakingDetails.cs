using Nethereum.RPC.Eth.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Nethereum.Hex.HexTypes;
using Nethereum.JsonRpc.Client;
using Nethereum.RPC.Infrastructure;
using System.Threading.Tasks;
using System.Linq;

namespace Nethereum.RPC.Eth.ProofOfStake
{
    /// <Summary>
    ///     proofofstake_getStakingDetails
    ///     Returns the staking details.
    ///     Parameters
    ///     none
    ///     Returns
    ///     StakingDetails - details of proof of stake staking.
    ///     Example
    ///     Request
    ///     curl -X POST --data '{"jsonrpc":"2.0","method":"proofofstake_getStakingDetails","params":["0x1"],"id":83}'
    /// </Summary>
    public class ProofOfStakeStakingDetails : RpcRequestResponseHandler<StakingDetails>, IProofOfStakeGetStakingDetails
    {
        public ProofOfStakeStakingDetails(IClient client)
                 : base(client, ApiMethods.proofofstake_getStakingDetails.ToString())
        {
        }

        public Task<StakingDetails> SendRequestAsync(HexBigInteger number, object id = null)
        {
            if (number == null) throw new ArgumentNullException(nameof(number));
            return base.SendRequestAsync(id, number);
        }

        public RpcRequest BuildRequest(HexBigInteger number, object id = null)
        {
            if (number == null) throw new ArgumentNullException(nameof(number));
            return base.BuildRequest(id, number);
        }
    }
}

