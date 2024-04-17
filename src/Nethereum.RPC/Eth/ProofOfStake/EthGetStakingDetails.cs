using Nethereum.RPC.Eth.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Nethereum.Hex.HexTypes;
using Nethereum.JsonRpc.Client;
using Nethereum.RPC.Infrastructure;

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
    ///     curl -X POST --data '{"jsonrpc":"2.0","method":"proofofstake_getStakingDetails","params":[],"id":83}'
    /// </Summary>
    public class EthStakingDetails : GenericRpcRequestResponseHandlerNoParam<StakingDetails>, IEthGetStakingDetails
    {
        public EthStakingDetails(IClient client) : base(client, ApiMethods.proofofstake_getStakingDetails.ToString())
        {
        }
    }
}
