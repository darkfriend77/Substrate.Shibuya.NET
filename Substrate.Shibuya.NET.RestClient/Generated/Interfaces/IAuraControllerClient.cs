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
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_consensus_slots;
   
   public interface IAuraControllerClient
   {
      Task<BoundedVecT18> GetAuthorities();
      Task<bool> SubscribeAuthorities();
      Task<Slot> GetCurrentSlot();
      Task<bool> SubscribeCurrentSlot();
   }
}
