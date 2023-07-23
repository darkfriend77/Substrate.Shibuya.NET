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
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_block_reward;
   
   public class BlockRewardControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_block_reward.RewardDistributionConfig GetTestValue2()
      {
         Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_block_reward.RewardDistributionConfig result;
         result = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_block_reward.RewardDistributionConfig();
         result.BaseTreasuryPercent = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill>();
         result.BaseTreasuryPercent.Create(new Substrate.NetApi.CompactInteger(this.GetTestValue3().Value));
         result.BaseStakerPercent = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill>();
         result.BaseStakerPercent.Create(new Substrate.NetApi.CompactInteger(this.GetTestValue4().Value));
         result.DappsPercent = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill>();
         result.DappsPercent.Create(new Substrate.NetApi.CompactInteger(this.GetTestValue5().Value));
         result.CollatorsPercent = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill>();
         result.CollatorsPercent.Create(new Substrate.NetApi.CompactInteger(this.GetTestValue6().Value));
         result.AdjustablePercent = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill>();
         result.AdjustablePercent.Create(new Substrate.NetApi.CompactInteger(this.GetTestValue7().Value));
         result.IdealDappsStakingTvl = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill>();
         result.IdealDappsStakingTvl.Create(new Substrate.NetApi.CompactInteger(this.GetTestValue8().Value));
         return result;
      }
      public Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill GetTestValue3()
      {
         Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill result;
         result = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
         result.Value = this.GetTestValueU32();
         return result;
      }
      public Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill GetTestValue4()
      {
         Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill result;
         result = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
         result.Value = this.GetTestValueU32();
         return result;
      }
      public Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill GetTestValue5()
      {
         Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill result;
         result = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
         result.Value = this.GetTestValueU32();
         return result;
      }
      public Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill GetTestValue6()
      {
         Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill result;
         result = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
         result.Value = this.GetTestValueU32();
         return result;
      }
      public Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill GetTestValue7()
      {
         Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill result;
         result = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
         result.Value = this.GetTestValueU32();
         return result;
      }
      public Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill GetTestValue8()
      {
         Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill result;
         result = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_arithmetic.per_things.Perbill();
         result.Value = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestRewardDistributionConfigStorage()
      {
         // Construct new Mockup client to test with.
         BlockRewardControllerMockupClient mockupClient = new BlockRewardControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         BlockRewardControllerClient rpcClient = new BlockRewardControllerClient(_httpClient, subscriptionClient);
         Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_block_reward.RewardDistributionConfig mockupValue = this.GetTestValue2();


         Assert.IsTrue(await rpcClient.SubscribeRewardDistributionConfigStorage());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetRewardDistributionConfigStorage(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_block_reward.RewardDistributionConfig rpcResult = await rpcClient.GetRewardDistributionConfigStorage();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
