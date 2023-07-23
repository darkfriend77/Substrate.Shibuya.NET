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
    /// ISessionStorage interface definition.
    /// </summary>
    public interface ISessionStorage : IStorage
    {
        
        /// <summary>
        /// >> Validators
        ///  The current set of validators.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> GetValidators();
        
        /// <summary>
        /// >> CurrentIndex
        ///  Current index of the session.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetCurrentIndex();
        
        /// <summary>
        /// >> QueuedChanged
        ///  True if the underlying economic identities or weighting behind the validators
        ///  has changed in the queued validator set.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.Bool GetQueuedChanged();
        
        /// <summary>
        /// >> QueuedKeys
        ///  The queued keys for the next session. When the next session begins, these keys
        ///  will be used to determine the validator's session keys.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.shibuya_runtime.SessionKeys>> GetQueuedKeys();
        
        /// <summary>
        /// >> DisabledValidators
        ///  Indices of disabled validators.
        /// 
        ///  The vec is always kept sorted so that we can find whether a given validator is
        ///  disabled using binary search. It gets cleared when `on_session_ending` returns
        ///  a new set of identities.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32> GetDisabledValidators();
        
        /// <summary>
        /// >> NextKeys
        ///  The next session keys for a validator.
        /// </summary>
        Substrate.Shibuya.NET.NetApiExt.Generated.Model.shibuya_runtime.SessionKeys GetNextKeys(string key);
        
        /// <summary>
        /// >> KeyOwner
        ///  The owner of a key. The key is the `KeyTypeId` + the encoded key.
        /// </summary>
        Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetKeyOwner(string key);
    }
    
    /// <summary>
    /// SessionStorage class definition.
    /// </summary>
    public sealed class SessionStorage : ISessionStorage
    {
        
        /// <summary>
        /// _validatorsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>> _validatorsTypedStorage;
        
        /// <summary>
        /// _currentIndexTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _currentIndexTypedStorage;
        
        /// <summary>
        /// _queuedChangedTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool> _queuedChangedTypedStorage;
        
        /// <summary>
        /// _queuedKeysTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.shibuya_runtime.SessionKeys>>> _queuedKeysTypedStorage;
        
        /// <summary>
        /// _disabledValidatorsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32>> _disabledValidatorsTypedStorage;
        
        /// <summary>
        /// _nextKeysTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.shibuya_runtime.SessionKeys> _nextKeysTypedStorage;
        
        /// <summary>
        /// _keyOwnerTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> _keyOwnerTypedStorage;
        
        /// <summary>
        /// SessionStorage constructor.
        /// </summary>
        public SessionStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.ValidatorsTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>("Session.Validators", storageDataProvider, storageChangeDelegates);
            this.CurrentIndexTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("Session.CurrentIndex", storageDataProvider, storageChangeDelegates);
            this.QueuedChangedTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool>("Session.QueuedChanged", storageDataProvider, storageChangeDelegates);
            this.QueuedKeysTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.shibuya_runtime.SessionKeys>>>("Session.QueuedKeys", storageDataProvider, storageChangeDelegates);
            this.DisabledValidatorsTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32>>("Session.DisabledValidators", storageDataProvider, storageChangeDelegates);
            this.NextKeysTypedStorage = new TypedMapStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.shibuya_runtime.SessionKeys>("Session.NextKeys", storageDataProvider, storageChangeDelegates);
            this.KeyOwnerTypedStorage = new TypedMapStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>("Session.KeyOwner", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _validatorsTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>> ValidatorsTypedStorage
        {
            get
            {
                return _validatorsTypedStorage;
            }
            set
            {
                _validatorsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _currentIndexTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> CurrentIndexTypedStorage
        {
            get
            {
                return _currentIndexTypedStorage;
            }
            set
            {
                _currentIndexTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _queuedChangedTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.Bool> QueuedChangedTypedStorage
        {
            get
            {
                return _queuedChangedTypedStorage;
            }
            set
            {
                _queuedChangedTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _queuedKeysTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.shibuya_runtime.SessionKeys>>> QueuedKeysTypedStorage
        {
            get
            {
                return _queuedKeysTypedStorage;
            }
            set
            {
                _queuedKeysTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _disabledValidatorsTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32>> DisabledValidatorsTypedStorage
        {
            get
            {
                return _disabledValidatorsTypedStorage;
            }
            set
            {
                _disabledValidatorsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _nextKeysTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.shibuya_runtime.SessionKeys> NextKeysTypedStorage
        {
            get
            {
                return _nextKeysTypedStorage;
            }
            set
            {
                _nextKeysTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _keyOwnerTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> KeyOwnerTypedStorage
        {
            get
            {
                return _keyOwnerTypedStorage;
            }
            set
            {
                _keyOwnerTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await ValidatorsTypedStorage.InitializeAsync("Session", "Validators");
            await CurrentIndexTypedStorage.InitializeAsync("Session", "CurrentIndex");
            await QueuedChangedTypedStorage.InitializeAsync("Session", "QueuedChanged");
            await QueuedKeysTypedStorage.InitializeAsync("Session", "QueuedKeys");
            await DisabledValidatorsTypedStorage.InitializeAsync("Session", "DisabledValidators");
            await NextKeysTypedStorage.InitializeAsync("Session", "NextKeys");
            await KeyOwnerTypedStorage.InitializeAsync("Session", "KeyOwner");
        }
        
        /// <summary>
        /// Implements any storage change for Session.Validators
        /// </summary>
        [StorageChange("Session", "Validators")]
        public void OnUpdateValidators(string data)
        {
            ValidatorsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Validators
        ///  The current set of validators.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> GetValidators()
        {
            return ValidatorsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Session.CurrentIndex
        /// </summary>
        [StorageChange("Session", "CurrentIndex")]
        public void OnUpdateCurrentIndex(string data)
        {
            CurrentIndexTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> CurrentIndex
        ///  Current index of the session.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetCurrentIndex()
        {
            return CurrentIndexTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Session.QueuedChanged
        /// </summary>
        [StorageChange("Session", "QueuedChanged")]
        public void OnUpdateQueuedChanged(string data)
        {
            QueuedChangedTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> QueuedChanged
        ///  True if the underlying economic identities or weighting behind the validators
        ///  has changed in the queued validator set.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Bool GetQueuedChanged()
        {
            return QueuedChangedTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Session.QueuedKeys
        /// </summary>
        [StorageChange("Session", "QueuedKeys")]
        public void OnUpdateQueuedKeys(string data)
        {
            QueuedKeysTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> QueuedKeys
        ///  The queued keys for the next session. When the next session begins, these keys
        ///  will be used to determine the validator's session keys.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Shibuya.NET.NetApiExt.Generated.Model.shibuya_runtime.SessionKeys>> GetQueuedKeys()
        {
            return QueuedKeysTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Session.DisabledValidators
        /// </summary>
        [StorageChange("Session", "DisabledValidators")]
        public void OnUpdateDisabledValidators(string data)
        {
            DisabledValidatorsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> DisabledValidators
        ///  Indices of disabled validators.
        /// 
        ///  The vec is always kept sorted so that we can find whether a given validator is
        ///  disabled using binary search. It gets cleared when `on_session_ending` returns
        ///  a new set of identities.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U32> GetDisabledValidators()
        {
            return DisabledValidatorsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Session.NextKeys
        /// </summary>
        [StorageChange("Session", "NextKeys")]
        public void OnUpdateNextKeys(string key, string data)
        {
            NextKeysTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> NextKeys
        ///  The next session keys for a validator.
        /// </summary>
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.shibuya_runtime.SessionKeys GetNextKeys(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (NextKeysTypedStorage.Dictionary.TryGetValue(key, out Substrate.Shibuya.NET.NetApiExt.Generated.Model.shibuya_runtime.SessionKeys result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Session.KeyOwner
        /// </summary>
        [StorageChange("Session", "KeyOwner")]
        public void OnUpdateKeyOwner(string key, string data)
        {
            KeyOwnerTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> KeyOwner
        ///  The owner of a key. The key is the `KeyTypeId` + the encoded key.
        /// </summary>
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetKeyOwner(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (KeyOwnerTypedStorage.Dictionary.TryGetValue(key, out Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
