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
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things;
   using Substrate.Shibuya.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class BaseFeeControllerMockupClient : MockupBaseClient, IBaseFeeControllerMockupClient
   {
      private HttpClient _httpClient;
      public BaseFeeControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetBaseFeePerGas(U256 value)
      {
         return await SendMockupRequestAsync(_httpClient, "BaseFee/BaseFeePerGas", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.BaseFeeStorage.BaseFeePerGasParams());
      }
      public async Task<bool> SetElasticity(Permill value)
      {
         return await SendMockupRequestAsync(_httpClient, "BaseFee/Elasticity", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.BaseFeeStorage.ElasticityParams());
      }
   }
}
