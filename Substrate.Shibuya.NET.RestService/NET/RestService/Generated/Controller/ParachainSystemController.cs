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
    /// ParachainSystemController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class ParachainSystemController : ControllerBase
    {
        
        private IParachainSystemStorage _parachainSystemStorage;
        
        /// <summary>
        /// ParachainSystemController constructor.
        /// </summary>
        public ParachainSystemController(IParachainSystemStorage parachainSystemStorage)
        {
            _parachainSystemStorage = parachainSystemStorage;
        }
        
        /// <summary>
        /// >> PendingValidationCode
        ///  In case of a scheduled upgrade, this storage field contains the validation code to be applied.
        /// 
        ///  As soon as the relay chain gives us the go-ahead signal, we will overwrite the [`:code`][well_known_keys::CODE]
        ///  which will result the next block process with the new validation code. This concludes the upgrade process.
        /// 
        ///  [well_known_keys::CODE]: sp_core::storage::well_known_keys::CODE
        /// </summary>
        [HttpGet("PendingValidationCode")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "PendingValidationCodeParams")]
        public IActionResult GetPendingValidationCode()
        {
            return this.Ok(_parachainSystemStorage.GetPendingValidationCode());
        }
        
        /// <summary>
        /// >> NewValidationCode
        ///  Validation code that is set by the parachain and is to be communicated to collator and
        ///  consequently the relay-chain.
        /// 
        ///  This will be cleared in `on_initialize` of each new block if no other pallet already set
        ///  the value.
        /// </summary>
        [HttpGet("NewValidationCode")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "NewValidationCodeParams")]
        public IActionResult GetNewValidationCode()
        {
            return this.Ok(_parachainSystemStorage.GetNewValidationCode());
        }
        
        /// <summary>
        /// >> ValidationData
        ///  The [`PersistedValidationData`] set for this block.
        ///  This value is expected to be set only once per block and it's never stored
        ///  in the trie.
        /// </summary>
        [HttpGet("ValidationData")]
        [ProducesResponseType(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.polkadot_primitives.v2.PersistedValidationData), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "ValidationDataParams")]
        public IActionResult GetValidationData()
        {
            return this.Ok(_parachainSystemStorage.GetValidationData());
        }
        
        /// <summary>
        /// >> DidSetValidationCode
        ///  Were the validation data set to notify the relay chain?
        /// </summary>
        [HttpGet("DidSetValidationCode")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.Bool), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "DidSetValidationCodeParams")]
        public IActionResult GetDidSetValidationCode()
        {
            return this.Ok(_parachainSystemStorage.GetDidSetValidationCode());
        }
        
        /// <summary>
        /// >> LastRelayChainBlockNumber
        ///  The relay chain block number associated with the last parachain block.
        /// </summary>
        [HttpGet("LastRelayChainBlockNumber")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "LastRelayChainBlockNumberParams")]
        public IActionResult GetLastRelayChainBlockNumber()
        {
            return this.Ok(_parachainSystemStorage.GetLastRelayChainBlockNumber());
        }
        
        /// <summary>
        /// >> UpgradeRestrictionSignal
        ///  An option which indicates if the relay-chain restricts signalling a validation code upgrade.
        ///  In other words, if this is `Some` and [`NewValidationCode`] is `Some` then the produced
        ///  candidate will be invalid.
        /// 
        ///  This storage item is a mirror of the corresponding value for the current parachain from the
        ///  relay-chain. This value is ephemeral which means it doesn't hit the storage. This value is
        ///  set after the inherent.
        /// </summary>
        [HttpGet("UpgradeRestrictionSignal")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Shibuya.NET.NetApiExt.Generated.Model.polkadot_primitives.v2.EnumUpgradeRestriction>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "UpgradeRestrictionSignalParams")]
        public IActionResult GetUpgradeRestrictionSignal()
        {
            return this.Ok(_parachainSystemStorage.GetUpgradeRestrictionSignal());
        }
        
        /// <summary>
        /// >> RelayStateProof
        ///  The state proof for the last relay parent block.
        /// 
        ///  This field is meant to be updated each block with the validation data inherent. Therefore,
        ///  before processing of the inherent, e.g. in `on_initialize` this data may be stale.
        /// 
        ///  This data is also absent from the genesis.
        /// </summary>
        [HttpGet("RelayStateProof")]
        [ProducesResponseType(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_trie.storage_proof.StorageProof), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "RelayStateProofParams")]
        public IActionResult GetRelayStateProof()
        {
            return this.Ok(_parachainSystemStorage.GetRelayStateProof());
        }
        
        /// <summary>
        /// >> RelevantMessagingState
        ///  The snapshot of some state related to messaging relevant to the current parachain as per
        ///  the relay parent.
        /// 
        ///  This field is meant to be updated each block with the validation data inherent. Therefore,
        ///  before processing of the inherent, e.g. in `on_initialize` this data may be stale.
        /// 
        ///  This data is also absent from the genesis.
        /// </summary>
        [HttpGet("RelevantMessagingState")]
        [ProducesResponseType(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.cumulus_pallet_parachain_system.relay_state_snapshot.MessagingStateSnapshot), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "RelevantMessagingStateParams")]
        public IActionResult GetRelevantMessagingState()
        {
            return this.Ok(_parachainSystemStorage.GetRelevantMessagingState());
        }
        
        /// <summary>
        /// >> HostConfiguration
        ///  The parachain host configuration that was obtained from the relay parent.
        /// 
        ///  This field is meant to be updated each block with the validation data inherent. Therefore,
        ///  before processing of the inherent, e.g. in `on_initialize` this data may be stale.
        /// 
        ///  This data is also absent from the genesis.
        /// </summary>
        [HttpGet("HostConfiguration")]
        [ProducesResponseType(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.polkadot_primitives.v2.AbridgedHostConfiguration), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "HostConfigurationParams")]
        public IActionResult GetHostConfiguration()
        {
            return this.Ok(_parachainSystemStorage.GetHostConfiguration());
        }
        
        /// <summary>
        /// >> LastDmqMqcHead
        ///  The last downward message queue chain head we have observed.
        /// 
        ///  This value is loaded before and saved after processing inbound downward messages carried
        ///  by the system inherent.
        /// </summary>
        [HttpGet("LastDmqMqcHead")]
        [ProducesResponseType(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.cumulus_primitives_parachain_inherent.MessageQueueChain), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "LastDmqMqcHeadParams")]
        public IActionResult GetLastDmqMqcHead()
        {
            return this.Ok(_parachainSystemStorage.GetLastDmqMqcHead());
        }
        
        /// <summary>
        /// >> LastHrmpMqcHeads
        ///  The message queue chain heads we have observed per each channel incoming channel.
        /// 
        ///  This value is loaded before and saved after processing inbound downward messages carried
        ///  by the system inherent.
        /// </summary>
        [HttpGet("LastHrmpMqcHeads")]
        [ProducesResponseType(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Types.Base.BTreeMapT2), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "LastHrmpMqcHeadsParams")]
        public IActionResult GetLastHrmpMqcHeads()
        {
            return this.Ok(_parachainSystemStorage.GetLastHrmpMqcHeads());
        }
        
        /// <summary>
        /// >> ProcessedDownwardMessages
        ///  Number of downward messages processed in a block.
        /// 
        ///  This will be cleared in `on_initialize` of each new block.
        /// </summary>
        [HttpGet("ProcessedDownwardMessages")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "ProcessedDownwardMessagesParams")]
        public IActionResult GetProcessedDownwardMessages()
        {
            return this.Ok(_parachainSystemStorage.GetProcessedDownwardMessages());
        }
        
        /// <summary>
        /// >> HrmpWatermark
        ///  HRMP watermark that was set in a block.
        /// 
        ///  This will be cleared in `on_initialize` of each new block.
        /// </summary>
        [HttpGet("HrmpWatermark")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "HrmpWatermarkParams")]
        public IActionResult GetHrmpWatermark()
        {
            return this.Ok(_parachainSystemStorage.GetHrmpWatermark());
        }
        
        /// <summary>
        /// >> HrmpOutboundMessages
        ///  HRMP messages that were sent in a block.
        /// 
        ///  This will be cleared in `on_initialize` of each new block.
        /// </summary>
        [HttpGet("HrmpOutboundMessages")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Shibuya.NET.NetApiExt.Generated.Model.polkadot_core_primitives.OutboundHrmpMessage>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "HrmpOutboundMessagesParams")]
        public IActionResult GetHrmpOutboundMessages()
        {
            return this.Ok(_parachainSystemStorage.GetHrmpOutboundMessages());
        }
        
        /// <summary>
        /// >> UpwardMessages
        ///  Upward messages that were sent in a block.
        /// 
        ///  This will be cleared in `on_initialize` of each new block.
        /// </summary>
        [HttpGet("UpwardMessages")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "UpwardMessagesParams")]
        public IActionResult GetUpwardMessages()
        {
            return this.Ok(_parachainSystemStorage.GetUpwardMessages());
        }
        
        /// <summary>
        /// >> PendingUpwardMessages
        ///  Upward messages that are still pending and not yet send to the relay chain.
        /// </summary>
        [HttpGet("PendingUpwardMessages")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "PendingUpwardMessagesParams")]
        public IActionResult GetPendingUpwardMessages()
        {
            return this.Ok(_parachainSystemStorage.GetPendingUpwardMessages());
        }
        
        /// <summary>
        /// >> AnnouncedHrmpMessagesPerCandidate
        ///  The number of HRMP messages we observed in `on_initialize` and thus used that number for
        ///  announcing the weight of `on_initialize` and `on_finalize`.
        /// </summary>
        [HttpGet("AnnouncedHrmpMessagesPerCandidate")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "AnnouncedHrmpMessagesPerCandidateParams")]
        public IActionResult GetAnnouncedHrmpMessagesPerCandidate()
        {
            return this.Ok(_parachainSystemStorage.GetAnnouncedHrmpMessagesPerCandidate());
        }
        
        /// <summary>
        /// >> ReservedXcmpWeightOverride
        ///  The weight we reserve at the beginning of the block for processing XCMP messages. This
        ///  overrides the amount set in the Config trait.
        /// </summary>
        [HttpGet("ReservedXcmpWeightOverride")]
        [ProducesResponseType(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "ReservedXcmpWeightOverrideParams")]
        public IActionResult GetReservedXcmpWeightOverride()
        {
            return this.Ok(_parachainSystemStorage.GetReservedXcmpWeightOverride());
        }
        
        /// <summary>
        /// >> ReservedDmpWeightOverride
        ///  The weight we reserve at the beginning of the block for processing DMP messages. This
        ///  overrides the amount set in the Config trait.
        /// </summary>
        [HttpGet("ReservedDmpWeightOverride")]
        [ProducesResponseType(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "ReservedDmpWeightOverrideParams")]
        public IActionResult GetReservedDmpWeightOverride()
        {
            return this.Ok(_parachainSystemStorage.GetReservedDmpWeightOverride());
        }
        
        /// <summary>
        /// >> AuthorizedUpgrade
        ///  The next authorized upgrade, if there is one.
        /// </summary>
        [HttpGet("AuthorizedUpgrade")]
        [ProducesResponseType(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Model.primitive_types.H256), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "AuthorizedUpgradeParams")]
        public IActionResult GetAuthorizedUpgrade()
        {
            return this.Ok(_parachainSystemStorage.GetAuthorizedUpgrade());
        }
        
        /// <summary>
        /// >> CustomValidationHeadData
        ///  A custom head data that should be returned as result of `validate_block`.
        /// 
        ///  See [`Pallet::set_custom_validation_head_data`] for more information.
        /// </summary>
        [HttpGet("CustomValidationHeadData")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>), 200)]
        [StorageKeyBuilder(typeof(Substrate.Shibuya.NET.NetApiExt.Generated.Storage.ParachainSystemStorage), "CustomValidationHeadDataParams")]
        public IActionResult GetCustomValidationHeadData()
        {
            return this.Ok(_parachainSystemStorage.GetCustomValidationHeadData());
        }
    }
}
