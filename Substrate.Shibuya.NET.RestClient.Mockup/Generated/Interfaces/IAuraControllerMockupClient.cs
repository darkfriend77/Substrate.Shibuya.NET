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
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_consensus_slots;
   
   public interface IAuraControllerMockupClient
   {
      Task<bool> SetAuthorities(BoundedVecT18 value);
      Task<bool> SetCurrentSlot(Slot value);
   }
}
