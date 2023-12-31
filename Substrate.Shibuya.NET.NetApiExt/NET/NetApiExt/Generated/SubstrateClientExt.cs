//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types.Base;
using Substrate.Shibuya.NET.NetApiExt.Generated.Storage;
using System.Collections.Generic;


namespace Substrate.Shibuya.NET.NetApiExt.Generated
{
    
    
    public sealed class SubstrateClientExt : Substrate.NetApi.SubstrateClient
    {
        
        /// <summary>
        /// StorageKeyDict for key definition informations.
        /// </summary>
        public System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>> StorageKeyDict;
        
        /// <summary>
        /// SystemStorage storage calls.
        /// </summary>
        public SystemStorage SystemStorage;
        
        /// <summary>
        /// UtilityStorage storage calls.
        /// </summary>
        public UtilityStorage UtilityStorage;
        
        /// <summary>
        /// IdentityStorage storage calls.
        /// </summary>
        public IdentityStorage IdentityStorage;
        
        /// <summary>
        /// TimestampStorage storage calls.
        /// </summary>
        public TimestampStorage TimestampStorage;
        
        /// <summary>
        /// MultisigStorage storage calls.
        /// </summary>
        public MultisigStorage MultisigStorage;
        
        /// <summary>
        /// EthCallStorage storage calls.
        /// </summary>
        public EthCallStorage EthCallStorage;
        
        /// <summary>
        /// RandomnessCollectiveFlipStorage storage calls.
        /// </summary>
        public RandomnessCollectiveFlipStorage RandomnessCollectiveFlipStorage;
        
        /// <summary>
        /// SchedulerStorage storage calls.
        /// </summary>
        public SchedulerStorage SchedulerStorage;
        
        /// <summary>
        /// ProxyStorage storage calls.
        /// </summary>
        public ProxyStorage ProxyStorage;
        
        /// <summary>
        /// ParachainSystemStorage storage calls.
        /// </summary>
        public ParachainSystemStorage ParachainSystemStorage;
        
        /// <summary>
        /// ParachainInfoStorage storage calls.
        /// </summary>
        public ParachainInfoStorage ParachainInfoStorage;
        
        /// <summary>
        /// TransactionPaymentStorage storage calls.
        /// </summary>
        public TransactionPaymentStorage TransactionPaymentStorage;
        
        /// <summary>
        /// BalancesStorage storage calls.
        /// </summary>
        public BalancesStorage BalancesStorage;
        
        /// <summary>
        /// VestingStorage storage calls.
        /// </summary>
        public VestingStorage VestingStorage;
        
        /// <summary>
        /// DappsStakingStorage storage calls.
        /// </summary>
        public DappsStakingStorage DappsStakingStorage;
        
        /// <summary>
        /// BlockRewardStorage storage calls.
        /// </summary>
        public BlockRewardStorage BlockRewardStorage;
        
        /// <summary>
        /// AssetsStorage storage calls.
        /// </summary>
        public AssetsStorage AssetsStorage;
        
        /// <summary>
        /// AuthorshipStorage storage calls.
        /// </summary>
        public AuthorshipStorage AuthorshipStorage;
        
        /// <summary>
        /// CollatorSelectionStorage storage calls.
        /// </summary>
        public CollatorSelectionStorage CollatorSelectionStorage;
        
        /// <summary>
        /// SessionStorage storage calls.
        /// </summary>
        public SessionStorage SessionStorage;
        
        /// <summary>
        /// AuraStorage storage calls.
        /// </summary>
        public AuraStorage AuraStorage;
        
        /// <summary>
        /// AuraExtStorage storage calls.
        /// </summary>
        public AuraExtStorage AuraExtStorage;
        
        /// <summary>
        /// XcmpQueueStorage storage calls.
        /// </summary>
        public XcmpQueueStorage XcmpQueueStorage;
        
        /// <summary>
        /// PolkadotXcmStorage storage calls.
        /// </summary>
        public PolkadotXcmStorage PolkadotXcmStorage;
        
        /// <summary>
        /// CumulusXcmStorage storage calls.
        /// </summary>
        public CumulusXcmStorage CumulusXcmStorage;
        
        /// <summary>
        /// DmpQueueStorage storage calls.
        /// </summary>
        public DmpQueueStorage DmpQueueStorage;
        
        /// <summary>
        /// XcAssetConfigStorage storage calls.
        /// </summary>
        public XcAssetConfigStorage XcAssetConfigStorage;
        
        /// <summary>
        /// XtokensStorage storage calls.
        /// </summary>
        public XtokensStorage XtokensStorage;
        
        /// <summary>
        /// EVMStorage storage calls.
        /// </summary>
        public EVMStorage EVMStorage;
        
