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
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.ethereum.block;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.ethereum.receipt;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.fp_rpc;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types;
   using Substrate.Shibuya.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class EthereumControllerMockupClient : MockupBaseClient, IEthereumControllerMockupClient
   {
      private HttpClient _httpClient;
      public EthereumControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetPending(BaseVec<BaseTuple<Substrate.Shibuya.NET.NetApiExt.Generated.Model.ethereum.transaction.EnumTransactionV2, TransactionStatus, EnumReceiptV3>> value)
      {
         return await SendMockupRequestAsync(_httpClient, "Ethereum/Pending", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.EthereumStorage.PendingParams());
      }
      public async Task<bool> SetCurrentBlock(Block value)
      {
         return await SendMockupRequestAsync(_httpClient, "Ethereum/CurrentBlock", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.EthereumStorage.CurrentBlockParams());
      }
      public async Task<bool> SetCurrentReceipts(BaseVec<EnumReceiptV3> value)
      {
         return await SendMockupRequestAsync(_httpClient, "Ethereum/CurrentReceipts", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.EthereumStorage.CurrentReceiptsParams());
      }
      public async Task<bool> SetCurrentTransactionStatuses(BaseVec<TransactionStatus> value)
      {
         return await SendMockupRequestAsync(_httpClient, "Ethereum/CurrentTransactionStatuses", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.EthereumStorage.CurrentTransactionStatusesParams());
      }
      public async Task<bool> SetBlockHash(H256 value, U256 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Ethereum/BlockHash", value.Encode(), Substrate.Shibuya.NET.NetApiExt.Generated.Storage.EthereumStorage.BlockHashParams(key));
      }
   }
}
