//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Shibuya.NET.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_contracts.wasm;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_contracts.storage;
   using Substrate.Shibuya.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class ContractsControllerMockupClient : MockupBaseClient, IContractsControllerMockupClient
   {
      private HttpClient _httpClient;
      public ContractsControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetPristineCode(BoundedVecT21 value, Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Contracts/PristineCode", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ContractsStorage.PristineCodeParams(key));
      }
      public async Task<bool> SetCodeStorage(PrefabWasmModule value, Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Contracts/CodeStorage", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ContractsStorage.CodeStorageParams(key));
      }
      public async Task<bool> SetOwnerInfoOf(OwnerInfo value, Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Contracts/OwnerInfoOf", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ContractsStorage.OwnerInfoOfParams(key));
      }
      public async Task<bool> SetNonce(U64 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Contracts/Nonce", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ContractsStorage.NonceParams());
      }
      public async Task<bool> SetContractInfoOf(ContractInfo value, Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Contracts/ContractInfoOf", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ContractsStorage.ContractInfoOfParams(key));
      }
      public async Task<bool> SetDeletionQueue(BoundedVecT22 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Contracts/DeletionQueue", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ContractsStorage.DeletionQueueParams());
      }
   }
}