        /// <summary>
        /// EthereumStorage storage calls.
        /// </summary>
        public EthereumStorage EthereumStorage;
        
        /// <summary>
        /// BaseFeeStorage storage calls.
        /// </summary>
        public BaseFeeStorage BaseFeeStorage;
        
        /// <summary>
        /// EVMChainIdStorage storage calls.
        /// </summary>
        public EVMChainIdStorage EVMChainIdStorage;
        
        /// <summary>
        /// ContractsStorage storage calls.
        /// </summary>
        public ContractsStorage ContractsStorage;
        
        /// <summary>
        /// DemocracyStorage storage calls.
        /// </summary>
        public DemocracyStorage DemocracyStorage;
        
        /// <summary>
        /// CouncilStorage storage calls.
        /// </summary>
        public CouncilStorage CouncilStorage;
        
        /// <summary>
        /// TechnicalCommitteeStorage storage calls.
        /// </summary>
        public TechnicalCommitteeStorage TechnicalCommitteeStorage;
        
        /// <summary>
        /// TreasuryStorage storage calls.
        /// </summary>
        public TreasuryStorage TreasuryStorage;
        
        /// <summary>
        /// PreimageStorage storage calls.
        /// </summary>
        public PreimageStorage PreimageStorage;
        
        /// <summary>
        /// XvmStorage storage calls.
        /// </summary>
        public XvmStorage XvmStorage;
        
        /// <summary>
        /// SudoStorage storage calls.
        /// </summary>
        public SudoStorage SudoStorage;
        
        /// <summary>
        /// StateTrieMigrationStorage storage calls.
        /// </summary>
        public StateTrieMigrationStorage StateTrieMigrationStorage;
        
        public SubstrateClientExt(System.Uri uri, Substrate.NetApi.Model.Extrinsics.ChargeType chargeType) : 
                base(uri, chargeType)
        {
            StorageKeyDict = new System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>>();
            this.SystemStorage = new SystemStorage(this);
            this.UtilityStorage = new UtilityStorage(this);
            this.IdentityStorage = new IdentityStorage(this);
            this.TimestampStorage = new TimestampStorage(this);
            this.MultisigStorage = new MultisigStorage(this);
            this.EthCallStorage = new EthCallStorage(this);
            this.RandomnessCollectiveFlipStorage = new RandomnessCollectiveFlipStorage(this);
            this.SchedulerStorage = new SchedulerStorage(this);
            this.ProxyStorage = new ProxyStorage(this);
            this.ParachainSystemStorage = new ParachainSystemStorage(this);
            this.ParachainInfoStorage = new ParachainInfoStorage(this);
            this.TransactionPaymentStorage = new TransactionPaymentStorage(this);
            this.BalancesStorage = new BalancesStorage(this);
            this.VestingStorage = new VestingStorage(this);
            this.DappsStakingStorage = new DappsStakingStorage(this);
            this.BlockRewardStorage = new BlockRewardStorage(this);
            this.AssetsStorage = new AssetsStorage(this);
            this.AuthorshipStorage = new AuthorshipStorage(this);
            this.CollatorSelectionStorage = new CollatorSelectionStorage(this);
            this.SessionStorage = new SessionStorage(this);
            this.AuraStorage = new AuraStorage(this);
            this.AuraExtStorage = new AuraExtStorage(this);
            this.XcmpQueueStorage = new XcmpQueueStorage(this);
            this.PolkadotXcmStorage = new PolkadotXcmStorage(this);
            this.CumulusXcmStorage = new CumulusXcmStorage(this);
            this.DmpQueueStorage = new DmpQueueStorage(this);
            this.XcAssetConfigStorage = new XcAssetConfigStorage(this);
            this.XtokensStorage = new XtokensStorage(this);
            this.EVMStorage = new EVMStorage(this);
            this.EthereumStorage = new EthereumStorage(this);
            this.BaseFeeStorage = new BaseFeeStorage(this);
            this.EVMChainIdStorage = new EVMChainIdStorage(this);
            this.ContractsStorage = new ContractsStorage(this);
            this.DemocracyStorage = new DemocracyStorage(this);
            this.CouncilStorage = new CouncilStorage(this);
            this.TechnicalCommitteeStorage = new TechnicalCommitteeStorage(this);
            this.TreasuryStorage = new TreasuryStorage(this);
            this.PreimageStorage = new PreimageStorage(this);
            this.XvmStorage = new XvmStorage(this);
            this.SudoStorage = new SudoStorage(this);
            this.StateTrieMigrationStorage = new StateTrieMigrationStorage(this);
        }
    }
}
