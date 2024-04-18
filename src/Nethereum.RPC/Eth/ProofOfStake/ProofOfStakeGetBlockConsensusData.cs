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
    ///     proofofstake_getBlockConsensusData
    ///     Returns the consensus data of the block.
    ///     Parameters
    ///     none
    ///     Returns
    ///     ConsensusData - consensus data of the block.
    ///     Example
    ///     Request
    ///     curl -X POST --data '{"jsonrpc":"2.0","method":"proofofstake_getBlockConsensusData","params":["0x1"],"id":83}'
    /// </Summary>
    public class ProofOfStakeGetBlockConsensusData : RpcRequestResponseHandler<ConsensusData>, IProofOfStakeGetBlockConsensusData
    {
        public ProofOfStakeGetBlockConsensusData(IClient client)
         : base(client, ApiMethods.proofofstake_getBlockConsensusData.ToString())
        {
        }

        public Task<ConsensusData> SendRequestAsync(HexBigInteger number, object id = null)
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
