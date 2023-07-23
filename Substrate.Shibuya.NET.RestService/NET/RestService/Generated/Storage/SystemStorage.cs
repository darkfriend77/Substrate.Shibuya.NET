//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using Substrate.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Shibuya.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// ISystemStorage interface definition.
    /// </summary>
    public interface ISystemStorage : IStorage
    {
        
        /// <summary>
        /// >> Account
        ///  The full account information for a particular account ID.
        /// </summary>
        Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.AccountInfo GetAccount(string key);
        
        /// <summary>
        /// >> ExtrinsicCount
        ///  Total extrinsics count for the current block.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetExtrinsicCount();
        
        /// <summary>
        /// >> BlockWeight
        ///  The current weight for the block.
        /// </summary>
        Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_support.dispatch.PerDispatchClassT1 GetBlockWeight();
        
        /// <summary>
        /// >> AllExtrinsicsLen
        ///  Total length (in bytes) for all extrinsics put together, for the current block.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetAllExtrinsicsLen();
        
        /// <summary>
        /// >> BlockHash
        ///  Map of block numbers to block hashes.
        /// </summary>
        Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 GetBlockHash(string key);
        
        /// <summary>
        /// >> ExtrinsicData
        ///  Extrinsics data for the current block (maps an extrinsic's index to its data).
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> GetExtrinsicData(string key);
        
        /// <summary>
        /// >> Number
        ///  The current block number being processed. Set by `execute_block`.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetNumber();
        
        /// <summary>
        /// >> ParentHash
        ///  Hash of the previous block.
        /// </summary>
        Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 GetParentHash();
        
        /// <summary>
        /// >> Digest
        ///  Digest of the current block, also part of the block header.
        /// </summary>
        Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_runtime.generic.digest.Digest GetDigest();
        
        /// <summary>
        /// >> Events
        ///  Events deposited for the current block.
        /// 
        ///  NOTE: The item is unbound and should therefore never be read on chain.
        ///  It could otherwise inflate the PoV size of a block.
        /// 
        ///  Events have a large in-memory size. Box the events to not go out-of-memory
        ///  just in case someone still reads them from within the runtime.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.EventRecord> GetEvents();
        
        /// <summary>
        /// >> EventCount
        ///  The number of events in the `Events<T>` list.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetEventCount();
        
        /// <summary>
        /// >> EventTopics
        ///  Mapping between a topic (represented by T::Hash) and a vector of indexes
        ///  of events in the `<Events<T>>` list.
        /// 
        ///  All topic vectors have deterministic storage locations depending on the topic. This
        ///  allows light-clients to leverage the changes trie storage tracking mechanism and
        ///  in case of changes fetch the list of events of interest.
        /// 
        ///  The value has the type `(T::BlockNumber, EventIndex)` because if we used only just
        ///  the `EventIndex` then in case if the topic has the same contents on the next block
        ///  no notification will be triggered thus the event might be lost.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>> GetEventTopics(string key);
        
        /// <summary>
        /// >> LastRuntimeUpgrade
        ///  Stores the `spec_version` and `spec_name` of when the last runtime upgrade happened.
        /// </summary>
        Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.LastRuntimeUpgradeInfo GetLastRuntimeUpgrade();
        
        /// <summary>
        /// >> UpgradedToU32RefCount
        ///  True if we have upgraded so that `type RefCount` is `u32`. False (default) if not.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.Bool GetUpgradedToU32RefCount();
        
        /// <summary>
        /// >> UpgradedToTripleRefCount
        ///  True if we have upgraded so that AccountInfo contains three types of `RefCount`. False
        ///  (default) if not.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.Bool GetUpgradedToTripleRefCount();
        
        /// <summary>
        /// >> ExecutionPhase
        ///  The execution phase of the block.
        /// </summary>
        Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.EnumPhase GetExecutionPhase();
    }
    
    /// <summary>
    /// SystemStorage class definition.
    /// </summary>
    public sealed class SystemStorage : ISystemStorage
    {
        
        /// <summary>
        /// _accountTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.AccountInfo> _accountTypedStorage;
        
        /// <summary>
        /// _extrinsicCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _extrinsicCountTypedStorage;
        
        /// <summary>
        /// _blockWeightTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_support.dispatch.PerDispatchClassT1> _blockWeightTypedStorage;
        
        /// <summary>
        /// _allExtrinsicsLenTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _allExtrinsicsLenTypedStorage;
        
        /// <summary>
        /// _blockHashTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256> _blockHashTypedStorage;
        
        /// <summary>
        /// _extrinsicDataTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> _extrinsicDataTypedStorage;
        
        /// <summary>
        /// _numberTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _numberTypedStorage;
        
        /// <summary>
        /// _parentHashTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256> _parentHashTypedStorage;
        
        /// <summary>
        /// _digestTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_runtime.generic.digest.Digest> _digestTypedStorage;
        
        /// <summary>
        /// _eventsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.EventRecord>> _eventsTypedStorage;
        
        /// <summary>
        /// _eventCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _eventCountTypedStorage;
        
        /// <summary>
        /// _eventTopicsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>> _eventTopicsTypedStorage;
        
        /// <summary>
        /// _lastRuntimeUpgradeTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.LastRuntimeUpgradeInfo> _lastRuntimeUpgradeTypedStorage;
        
        /// <summary>
        /// _upgradedToU32RefCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool> _upgradedToU32RefCountTypedStorage;
        
        /// <summary>
        /// _upgradedToTripleRefCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool> _upgradedToTripleRefCountTypedStorage;
        
        /// <summary>
        /// _executionPhaseTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.EnumPhase> _executionPhaseTypedStorage;
        
        /// <summary>
        /// SystemStorage constructor.
        /// </summary>
        public SystemStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.AccountTypedStorage = new TypedMapStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.AccountInfo>("System.Account", storageDataProvider, storageChangeDelegates);
            this.ExtrinsicCountTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("System.ExtrinsicCount", storageDataProvider, storageChangeDelegates);
            this.BlockWeightTypedStorage = new TypedStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_support.dispatch.PerDispatchClassT1>("System.BlockWeight", storageDataProvider, storageChangeDelegates);
            this.AllExtrinsicsLenTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("System.AllExtrinsicsLen", storageDataProvider, storageChangeDelegates);
            this.BlockHashTypedStorage = new TypedMapStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256>("System.BlockHash", storageDataProvider, storageChangeDelegates);
            this.ExtrinsicDataTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>("System.ExtrinsicData", storageDataProvider, storageChangeDelegates);
            this.NumberTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("System.Number", storageDataProvider, storageChangeDelegates);
            this.ParentHashTypedStorage = new TypedStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256>("System.ParentHash", storageDataProvider, storageChangeDelegates);
            this.DigestTypedStorage = new TypedStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_runtime.generic.digest.Digest>("System.Digest", storageDataProvider, storageChangeDelegates);
            this.EventsTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.EventRecord>>("System.Events", storageDataProvider, storageChangeDelegates);
            this.EventCountTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("System.EventCount", storageDataProvider, storageChangeDelegates);
            this.EventTopicsTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>>("System.EventTopics", storageDataProvider, storageChangeDelegates);
            this.LastRuntimeUpgradeTypedStorage = new TypedStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.LastRuntimeUpgradeInfo>("System.LastRuntimeUpgrade", storageDataProvider, storageChangeDelegates);
            this.UpgradedToU32RefCountTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool>("System.UpgradedToU32RefCount", storageDataProvider, storageChangeDelegates);
            this.UpgradedToTripleRefCountTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool>("System.UpgradedToTripleRefCount", storageDataProvider, storageChangeDelegates);
            this.ExecutionPhaseTypedStorage = new TypedStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.EnumPhase>("System.ExecutionPhase", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _accountTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.AccountInfo> AccountTypedStorage
        {
            get
            {
                return _accountTypedStorage;
            }
            set
            {
                _accountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _extrinsicCountTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> ExtrinsicCountTypedStorage
        {
            get
            {
                return _extrinsicCountTypedStorage;
            }
            set
            {
                _extrinsicCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _blockWeightTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_support.dispatch.PerDispatchClassT1> BlockWeightTypedStorage
        {
            get
            {
                return _blockWeightTypedStorage;
            }
            set
            {
                _blockWeightTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _allExtrinsicsLenTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> AllExtrinsicsLenTypedStorage
        {
            get
            {
                return _allExtrinsicsLenTypedStorage;
            }
            set
            {
                _allExtrinsicsLenTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _blockHashTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256> BlockHashTypedStorage
        {
            get
            {
                return _blockHashTypedStorage;
            }
            set
            {
                _blockHashTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _extrinsicDataTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> ExtrinsicDataTypedStorage
        {
            get
            {
                return _extrinsicDataTypedStorage;
            }
            set
            {
                _extrinsicDataTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _numberTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> NumberTypedStorage
        {
            get
            {
                return _numberTypedStorage;
            }
            set
            {
                _numberTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _parentHashTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256> ParentHashTypedStorage
        {
            get
            {
                return _parentHashTypedStorage;
            }
            set
            {
                _parentHashTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _digestTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_runtime.generic.digest.Digest> DigestTypedStorage
        {
            get
            {
                return _digestTypedStorage;
            }
            set
            {
                _digestTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _eventsTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.EventRecord>> EventsTypedStorage
        {
            get
            {
                return _eventsTypedStorage;
            }
            set
            {
                _eventsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _eventCountTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> EventCountTypedStorage
        {
            get
            {
                return _eventCountTypedStorage;
            }
            set
            {
                _eventCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _eventTopicsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>> EventTopicsTypedStorage
        {
            get
            {
                return _eventTopicsTypedStorage;
            }
            set
            {
                _eventTopicsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _lastRuntimeUpgradeTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.LastRuntimeUpgradeInfo> LastRuntimeUpgradeTypedStorage
        {
            get
            {
                return _lastRuntimeUpgradeTypedStorage;
            }
            set
            {
                _lastRuntimeUpgradeTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _upgradedToU32RefCountTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool> UpgradedToU32RefCountTypedStorage
        {
            get
            {
                return _upgradedToU32RefCountTypedStorage;
            }
            set
            {
                _upgradedToU32RefCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _upgradedToTripleRefCountTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool> UpgradedToTripleRefCountTypedStorage
        {
            get
            {
                return _upgradedToTripleRefCountTypedStorage;
            }
            set
            {
                _upgradedToTripleRefCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _executionPhaseTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.EnumPhase> ExecutionPhaseTypedStorage
        {
            get
            {
                return _executionPhaseTypedStorage;
            }
            set
            {
                _executionPhaseTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await AccountTypedStorage.InitializeAsync("System", "Account");
            await ExtrinsicCountTypedStorage.InitializeAsync("System", "ExtrinsicCount");
            await BlockWeightTypedStorage.InitializeAsync("System", "BlockWeight");
            await AllExtrinsicsLenTypedStorage.InitializeAsync("System", "AllExtrinsicsLen");
            await BlockHashTypedStorage.InitializeAsync("System", "BlockHash");
            await ExtrinsicDataTypedStorage.InitializeAsync("System", "ExtrinsicData");
            await NumberTypedStorage.InitializeAsync("System", "Number");
            await ParentHashTypedStorage.InitializeAsync("System", "ParentHash");
            await DigestTypedStorage.InitializeAsync("System", "Digest");
            await EventsTypedStorage.InitializeAsync("System", "Events");
            await EventCountTypedStorage.InitializeAsync("System", "EventCount");
            await EventTopicsTypedStorage.InitializeAsync("System", "EventTopics");
            await LastRuntimeUpgradeTypedStorage.InitializeAsync("System", "LastRuntimeUpgrade");
            await UpgradedToU32RefCountTypedStorage.InitializeAsync("System", "UpgradedToU32RefCount");
            await UpgradedToTripleRefCountTypedStorage.InitializeAsync("System", "UpgradedToTripleRefCount");
            await ExecutionPhaseTypedStorage.InitializeAsync("System", "ExecutionPhase");
        }
        
        /// <summary>
        /// Implements any storage change for System.Account
        /// </summary>
        [StorageChange("System", "Account")]
        public void OnUpdateAccount(string key, string data)
        {
            AccountTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Account
        ///  The full account information for a particular account ID.
        /// </summary>
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.AccountInfo GetAccount(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (AccountTypedStorage.Dictionary.TryGetValue(key, out Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.AccountInfo result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for System.ExtrinsicCount
        /// </summary>
        [StorageChange("System", "ExtrinsicCount")]
        public void OnUpdateExtrinsicCount(string data)
        {
            ExtrinsicCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ExtrinsicCount
        ///  Total extrinsics count for the current block.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetExtrinsicCount()
        {
            return ExtrinsicCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for System.BlockWeight
        /// </summary>
        [StorageChange("System", "BlockWeight")]
        public void OnUpdateBlockWeight(string data)
        {
            BlockWeightTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> BlockWeight
        ///  The current weight for the block.
        /// </summary>
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_support.dispatch.PerDispatchClassT1 GetBlockWeight()
        {
            return BlockWeightTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for System.AllExtrinsicsLen
        /// </summary>
        [StorageChange("System", "AllExtrinsicsLen")]
        public void OnUpdateAllExtrinsicsLen(string data)
        {
            AllExtrinsicsLenTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> AllExtrinsicsLen
        ///  Total length (in bytes) for all extrinsics put together, for the current block.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetAllExtrinsicsLen()
        {
            return AllExtrinsicsLenTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for System.BlockHash
        /// </summary>
        [StorageChange("System", "BlockHash")]
        public void OnUpdateBlockHash(string key, string data)
        {
            BlockHashTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> BlockHash
        ///  Map of block numbers to block hashes.
        /// </summary>
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 GetBlockHash(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (BlockHashTypedStorage.Dictionary.TryGetValue(key, out Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for System.ExtrinsicData
        /// </summary>
        [StorageChange("System", "ExtrinsicData")]
        public void OnUpdateExtrinsicData(string key, string data)
        {
            ExtrinsicDataTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ExtrinsicData
        ///  Extrinsics data for the current block (maps an extrinsic's index to its data).
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> GetExtrinsicData(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ExtrinsicDataTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for System.Number
        /// </summary>
        [StorageChange("System", "Number")]
        public void OnUpdateNumber(string data)
        {
            NumberTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Number
        ///  The current block number being processed. Set by `execute_block`.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetNumber()
        {
            return NumberTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for System.ParentHash
        /// </summary>
        [StorageChange("System", "ParentHash")]
        public void OnUpdateParentHash(string data)
        {
            ParentHashTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ParentHash
        ///  Hash of the previous block.
        /// </summary>
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256 GetParentHash()
        {
            return ParentHashTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for System.Digest
        /// </summary>
        [StorageChange("System", "Digest")]
        public void OnUpdateDigest(string data)
        {
            DigestTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Digest
        ///  Digest of the current block, also part of the block header.
        /// </summary>
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_runtime.generic.digest.Digest GetDigest()
        {
            return DigestTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for System.Events
        /// </summary>
        [StorageChange("System", "Events")]
        public void OnUpdateEvents(string data)
        {
            EventsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Events
        ///  Events deposited for the current block.
        /// 
        ///  NOTE: The item is unbound and should therefore never be read on chain.
        ///  It could otherwise inflate the PoV size of a block.
        /// 
        ///  Events have a large in-memory size. Box the events to not go out-of-memory
        ///  just in case someone still reads them from within the runtime.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.EventRecord> GetEvents()
        {
            return EventsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for System.EventCount
        /// </summary>
        [StorageChange("System", "EventCount")]
        public void OnUpdateEventCount(string data)
        {
            EventCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> EventCount
        ///  The number of events in the `Events<T>` list.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetEventCount()
        {
            return EventCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for System.EventTopics
        /// </summary>
        [StorageChange("System", "EventTopics")]
        public void OnUpdateEventTopics(string key, string data)
        {
            EventTopicsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> EventTopics
        ///  Mapping between a topic (represented by T::Hash) and a vector of indexes
        ///  of events in the `<Events<T>>` list.
        /// 
        ///  All topic vectors have deterministic storage locations depending on the topic. This
        ///  allows light-clients to leverage the changes trie storage tracking mechanism and
        ///  in case of changes fetch the list of events of interest.
        /// 
        ///  The value has the type `(T::BlockNumber, EventIndex)` because if we used only just
        ///  the `EventIndex` then in case if the topic has the same contents on the next block
        ///  no notification will be triggered thus the event might be lost.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>> GetEventTopics(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (EventTopicsTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for System.LastRuntimeUpgrade
        /// </summary>
        [StorageChange("System", "LastRuntimeUpgrade")]
        public void OnUpdateLastRuntimeUpgrade(string data)
        {
            LastRuntimeUpgradeTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> LastRuntimeUpgrade
        ///  Stores the `spec_version` and `spec_name` of when the last runtime upgrade happened.
        /// </summary>
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.LastRuntimeUpgradeInfo GetLastRuntimeUpgrade()
        {
            return LastRuntimeUpgradeTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for System.UpgradedToU32RefCount
        /// </summary>
        [StorageChange("System", "UpgradedToU32RefCount")]
        public void OnUpdateUpgradedToU32RefCount(string data)
        {
            UpgradedToU32RefCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> UpgradedToU32RefCount
        ///  True if we have upgraded so that `type RefCount` is `u32`. False (default) if not.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool GetUpgradedToU32RefCount()
        {
            return UpgradedToU32RefCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for System.UpgradedToTripleRefCount
        /// </summary>
        [StorageChange("System", "UpgradedToTripleRefCount")]
        public void OnUpdateUpgradedToTripleRefCount(string data)
        {
            UpgradedToTripleRefCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> UpgradedToTripleRefCount
        ///  True if we have upgraded so that AccountInfo contains three types of `RefCount`. False
        ///  (default) if not.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool GetUpgradedToTripleRefCount()
        {
            return UpgradedToTripleRefCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for System.ExecutionPhase
        /// </summary>
        [StorageChange("System", "ExecutionPhase")]
        public void OnUpdateExecutionPhase(string data)
        {
            ExecutionPhaseTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ExecutionPhase
        ///  The execution phase of the block.
        /// </summary>
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.frame_system.EnumPhase GetExecutionPhase()
        {
            return ExecutionPhaseTypedStorage.Get();
        }
    }
}
