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
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.shibuya_runtime;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_collective;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Substrate.Shibuya.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class TechnicalCommitteeControllerMockupClient : MockupBaseClient, ITechnicalCommitteeControllerMockupClient
   {
      private HttpClient _httpClient;
      public TechnicalCommitteeControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetProposals(BoundedVecT25 value)
      {
         return await SendMockupRequestAsync(_httpClient, "TechnicalCommittee/Proposals", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.TechnicalCommitteeStorage.ProposalsParams());
      }
      public async Task<bool> SetProposalOf(EnumRuntimeCall value, Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "TechnicalCommittee/ProposalOf", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.TechnicalCommitteeStorage.ProposalOfParams(key));
      }
      public async Task<bool> SetVoting(Votes value, Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "TechnicalCommittee/Voting", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.TechnicalCommitteeStorage.VotingParams(key));
      }
      public async Task<bool> SetProposalCount(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "TechnicalCommittee/ProposalCount", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.TechnicalCommitteeStorage.ProposalCountParams());
      }
      public async Task<bool> SetMembers(BaseVec<AccountId32> value)
      {
         return await SendMockupRequestAsync(_httpClient, "TechnicalCommittee/Members", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.TechnicalCommitteeStorage.MembersParams());
      }
      public async Task<bool> SetPrime(AccountId32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "TechnicalCommittee/Prime", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.TechnicalCommitteeStorage.PrimeParams());
      }
   }
}
