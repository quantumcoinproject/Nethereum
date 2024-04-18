using Nethereum.Web3;
using Nethereum.JsonRpc.IpcClient;
using Nethereum.Hex.HexTypes;
using Nethereum.RPC.Eth.DTOs;
using Newtonsoft.Json;

namespace CLI
{
    internal class Program
    {
        static IWeb3 web3;

        static async Task Main(string[] args)
        {
            var clientConnString = Environment.GetEnvironmentVariable("CLIENT_CONNECTION_STRING");
            if(clientConnString == null)
            {
                Console.WriteLine("CLIENT_CONNECTION_STRING environment variable is missing");
                return;
            }

            if(clientConnString.Contains(".ipc"))
            {
                IpcClient ipcClient = new IpcClient(clientConnString);
                web3 = new Web3(ipcClient);
            }
            else
            {
                web3 = new Web3(clientConnString);
            }

            var blockNumber = await GetLatestBlockNumerAsync();
            Console.WriteLine("Latest Block {0}", blockNumber);


            var stakingDetails = await GetLatestStakingDetails(blockNumber);
            Console.WriteLine("Latest Staking Details:");
            Console.Write(JsonConvert.SerializeObject(stakingDetails,Formatting.Indented));

            var blockConsensusData = await web3.Eth.ProofOfStake.GetBlockConsensusData.SendRequestAsync(blockNumber);
            Console.WriteLine("Latest BlockConsensusData:");
            Console.Write(JsonConvert.SerializeObject(blockConsensusData, Formatting.Indented));
        }

        public static async Task<HexBigInteger> GetLatestBlockNumerAsync()
        {
            var res = await web3.Eth.Blocks.GetBlockNumber.SendRequestAsync();
            return res;
        }

        public static async Task<StakingDetails> GetLatestStakingDetails(HexBigInteger blockNumber)
        {
            var res = await web3.Eth.ProofOfStake.GetStakingDetails.SendRequestAsync(blockNumber);
            return res;
        }
    }
}
