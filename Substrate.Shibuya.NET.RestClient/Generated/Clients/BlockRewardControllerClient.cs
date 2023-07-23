//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Shibuya.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_block_reward;
   using Substrate.Shibuya.NET.RestClient.Generated.Interfaces;
   
   public sealed class BlockRewardControllerClient : BaseClient, IBlockRewardControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public BlockRewardControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<RewardDistributionConfig> GetRewardDistributionConfigStorage()
      {
         return await SendRequestAsync<RewardDistributionConfig>(_httpClient, "blockreward/rewarddistributionconfigstorage");
      }
      public async Task<bool> SubscribeRewardDistributionConfigStorage()
      {
         return await _subscriptionClient.SubscribeAsync("BlockReward.RewardDistributionConfigStorage");
      }
   }
}
