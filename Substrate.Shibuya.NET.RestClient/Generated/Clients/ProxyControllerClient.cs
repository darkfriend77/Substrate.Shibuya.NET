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
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Shibuya.NET.RestClient.Generated.Interfaces;
   
   public sealed class ProxyControllerClient : BaseClient, IProxyControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public ProxyControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BaseTuple<BoundedVecT13, U128>> GetProxies(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<BaseTuple<BoundedVecT13, U128>>(_httpClient, "proxy/proxies", Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ProxyStorage.ProxiesParams(key));
      }
      public async Task<bool> SubscribeProxies(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Proxy.Proxies", Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ProxyStorage.ProxiesParams(key));
      }
      public async Task<BaseTuple<BoundedVecT14, U128>> GetAnnouncements(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<BaseTuple<BoundedVecT14, U128>>(_httpClient, "proxy/announcements", Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ProxyStorage.AnnouncementsParams(key));
      }
      public async Task<bool> SubscribeAnnouncements(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Proxy.Announcements", Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ProxyStorage.AnnouncementsParams(key));
      }
   }
}
