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
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things;
   using Substrate.Shibuya.NET.RestClient.Generated.Interfaces;
   
   public sealed class BaseFeeControllerClient : BaseClient, IBaseFeeControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public BaseFeeControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U256> GetBaseFeePerGas()
      {
         return await SendRequestAsync<U256>(_httpClient, "basefee/basefeepergas");
      }
      public async Task<bool> SubscribeBaseFeePerGas()
      {
         return await _subscriptionClient.SubscribeAsync("BaseFee.BaseFeePerGas");
      }
      public async Task<Permill> GetElasticity()
      {
         return await SendRequestAsync<Permill>(_httpClient, "basefee/elasticity");
      }
      public async Task<bool> SubscribeElasticity()
      {
         return await _subscriptionClient.SubscribeAsync("BaseFee.Elasticity");
      }
   }
}
