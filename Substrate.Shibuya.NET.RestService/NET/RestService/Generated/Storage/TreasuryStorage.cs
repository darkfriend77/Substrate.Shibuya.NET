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
    /// ITreasuryStorage interface definition.
    /// </summary>
    public interface ITreasuryStorage : IStorage
    {
        
        /// <summary>
        /// >> ProposalCount
        ///  Number of proposals that have been made.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetProposalCount();
        
        /// <summary>
        /// >> Proposals
        ///  Proposals that have been made.
        /// </summary>
        Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_treasury.Proposal GetProposals(string key);
        
        /// <summary>
        /// >> Deactivated
        ///  The amount which has been reported as inactive to Currency.
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U128 GetDeactivated();
        
        /// <summary>
        /// >> Approvals
        ///  Proposal indices that have been approved but not yet awarded.
        /// </summary>
        Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT26 GetApprovals();
    }
    
    /// <summary>
    /// TreasuryStorage class definition.
    /// </summary>
    public sealed class TreasuryStorage : ITreasuryStorage
    {
        
        /// <summary>
        /// _proposalCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _proposalCountTypedStorage;
        
        /// <summary>
        /// _proposalsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_treasury.Proposal> _proposalsTypedStorage;
        
        /// <summary>
        /// _deactivatedTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> _deactivatedTypedStorage;
        
        /// <summary>
        /// _approvalsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT26> _approvalsTypedStorage;
        
        /// <summary>
        /// TreasuryStorage constructor.
        /// </summary>
        public TreasuryStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.ProposalCountTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("Treasury.ProposalCount", storageDataProvider, storageChangeDelegates);
            this.ProposalsTypedStorage = new TypedMapStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_treasury.Proposal>("Treasury.Proposals", storageDataProvider, storageChangeDelegates);
            this.DeactivatedTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128>("Treasury.Deactivated", storageDataProvider, storageChangeDelegates);
            this.ApprovalsTypedStorage = new TypedStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT26>("Treasury.Approvals", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _proposalCountTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> ProposalCountTypedStorage
        {
            get
            {
                return _proposalCountTypedStorage;
            }
            set
            {
                _proposalCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _proposalsTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_treasury.Proposal> ProposalsTypedStorage
        {
            get
            {
                return _proposalsTypedStorage;
            }
            set
            {
                _proposalsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _deactivatedTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U128> DeactivatedTypedStorage
        {
            get
            {
                return _deactivatedTypedStorage;
            }
            set
            {
                _deactivatedTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _approvalsTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT26> ApprovalsTypedStorage
        {
            get
            {
                return _approvalsTypedStorage;
            }
            set
            {
                _approvalsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await ProposalCountTypedStorage.InitializeAsync("Treasury", "ProposalCount");
            await ProposalsTypedStorage.InitializeAsync("Treasury", "Proposals");
            await DeactivatedTypedStorage.InitializeAsync("Treasury", "Deactivated");
            await ApprovalsTypedStorage.InitializeAsync("Treasury", "Approvals");
        }
        
        /// <summary>
        /// Implements any storage change for Treasury.ProposalCount
        /// </summary>
        [StorageChange("Treasury", "ProposalCount")]
        public void OnUpdateProposalCount(string data)
        {
            ProposalCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ProposalCount
        ///  Number of proposals that have been made.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetProposalCount()
        {
            return ProposalCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Treasury.Proposals
        /// </summary>
        [StorageChange("Treasury", "Proposals")]
        public void OnUpdateProposals(string key, string data)
        {
            ProposalsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Proposals
        ///  Proposals that have been made.
        /// </summary>
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_treasury.Proposal GetProposals(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ProposalsTypedStorage.Dictionary.TryGetValue(key, out Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_treasury.Proposal result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Treasury.Deactivated
        /// </summary>
        [StorageChange("Treasury", "Deactivated")]
        public void OnUpdateDeactivated(string data)
        {
            DeactivatedTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Deactivated
        ///  The amount which has been reported as inactive to Currency.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 GetDeactivated()
        {
            return DeactivatedTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Treasury.Approvals
        /// </summary>
        [StorageChange("Treasury", "Approvals")]
        public void OnUpdateApprovals(string data)
        {
            ApprovalsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Approvals
        ///  Proposal indices that have been approved but not yet awarded.
        /// </summary>
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT26 GetApprovals()
        {
            return ApprovalsTypedStorage.Get();
        }
    }
}
