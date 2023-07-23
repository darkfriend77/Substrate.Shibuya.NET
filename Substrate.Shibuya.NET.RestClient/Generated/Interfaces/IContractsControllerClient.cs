//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Shibuya.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_contracts.wasm;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_contracts.storage;
   
   public interface IContractsControllerClient
   {
      Task<BoundedVecT21> GetPristineCode(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<bool> SubscribePristineCode(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<PrefabWasmModule> GetCodeStorage(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<bool> SubscribeCodeStorage(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<OwnerInfo> GetOwnerInfoOf(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<bool> SubscribeOwnerInfoOf(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<U64> GetNonce();
      Task<bool> SubscribeNonce();
      Task<ContractInfo> GetContractInfoOf(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeContractInfoOf(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<BoundedVecT22> GetDeletionQueue();
      Task<bool> SubscribeDeletionQueue();
   }
}
