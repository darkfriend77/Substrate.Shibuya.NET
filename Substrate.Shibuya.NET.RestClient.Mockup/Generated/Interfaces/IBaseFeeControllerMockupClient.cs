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
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things;
   
   public interface IBaseFeeControllerMockupClient
   {
      Task<bool> SetBaseFeePerGas(U256 value);
      Task<bool> SetElasticity(Permill value);
   }
}
