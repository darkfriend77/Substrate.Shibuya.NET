//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Shibuya.NET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_xcm.pallet;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_weights.weight_v2;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   
   public interface IPolkadotXcmControllerMockupClient
   {
      Task<bool> SetQueryCounter(U64 value);
      Task<bool> SetQueries(EnumQueryStatus value, U64 key);
      Task<bool> SetAssetTraps(U32 value, Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<bool> SetSafeXcmVersion(U32 value);
      Task<bool> SetSupportedVersion(U32 value, BaseTuple<U32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation> key);
      Task<bool> SetVersionNotifiers(U64 value, BaseTuple<U32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation> key);
      Task<bool> SetVersionNotifyTargets(BaseTuple<U64, Weight, U32> value, BaseTuple<U32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation> key);
      Task<bool> SetVersionDiscoveryQueue(BoundedVecT19 value);
      Task<bool> SetCurrentMigration(EnumVersionMigrationStage value);
      Task<bool> SetRemoteLockedFungibles(RemoteLockedFungibleRecord value, BaseTuple<U32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedAssetId> key);
      Task<bool> SetLockedFungibles(BoundedVecT20 value, Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
   }
}
