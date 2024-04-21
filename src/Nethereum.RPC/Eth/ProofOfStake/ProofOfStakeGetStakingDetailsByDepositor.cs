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
    ///     proofofstake_getStakingDetailsByDepositorAddress
    ///     Returns the DepositorDetails.
    ///     Parameters
    ///     none
    ///     Returns
    ///     ValidatorDetails - details of proof of stake staking.
    ///     Example
    ///     Request
    ///     curl -X POST --data '{"jsonrpc":"2.0","method":"proofofstake_getStakingDetailsByDepositorAddress","params":["0xabcdabcdabcd],["0x1"],"id":83}'
    /// </Summary>
    public class ProofOfStakeStakingDetailsByDepositor : RpcRequestResponseHandler<ValidatorDetails>, IProofOfStakeGetStakingDetailsByDepositor
    {
        public ProofOfStakeStakingDetailsByDepositor(IClient client)
                 : base(client, ApiMethods.proofofstake_getStakingDetailsByDepositorAddress.ToString())
        {
        }

        public Task<ValidatorDetails> SendRequestAsync(string depositor, HexBigInteger number, object id = null)
        {
            if (number == null) throw new ArgumentNullException(nameof(number));
            return base.SendRequestAsync(id, depositor, number);
        }

        public RpcRequest BuildRequest(string depositor, HexBigInteger number, object id = null)
        {
            if (number == null) throw new ArgumentNullException(nameof(number));
            return base.BuildRequest(id, depositor, number);
        }
    }
}

