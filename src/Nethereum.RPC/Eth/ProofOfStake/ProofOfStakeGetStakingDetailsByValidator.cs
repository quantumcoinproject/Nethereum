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
    ///     proofofstake_getStakingDetailsByValidatorAddress
    ///     Returns the ValidatorDetails.
    ///     Parameters
    ///     none
    ///     Returns
    ///     ValidatorDetails - details of proof of stake staking.
    ///     Example
    ///     Request
    ///     curl -X POST --data '{"jsonrpc":"2.0","method":"proofofstake_getStakingDetailsByValidatorAddress","params":["0xabcdabcdabcd],["0x1"],"id":83}'
    /// </Summary>
    public class ProofOfStakeStakingDetailsByValidator : RpcRequestResponseHandler<ValidatorDetails>, IProofOfStakeGetStakingDetailsByValidator
    {
        public ProofOfStakeStakingDetailsByValidator(IClient client)
                 : base(client, ApiMethods.proofofstake_getStakingDetailsByValidatorAddress.ToString())
        {
        }

        public Task<ValidatorDetails> SendRequestAsync(string validator, HexBigInteger number, object id = null)
        {
            if (number == null) throw new ArgumentNullException(nameof(number));
            return base.SendRequestAsync(id, validator, number);
        }

        public RpcRequest BuildRequest(string validator, HexBigInteger number, object id = null)
        {
            if (number == null) throw new ArgumentNullException(nameof(number));
            return base.BuildRequest(id, validator, number);
        }
    }
}

