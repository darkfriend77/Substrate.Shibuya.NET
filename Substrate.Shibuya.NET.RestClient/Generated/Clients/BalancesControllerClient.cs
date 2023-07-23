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
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_balances;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Shibuya.NET.RestClient.Generated.Interfaces;
   
   public sealed class BalancesControllerClient : BaseClient, IBalancesControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public BalancesControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U128> GetTotalIssuance()
      {
         return await SendRequestAsync<U128>(_httpClient, "balances/totalissuance");
      }
      public async Task<bool> SubscribeTotalIssuance()
      {
         return await _subscriptionClient.SubscribeAsync("Balances.TotalIssuance");
      }
      public async Task<U128> GetInactiveIssuance()
      {
         return await SendRequestAsync<U128>(_httpClient, "balances/inactiveissuance");
      }
      public async Task<bool> SubscribeInactiveIssuance()
      {
         return await _subscriptionClient.SubscribeAsync("Balances.InactiveIssuance");
      }
      public async Task<AccountData> GetAccount(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<AccountData>(_httpClient, "balances/account", Substrate.Shibuya.NET.NetApiExt.Generated.Storage.BalancesStorage.AccountParams(key));
      }
      public async Task<bool> SubscribeAccount(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Balances.Account", Substrate.Shibuya.NET.NetApiExt.Generated.Storage.BalancesStorage.AccountParams(key));
      }
      public async Task<WeakBoundedVecT2> GetLocks(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<WeakBoundedVecT2>(_httpClient, "balances/locks", Substrate.Shibuya.NET.NetApiExt.Generated.Storage.BalancesStorage.LocksParams(key));
      }
      public async Task<bool> SubscribeLocks(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Balances.Locks", Substrate.Shibuya.NET.NetApiExt.Generated.Storage.BalancesStorage.LocksParams(key));
      }
      public async Task<BoundedVecT15> GetReserves(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<BoundedVecT15>(_httpClient, "balances/reserves", Substrate.Shibuya.NET.NetApiExt.Generated.Storage.BalancesStorage.ReservesParams(key));
      }
      public async Task<bool> SubscribeReserves(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Balances.Reserves", Substrate.Shibuya.NET.NetApiExt.Generated.Storage.BalancesStorage.ReservesParams(key));
      }
   }
}
