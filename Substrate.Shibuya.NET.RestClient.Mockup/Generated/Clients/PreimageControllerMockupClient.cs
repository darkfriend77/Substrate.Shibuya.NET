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
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_preimage;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Shibuya.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class PreimageControllerMockupClient : MockupBaseClient, IPreimageControllerMockupClient
   {
      private HttpClient _httpClient;
      public PreimageControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetStatusFor(EnumRequestStatus value, Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Preimage/StatusFor", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.PreimageStorage.StatusForParams(key));
      }
      public async Task<bool> SetPreimageFor(BoundedVecT27 value, Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32> key)
      {
         return await SendMockupRequestAsync(_httpClient, "Preimage/PreimageFor", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.PreimageStorage.PreimageForParams(key));
      }
   }
}