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
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.fixed_point;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_transaction_payment;
   
   public interface ITransactionPaymentControllerMockupClient
   {
      Task<bool> SetNextFeeMultiplier(FixedU128 value);
      Task<bool> SetStorageVersion(EnumReleases value);
   }
}
