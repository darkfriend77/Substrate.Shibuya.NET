//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Shibuya.NET.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Shibuya.NET.RestClient.Mockup.Generated.Clients;
   using Substrate.Shibuya.NET.RestClient.Generated.Clients;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm;
   using Substrate.NetApi.Model.Types.Primitive;
   
   public class XcAssetConfigControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation GetTestValue2()
      {
         Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation result;
         result = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation();
         result.Create(this.GetTestValueEnum<Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.VersionedMultiLocation>(), this.GetTestValueBaseVoid());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestAssetIdToLocation()
      {
         // Construct new Mockup client to test with.
         XcAssetConfigControllerMockupClient mockupClient = new XcAssetConfigControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcAssetConfigControllerClient rpcClient = new XcAssetConfigControllerClient(_httpClient, subscriptionClient);
         Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation mockupValue = this.GetTestValue2();
         Substrate.NetApi.Model.Types.Primitive.U128 mockupKey = this.GetTestValueU128();

         Assert.IsTrue(await rpcClient.SubscribeAssetIdToLocation(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAssetIdToLocation(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation rpcResult = await rpcClient.GetAssetIdToLocation(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation GetTestValue4()
      {
         Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation result;
         result = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation();
         result.Create(this.GetTestValueEnum<Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.VersionedMultiLocation>(), this.GetTestValueBaseVoid());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestAssetLocationToId()
      {
         // Construct new Mockup client to test with.
         XcAssetConfigControllerMockupClient mockupClient = new XcAssetConfigControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcAssetConfigControllerClient rpcClient = new XcAssetConfigControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U128 mockupValue = this.GetTestValueU128();
         Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation mockupKey = this.GetTestValue4();

         Assert.IsTrue(await rpcClient.SubscribeAssetLocationToId(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAssetLocationToId(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U128 rpcResult = await rpcClient.GetAssetLocationToId(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation GetTestValue6()
      {
         Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation result;
         result = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation();
         result.Create(this.GetTestValueEnum<Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.VersionedMultiLocation>(), this.GetTestValueBaseVoid());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestAssetLocationUnitsPerSecond()
      {
         // Construct new Mockup client to test with.
         XcAssetConfigControllerMockupClient mockupClient = new XcAssetConfigControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcAssetConfigControllerClient rpcClient = new XcAssetConfigControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U128 mockupValue = this.GetTestValueU128();
         Substrate.Shibuya.NET.NetApiExt.Generated.Model.xcm.EnumVersionedMultiLocation mockupKey = this.GetTestValue6();

         Assert.IsTrue(await rpcClient.SubscribeAssetLocationUnitsPerSecond(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAssetLocationUnitsPerSecond(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U128 rpcResult = await rpcClient.GetAssetLocationUnitsPerSecond(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
