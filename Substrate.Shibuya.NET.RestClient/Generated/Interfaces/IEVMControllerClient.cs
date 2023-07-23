//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Shibuya.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types;
   
   public interface IEVMControllerClient
   {
      Task<BaseVec<U8>> GetAccountCodes(H160 key);
      Task<bool> SubscribeAccountCodes(H160 key);
      Task<H256> GetAccountStorages(BaseTuple<H160, H256> key);
      Task<bool> SubscribeAccountStorages(BaseTuple<H160, H256> key);
   }
}
