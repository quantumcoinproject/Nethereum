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
    ///     eth_getStakingDetails
    ///     Returns the staking details.
    ///     Parameters
    ///     none
    ///     Returns
    ///     StakingDetails - details of proof of stake staking.
    ///     Example
    ///     Request
    ///     curl -X POST --data '{"jsonrpc":"2.0","method":"eth_getStakingDetails","params":[],"id":83}'
    /// </Summary>
    public class EthStakingDetails : GenericRpcRequestResponseHandlerNoParam<StakingDetails>, IEthGetStakingDetails
    {
        public EthStakingDetails(IClient client) : base(client, ApiMethods.eth_getStakingDetails.ToString())
        {
        }
    }
}
