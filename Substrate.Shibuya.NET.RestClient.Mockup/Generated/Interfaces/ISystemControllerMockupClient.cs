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
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_support.dispatch;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_runtime.generic.digest;
   
   public interface ISystemControllerMockupClient
   {
      Task<bool> SetAccount(AccountInfo value, Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SetExtrinsicCount(U32 value);
      Task<bool> SetBlockWeight(PerDispatchClassT1 value);
      Task<bool> SetAllExtrinsicsLen(U32 value);
      Task<bool> SetBlockHash(H256 value, U32 key);
      Task<bool> SetExtrinsicData(BaseVec<U8> value, U32 key);
      Task<bool> SetNumber(U32 value);
      Task<bool> SetParentHash(H256 value);
      Task<bool> SetDigest(Digest value);
      Task<bool> SetEvents(BaseVec<EventRecord> value);
      Task<bool> SetEventCount(U32 value);
      Task<bool> SetEventTopics(BaseVec<BaseTuple<U32, U32>> value, H256 key);
      Task<bool> SetLastRuntimeUpgrade(LastRuntimeUpgradeInfo value);
      Task<bool> SetUpgradedToU32RefCount(Bool value);
      Task<bool> SetUpgradedToTripleRefCount(Bool value);
      Task<bool> SetExecutionPhase(EnumPhase value);
   }
}
