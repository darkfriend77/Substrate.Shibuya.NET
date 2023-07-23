//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Substrate.Shibuya.NET.NetApiExt.Generated.Storage
{
    
    
    public sealed class ContractsStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public ContractsStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Contracts", "PristineCode"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256), typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT21)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Contracts", "CodeStorage"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256), typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_contracts.wasm.PrefabWasmModule)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Contracts", "OwnerInfoOf"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256), typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_contracts.wasm.OwnerInfo)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Contracts", "Nonce"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.NetApi.Model.Types.Primitive.U64)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Contracts", "ContractInfoOf"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_contracts.storage.ContractInfo)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Contracts", "DeletionQueue"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT22)));
        }
        
        /// <summary>
        /// >> PristineCodeParams
        ///  A mapping from an original code hash to the original code, untouched by instrumentation.
        /// </summary>
        public static string PristineCodeParams(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
        {
            return RequestGenerator.GetStorage("Contracts", "PristineCode", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> PristineCodeDefault
        /// Default value as hex string
        /// </summary>
        public static string PristineCodeDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> PristineCode
        ///  A mapping from an original code hash to the original code, untouched by instrumentation.
        /// </summary>
        public async Task<Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT21> PristineCode(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key, CancellationToken token)
        {
            string parameters = ContractsStorage.PristineCodeParams(key);
            var result = await _client.GetStorageAsync<Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT21>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> CodeStorageParams
        ///  A mapping between an original code hash and instrumented wasm code, ready for execution.
        /// </summary>
        public static string CodeStorageParams(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
        {
            return RequestGenerator.GetStorage("Contracts", "CodeStorage", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> CodeStorageDefault
        /// Default value as hex string
        /// </summary>
        public static string CodeStorageDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> CodeStorage
        ///  A mapping between an original code hash and instrumented wasm code, ready for execution.
        /// </summary>
        public async Task<Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_contracts.wasm.PrefabWasmModule> CodeStorage(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key, CancellationToken token)
        {
            string parameters = ContractsStorage.CodeStorageParams(key);
            var result = await _client.GetStorageAsync<Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_contracts.wasm.PrefabWasmModule>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> OwnerInfoOfParams
        ///  A mapping between an original code hash and its owner information.
        /// </summary>
        public static string OwnerInfoOfParams(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
        {
            return RequestGenerator.GetStorage("Contracts", "OwnerInfoOf", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> OwnerInfoOfDefault
        /// Default value as hex string
        /// </summary>
        public static string OwnerInfoOfDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> OwnerInfoOf
        ///  A mapping between an original code hash and its owner information.
        /// </summary>
        public async Task<Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_contracts.wasm.OwnerInfo> OwnerInfoOf(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 key, CancellationToken token)
        {
            string parameters = ContractsStorage.OwnerInfoOfParams(key);
            var result = await _client.GetStorageAsync<Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_contracts.wasm.OwnerInfo>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> NonceParams
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
        public static string NonceParams()
        {
            return RequestGenerator.GetStorage("Contracts", "Nonce", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> NonceDefault
        /// Default value as hex string
        /// </summary>
        public static string NonceDefault()
        {
            return "0x0000000000000000";
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
        public async Task<Substrate.NetApi.Model.Types.Primitive.U64> Nonce(CancellationToken token)
        {
            string parameters = ContractsStorage.NonceParams();
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U64>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> ContractInfoOfParams
        ///  The code associated with a given account.
        /// 
        ///  TWOX-NOTE: SAFE since `AccountId` is a secure hash.
        /// </summary>
        public static string ContractInfoOfParams(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Contracts", "ContractInfoOf", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ContractInfoOfDefault
        /// Default value as hex string
        /// </summary>
        public static string ContractInfoOfDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> ContractInfoOf
        ///  The code associated with a given account.
        /// 
        ///  TWOX-NOTE: SAFE since `AccountId` is a secure hash.
        /// </summary>
        public async Task<Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_contracts.storage.ContractInfo> ContractInfoOf(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = ContractsStorage.ContractInfoOfParams(key);
            var result = await _client.GetStorageAsync<Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_contracts.storage.ContractInfo>(parameters, token);
            return result;
        }
        
        /// <summary>
        /// >> DeletionQueueParams
        ///  Evicted contracts that await child trie deletion.
        /// 
        ///  Child trie deletion is a heavy operation depending on the amount of storage items
        ///  stored in said trie. Therefore this operation is performed lazily in `on_initialize`.
        /// </summary>
        public static string DeletionQueueParams()
        {
            return RequestGenerator.GetStorage("Contracts", "DeletionQueue", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> DeletionQueueDefault
        /// Default value as hex string
        /// </summary>
        public static string DeletionQueueDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> DeletionQueue
        ///  Evicted contracts that await child trie deletion.
        /// 
        ///  Child trie deletion is a heavy operation depending on the amount of storage items
        ///  stored in said trie. Therefore this operation is performed lazily in `on_initialize`.
        /// </summary>
        public async Task<Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT22> DeletionQueue(CancellationToken token)
        {
            string parameters = ContractsStorage.DeletionQueueParams();
            var result = await _client.GetStorageAsync<Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT22>(parameters, token);
            return result;
        }
    }
    
    public sealed class ContractsCalls
    {
        
        /// <summary>
        /// >> call_old_weight
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CallOldWeight(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> value, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_weights.OldWeight> gas_limit, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>> storage_deposit_limit, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> data)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(storage_deposit_limit.Encode());
            byteArray.AddRange(data.Encode());
            return new Method(70, "Contracts", 0, "call_old_weight", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> instantiate_with_code_old_weight
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method InstantiateWithCodeOldWeight(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> value, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_weights.OldWeight> gas_limit, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>> storage_deposit_limit, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> code, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> data, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> salt)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(storage_deposit_limit.Encode());
            byteArray.AddRange(code.Encode());
            byteArray.AddRange(data.Encode());
            byteArray.AddRange(salt.Encode());
            return new Method(70, "Contracts", 1, "instantiate_with_code_old_weight", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> instantiate_old_weight
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method InstantiateOldWeight(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> value, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_weights.OldWeight> gas_limit, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>> storage_deposit_limit, Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 code_hash, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> data, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> salt)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(storage_deposit_limit.Encode());
            byteArray.AddRange(code_hash.Encode());
            byteArray.AddRange(data.Encode());
            byteArray.AddRange(salt.Encode());
            return new Method(70, "Contracts", 2, "instantiate_old_weight", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> upload_code
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method UploadCode(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> code, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>> storage_deposit_limit, Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_contracts.wasm.EnumDeterminism determinism)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(code.Encode());
            byteArray.AddRange(storage_deposit_limit.Encode());
            byteArray.AddRange(determinism.Encode());
            return new Method(70, "Contracts", 3, "upload_code", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_code
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveCode(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 code_hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(code_hash.Encode());
            return new Method(70, "Contracts", 4, "remove_code", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_code
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetCode(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 code_hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(code_hash.Encode());
            return new Method(70, "Contracts", 5, "set_code", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> call
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Call(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> value, Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight gas_limit, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>> storage_deposit_limit, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> data)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(storage_deposit_limit.Encode());
            byteArray.AddRange(data.Encode());
            return new Method(70, "Contracts", 6, "call", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> instantiate_with_code
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method InstantiateWithCode(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> value, Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight gas_limit, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>> storage_deposit_limit, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> code, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> data, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> salt)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(storage_deposit_limit.Encode());
            byteArray.AddRange(code.Encode());
            byteArray.AddRange(data.Encode());
            byteArray.AddRange(salt.Encode());
            return new Method(70, "Contracts", 7, "instantiate_with_code", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> instantiate
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Instantiate(Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> value, Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight gas_limit, Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>> storage_deposit_limit, Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 code_hash, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> data, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> salt)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(storage_deposit_limit.Encode());
            byteArray.AddRange(code_hash.Encode());
            byteArray.AddRange(data.Encode());
            byteArray.AddRange(salt.Encode());
            return new Method(70, "Contracts", 8, "instantiate", byteArray.ToArray());
        }
    }
    
    public sealed class ContractsConstants
    {
        
        /// <summary>
        /// >> Schedule
        ///  Cost schedule and limits.
        /// </summary>
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_contracts.schedule.Schedule Schedule()
        {
            var result = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_contracts.schedule.Schedule();
            result.Create(@"0x0400000000010000000400008000000010000000001000000001000020000000004000000400000000000000010800005B1A000051170000E50C0000281B00000E090000570D00008E1500002C000000F94C0000C75A00008008000094030000F7090000F90A0000C8090000F01A0000D71B0000F21700008167E400C0080000B4080000CC080000CD0A0000230800001B08000027080000690B0000F10D0000450B0000760B00006C0B0000D70B0000900B0000E30B0000940B00008B0B00000D0B0000AB0A0000940A000066230000F4200000712400009B200000330B00000C0B00000A0B00004A0B0000470B0000450B0000460B0000420B00006E640D0078D2E5B50671390E5DDA06C139EEAF100078FE9908003C8A570D007896240D00780AA74800782A360D0078060E0D00787E040D007842E10D007806374300F0A2360600009EB70B0078D50100008503850300BAA573BA25B316315600F01EFCAE00C8A64B551E3529A10D008A0F0B008C6D0C0052143A1F9104A9B9006DB3084A62184229B8C270301F8104D9B308C62710078104792D084A1F1907A1042540088E5D3A1FA10499C60896B10022352A8684A7916561AA44AB76E580029453222936DD01001A7AE3E255E4FA478901880D18001D1800BA892000A0E53D007AF32B00A0E53100BA0E1900A0B113004AA51D00A8AD130082730109F10502743F024903E6DA08003C5A030E0019033223070048");
            return result;
        }
        
        /// <summary>
        /// >> DeletionQueueDepth
        ///  The maximum number of contracts that can be pending for deletion.
        /// 
        ///  When a contract is deleted by calling `seal_terminate` it becomes inaccessible
        ///  immediately, but the deletion of the storage items it has accumulated is performed
        ///  later. The contract is put into the deletion queue. This defines how many
        ///  contracts can be queued up at the same time. If that limit is reached `seal_terminate`
        ///  will fail. The action must be retried in a later block in that case.
        /// 
        ///  The reasons for limiting the queue depth are:
        /// 
        ///  1. The queue is in storage in order to be persistent between blocks. We want to limit
        ///  	the amount of storage that can be consumed.
        ///  2. The queue is stored in a vector and needs to be decoded as a whole when reading
        /// 		it at the end of each block. Longer queues take more weight to decode and hence
        /// 		limit the amount of items that can be deleted per block.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 DeletionQueueDepth()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x80000000");
            return result;
        }
        
        /// <summary>
        /// >> DeletionWeightLimit
        ///  The maximum amount of weight that can be consumed per block for lazy trie removal.
        /// 
        ///  The amount of weight that is dedicated per block to work on the deletion queue. Larger
        ///  values allow more trie keys to be deleted in each block but reduce the amount of
        ///  weight that is left for transactions. See [`Self::DeletionQueueDepth`] for more
        ///  information about the deletion queue.
        /// </summary>
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight DeletionWeightLimit()
        {
            var result = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            result.Create("0x0700743BA40B02002000");
            return result;
        }
        
        /// <summary>
        /// >> DepositPerByte
        ///  The amount of balance a caller has to pay for each byte of storage.
        /// 
        ///  # Note
        /// 
        ///  Changing this value for an existing chain might need a storage migration.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 DepositPerByte()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x00CA9A3B000000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> DepositPerItem
        ///  The amount of balance a caller has to pay for each storage item.
        /// 
        ///  # Note
        /// 
        ///  Changing this value for an existing chain might need a storage migration.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 DepositPerItem()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x00CA9A3B000000000000000000000000");
            return result;
        }
        
        /// <summary>
        /// >> MaxCodeLen
        ///  The maximum length of a contract code in bytes. This limit applies to the instrumented
        ///  version of the code. Therefore `instantiate_with_code` can fail even when supplying
        ///  a wasm binary below this maximum size.
        /// 
        ///  The value should be chosen carefully taking into the account the overall memory limit
        ///  your runtime has, as well as the [maximum allowed callstack
        ///  depth](#associatedtype.CallStack). Look into the `integrity_test()` for some insights.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxCodeLen()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x00EC0100");
            return result;
        }
        
        /// <summary>
        /// >> MaxStorageKeyLen
        ///  The maximum allowable length in bytes for storage keys.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxStorageKeyLen()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x80000000");
            return result;
        }
        
        /// <summary>
        /// >> UnsafeUnstableInterface
        ///  Make contract callable functions marked as `#[unstable]` available.
        /// 
        ///  Contracts that use `#[unstable]` functions won't be able to be uploaded unless
        ///  this is set to `true`. This is only meant for testnets and dev nodes in order to
        ///  experiment with new features.
        /// 
        ///  # Warning
        /// 
        ///  Do **not** set to `true` on productions chains.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool UnsafeUnstableInterface()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.Bool();
            result.Create("0x01");
            return result;
        }
        
        /// <summary>
        /// >> MaxDebugBufferLen
        ///  The maximum length of the debug buffer in bytes.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxDebugBufferLen()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U32();
            result.Create("0x00002000");
            return result;
        }
    }
    
    public enum ContractsErrors
    {
        
        /// <summary>
        /// >> InvalidScheduleVersion
        /// A new schedule must have a greater version than the current one.
        /// </summary>
        InvalidScheduleVersion,
        
        /// <summary>
        /// >> InvalidCallFlags
        /// Invalid combination of flags supplied to `seal_call` or `seal_delegate_call`.
        /// </summary>
        InvalidCallFlags,
        
        /// <summary>
        /// >> OutOfGas
        /// The executed contract exhausted its gas limit.
        /// </summary>
        OutOfGas,
        
        /// <summary>
        /// >> OutputBufferTooSmall
        /// The output buffer supplied to a contract API call was too small.
        /// </summary>
        OutputBufferTooSmall,
        
        /// <summary>
        /// >> TransferFailed
        /// Performing the requested transfer failed. Probably because there isn't enough
        /// free balance in the sender's account.
        /// </summary>
        TransferFailed,
        
        /// <summary>
        /// >> MaxCallDepthReached
        /// Performing a call was denied because the calling depth reached the limit
        /// of what is specified in the schedule.
        /// </summary>
        MaxCallDepthReached,
        
        /// <summary>
        /// >> ContractNotFound
        /// No contract was found at the specified address.
        /// </summary>
        ContractNotFound,
        
        /// <summary>
        /// >> CodeTooLarge
        /// The code supplied to `instantiate_with_code` exceeds the limit specified in the
        /// current schedule.
        /// </summary>
        CodeTooLarge,
        
        /// <summary>
        /// >> CodeNotFound
        /// No code could be found at the supplied code hash.
        /// </summary>
        CodeNotFound,
        
        /// <summary>
        /// >> OutOfBounds
        /// A buffer outside of sandbox memory was passed to a contract API function.
        /// </summary>
        OutOfBounds,
        
        /// <summary>
        /// >> DecodingFailed
        /// Input passed to a contract API function failed to decode as expected type.
        /// </summary>
        DecodingFailed,
        
        /// <summary>
        /// >> ContractTrapped
        /// Contract trapped during execution.
        /// </summary>
        ContractTrapped,
        
        /// <summary>
        /// >> ValueTooLarge
        /// The size defined in `T::MaxValueSize` was exceeded.
        /// </summary>
        ValueTooLarge,
        
        /// <summary>
        /// >> TerminatedWhileReentrant
        /// Termination of a contract is not allowed while the contract is already
        /// on the call stack. Can be triggered by `seal_terminate`.
        /// </summary>
        TerminatedWhileReentrant,
        
        /// <summary>
        /// >> InputForwarded
        /// `seal_call` forwarded this contracts input. It therefore is no longer available.
        /// </summary>
        InputForwarded,
        
        /// <summary>
        /// >> RandomSubjectTooLong
        /// The subject passed to `seal_random` exceeds the limit.
        /// </summary>
        RandomSubjectTooLong,
        
        /// <summary>
        /// >> TooManyTopics
        /// The amount of topics passed to `seal_deposit_events` exceeds the limit.
        /// </summary>
        TooManyTopics,
        
        /// <summary>
        /// >> NoChainExtension
        /// The chain does not provide a chain extension. Calling the chain extension results
        /// in this error. Note that this usually  shouldn't happen as deploying such contracts
        /// is rejected.
        /// </summary>
        NoChainExtension,
        
        /// <summary>
        /// >> DeletionQueueFull
        /// Removal of a contract failed because the deletion queue is full.
        /// 
        /// This can happen when calling `seal_terminate`.
        /// The queue is filled by deleting contracts and emptied by a fixed amount each block.
        /// Trying again during another block is the only way to resolve this issue.
        /// </summary>
        DeletionQueueFull,
        
        /// <summary>
        /// >> DuplicateContract
        /// A contract with the same AccountId already exists.
        /// </summary>
        DuplicateContract,
        
        /// <summary>
        /// >> TerminatedInConstructor
        /// A contract self destructed in its constructor.
        /// 
        /// This can be triggered by a call to `seal_terminate`.
        /// </summary>
        TerminatedInConstructor,
        
        /// <summary>
        /// >> ReentranceDenied
        /// A call tried to invoke a contract that is flagged as non-reentrant.
        /// </summary>
        ReentranceDenied,
        
        /// <summary>
        /// >> StorageDepositNotEnoughFunds
        /// Origin doesn't have enough balance to pay the required storage deposits.
        /// </summary>
        StorageDepositNotEnoughFunds,
        
        /// <summary>
        /// >> StorageDepositLimitExhausted
        /// More storage was created than allowed by the storage deposit limit.
        /// </summary>
        StorageDepositLimitExhausted,
        
        /// <summary>
        /// >> CodeInUse
        /// Code removal was denied because the code is still in use by at least one contract.
        /// </summary>
        CodeInUse,
        
        /// <summary>
        /// >> ContractReverted
        /// The contract ran to completion but decided to revert its storage changes.
        /// Please note that this error is only returned from extrinsics. When called directly
        /// or via RPC an `Ok` will be returned. In this case the caller needs to inspect the flags
        /// to determine whether a reversion has taken place.
        /// </summary>
        ContractReverted,
        
        /// <summary>
        /// >> CodeRejected
        /// The contract's code was found to be invalid during validation or instrumentation.
        /// 
        /// The most likely cause of this is that an API was used which is not supported by the
        /// node. This hapens if an older node is used with a new version of ink!. Try updating
        /// your node to the newest available version.
        /// 
        /// A more detailed error can be found on the node console if debug messages are enabled
        /// by supplying `-lruntime::contracts=debug`.
        /// </summary>
        CodeRejected,
        
        /// <summary>
        /// >> Indeterministic
        /// An indetermistic code was used in a context where this is not permitted.
        /// </summary>
        Indeterministic,
    }
}