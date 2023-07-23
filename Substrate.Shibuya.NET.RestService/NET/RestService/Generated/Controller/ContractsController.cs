//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using Substrate.Shibuya.NET.RestService.Generated.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Shibuya.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// ContractsController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class ContractsController : ControllerBase
    {
        
        private IContractsStorage _contractsStorage;
        
        /// <summary>
        /// ContractsController constructor.
        /// </summary>
        public ContractsController(IContractsStorage contractsStorage)
        {
            _contractsStorage = contractsStorage;
        }
        
        /// <summary>
        /// >> PristineCode
        ///  A mapping from an original code hash to the original code, untouched by instrumentation.
        /// </summary>
        [HttpGet("PristineCode")]
        [ProducesResponseType(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT21), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ContractsStorage), "PristineCodeParams", typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256))]
        public IActionResult GetPristineCode(string key)
        {
            return this.Ok(_contractsStorage.GetPristineCode(key));
        }
        
        /// <summary>
        /// >> CodeStorage
        ///  A mapping between an original code hash and instrumented wasm code, ready for execution.
        /// </summary>
        [HttpGet("CodeStorage")]
        [ProducesResponseType(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_contracts.wasm.PrefabWasmModule), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ContractsStorage), "CodeStorageParams", typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256))]
        public IActionResult GetCodeStorage(string key)
        {
            return this.Ok(_contractsStorage.GetCodeStorage(key));
        }
        
        /// <summary>
        /// >> OwnerInfoOf
        ///  A mapping between an original code hash and its owner information.
        /// </summary>
        [HttpGet("OwnerInfoOf")]
        [ProducesResponseType(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_contracts.wasm.OwnerInfo), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ContractsStorage), "OwnerInfoOfParams", typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256))]
        public IActionResult GetOwnerInfoOf(string key)
        {
            return this.Ok(_contractsStorage.GetOwnerInfoOf(key));
        }
        
        /// <summary>
        /// >> Nonce
        ///  This is a **monotonic** counter incremented on contract instantiation.
        /// 
        ///  This is used in order to generate unique trie ids for contracts.
        ///  The trie id of a new contract is calculated from hash(account_id, nonce).
        ///  The nonce is required because otherwise the following sequence would lead to
        ///  a possible collision of storage:
        /// 
        ///  1. Create a new contract.
        ///  2. Terminate the contract.
        ///  3. Immediately recreate the contract with the same account_id.
        /// 
        ///  This is bad because the contents of a trie are deleted lazily and there might be
        ///  storage of the old instantiation still in it when the new contract is created. Please
        ///  note that we can't replace the counter by the block number because the sequence above
        ///  can happen in the same block. We also can't keep the account counter in memory only
        ///  because storage is the only way to communicate across different extrinsics in the
        ///  same block.
        /// 
        ///  # Note
        /// 
        ///  Do not use it to determine the number of contracts. It won't be decremented if
        ///  a contract is destroyed.
        /// </summary>
        [HttpGet("Nonce")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U64), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ContractsStorage), "NonceParams")]
        public IActionResult GetNonce()
        {
            return this.Ok(_contractsStorage.GetNonce());
        }
        
        /// <summary>
        /// >> ContractInfoOf
        ///  The code associated with a given account.
        /// 
        ///  TWOX-NOTE: SAFE since `AccountId` is a secure hash.
        /// </summary>
        [HttpGet("ContractInfoOf")]
        [ProducesResponseType(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_contracts.storage.ContractInfo), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ContractsStorage), "ContractInfoOfParams", typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetContractInfoOf(string key)
        {
            return this.Ok(_contractsStorage.GetContractInfoOf(key));
        }
        
        /// <summary>
        /// >> DeletionQueue
        ///  Evicted contracts that await child trie deletion.
        /// 
        ///  Child trie deletion is a heavy operation depending on the amount of storage items
        ///  stored in said trie. Therefore this operation is performed lazily in `on_initialize`.
        /// </summary>
        [HttpGet("DeletionQueue")]
        [ProducesResponseType(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT22), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ContractsStorage), "DeletionQueueParams")]
        public IActionResult GetDeletionQueue()
        {
            return this.Ok(_contractsStorage.GetDeletionQueue());
        }
    }
}
