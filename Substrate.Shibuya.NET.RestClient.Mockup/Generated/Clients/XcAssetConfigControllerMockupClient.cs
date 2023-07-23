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
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Shibuya.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class XcAssetConfigControllerMockupClient : MockupBaseClient, IXcAssetConfigControllerMockupClient
   {
      private HttpClient _httpClient;
      public XcAssetConfigControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetAssetIdToLocation(EnumVersionedMultiLocation value, U128 key)
      {
         return await SendMockupRequestAsync(_httpClient, "XcAssetConfig/AssetIdToLocation", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.XcAssetConfigStorage.AssetIdToLocationParams(key));
      }
      public async Task<bool> SetAssetLocationToId(U128 value, EnumVersionedMultiLocation key)
      {
         return await SendMockupRequestAsync(_httpClient, "XcAssetConfig/AssetLocationToId", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.XcAssetConfigStorage.AssetLocationToIdParams(key));
      }
      public async Task<bool> SetAssetLocationUnitsPerSecond(U128 value, EnumVersionedMultiLocation key)
      {
         return await SendMockupRequestAsync(_httpClient, "XcAssetConfig/AssetLocationUnitsPerSecond", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.XcAssetConfigStorage.AssetLocationUnitsPerSecondParams(key));
      }
   }
}