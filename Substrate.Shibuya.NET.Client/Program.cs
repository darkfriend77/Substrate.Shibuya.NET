using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Yaml;
using Microsoft.VisualBasic;
using Serilog;
using Shibuya.Integration;
using Shibuya.Integration.Client;
using Shibuya.Integration.Helper;
using Substrate.NetApi;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Numerics;
using System.Text;

namespace Shibuya.Client
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            // configure serilog
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo
                .Console()
                .CreateLogger();

            var config = new ConfigurationBuilder()
                // this will be used more later on
                .SetBasePath(AppContext.BaseDirectory)
                // I chose using YML files for my config data as I am familiar with them
                .AddYamlFile("config.yml")
                .Build();

            // Add this to your C# console app's Main method to give yourself
            // a CancellationToken that is canceled when the user hits Ctrl+C.
            var cts = new CancellationTokenSource();
            Console.CancelKeyPress += (s, e) =>
            {
                Console.WriteLine("Canceling...");
                cts.Cancel();
                e.Cancel = true;
            };

            try
            {
                Console.WriteLine("Press Ctrl+C to end.");

                await RunClientAsync(config, cts.Token);
            }
            catch (OperationCanceledException)
            {
                // This is the normal way we close.
            }

            // Finally, once just before the application exits...
            await Log.CloseAndFlushAsync();
        }

        private static async Task RunClientAsync(IConfigurationRoot config, CancellationToken token)
        {
            var url = config["node:live"];
            var client = new ShibuyaNetwork(BaseClient.Alice, url);

            if (!await client.ConnectAsync(true, true, token))
            {
                Log.Error("Failed to connect to node");
                return;
            }

            Log.Information("Connected to {url}: {flag}", url, client.IsConnected);

            var blockNumber = await client.GetBlocknumberAsync(token);
            Log.Information("Current block is {number}", blockNumber != null ? blockNumber.Value : null);
            
            // do action in here ...
            Thread.Sleep(3000);

            /*
            var dest = BaseClient.Alice.ToAccountId32();
            var value = new BigInteger(1234);
            var gasLimit = new BigInteger(1234);
            var refTime = (ulong)0;
            var proofSize = (ulong)0;
            var storageDepositLimit = new BigInteger(1234);
            var data = Utils.HexToByteArray("0x1234567890123456");
            await client.ContractsCallAsync(dest, value, gasLimit, refTime, proofSize, storageDepositLimit, data, 1, token);
            */

            await client.DisconnectAsync();
            Log.Information("Disconnected from {url}", url);
        }
    }
}