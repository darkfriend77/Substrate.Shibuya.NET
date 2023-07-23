//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Shibuya.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.shibuya_runtime;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_collective;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Substrate.Shibuya.NET.RestClient.Generated.Interfaces;
   
   public sealed class CouncilControllerClient : BaseClient, ICouncilControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public CouncilControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BoundedVecT25> GetProposals()
      {
         return await SendRequestAsync<BoundedVecT25>(_httpClient, "council/proposals");
      }
      public async Task<bool> SubscribeProposals()
      {
         return await _subscriptionClient.SubscribeAsync("Council.Proposals");
      }
      public async Task<EnumRuntimeCall> GetProposalOf(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendRequestAsync<EnumRuntimeCall>(_httpClient, "council/proposalof", Substrate.Shibuya.NET.NetApiExt.Generated.Storage.CouncilStorage.ProposalOfParams(key));
      }
      public async Task<bool> SubscribeProposalOf(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("Council.ProposalOf", Substrate.Shibuya.NET.NetApiExt.Generated.Storage.CouncilStorage.ProposalOfParams(key));
      }
      public async Task<Votes> GetVoting(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendRequestAsync<Votes>(_httpClient, "council/voting", Substrate.Shibuya.NET.NetApiExt.Generated.Storage.CouncilStorage.VotingParams(key));
      }
      public async Task<bool> SubscribeVoting(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("Council.Voting", Substrate.Shibuya.NET.NetApiExt.Generated.Storage.CouncilStorage.VotingParams(key));
      }
      public async Task<U32> GetProposalCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "council/proposalcount");
      }
      public async Task<bool> SubscribeProposalCount()
      {
         return await _subscriptionClient.SubscribeAsync("Council.ProposalCount");
      }
      public async Task<BaseVec<AccountId32>> GetMembers()
      {
         return await SendRequestAsync<BaseVec<AccountId32>>(_httpClient, "council/members");
      }
      public async Task<bool> SubscribeMembers()
      {
         return await _subscriptionClient.SubscribeAsync("Council.Members");
      }
      public async Task<AccountId32> GetPrime()
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "council/prime");
      }
      public async Task<bool> SubscribePrime()
      {
         return await _subscriptionClient.SubscribeAsync("Council.Prime");
      }
   }
}
