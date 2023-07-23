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
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   
   public class AuraExtControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT18 GetTestValue2()
      {
         Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT18 result;
         result = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT18();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public>();
         result.Value.Create(new Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public[] {
                  this.GetTestValue3()});
         return result;
      }
      public Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public GetTestValue3()
      {
         Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public result;
         result = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_consensus_aura.sr25519.app_sr25519.Public();
         result.Value = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.sr25519.Public();
         result.Value = this.GetTestValue4();
         return result;
      }
      public Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.sr25519.Public GetTestValue4()
      {
         Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.sr25519.Public result;
         result = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.sr25519.Public();
         result.Value = new Substrate.Shibuya.NET.NetApiExt.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestAuthorities()
      {
         // Construct new Mockup client to test with.
         AuraExtControllerMockupClient mockupClient = new AuraExtControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         AuraExtControllerClient rpcClient = new AuraExtControllerClient(_httpClient, subscriptionClient);
         Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT18 mockupValue = this.GetTestValue2();


         Assert.IsTrue(await rpcClient.SubscribeAuthorities());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAuthorities(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT18 rpcResult = await rpcClient.GetAuthorities();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
