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
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_vesting;
   
   public interface IVestingControllerClient
   {
      Task<BoundedVecT16> GetVesting(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeVesting(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<EnumReleases> GetStorageVersion();
      Task<bool> SubscribeStorageVersion();
   }
}
