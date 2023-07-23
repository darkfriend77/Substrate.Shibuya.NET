//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_assets.types
{
    
    
    /// <summary>
    /// >> 409 - Composite[pallet_assets.types.AssetDetails]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class AssetDetails : BaseType
    {
        
        /// <summary>
        /// >> owner
        /// </summary>
        private Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _owner;
        
        /// <summary>
        /// >> issuer
        /// </summary>
        private Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _issuer;
        
        /// <summary>
        /// >> admin
        /// </summary>
        private Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _admin;
        
        /// <summary>
        /// >> freezer
        /// </summary>
        private Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _freezer;
        
        /// <summary>
        /// >> supply
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _supply;
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _deposit;
        
        /// <summary>
        /// >> min_balance
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _minBalance;
        
        /// <summary>
        /// >> is_sufficient
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.Bool _isSufficient;
        
        /// <summary>
        /// >> accounts
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _accounts;
        
        /// <summary>
        /// >> sufficients
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _sufficients;
        
        /// <summary>
        /// >> approvals
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _approvals;
        
        /// <summary>
        /// >> status
        /// </summary>
        private Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_assets.types.EnumAssetStatus _status;
        
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Owner
        {
            get
            {
                return this._owner;
            }
            set
            {
                this._owner = value;
            }
        }
        
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Issuer
        {
            get
            {
                return this._issuer;
            }
            set
            {
                this._issuer = value;
            }
        }
        
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Admin
        {
            get
            {
                return this._admin;
            }
            set
            {
                this._admin = value;
            }
        }
        
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Freezer
        {
            get
            {
                return this._freezer;
            }
            set
            {
                this._freezer = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Supply
        {
            get
            {
                return this._supply;
            }
            set
            {
                this._supply = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Deposit
        {
            get
            {
                return this._deposit;
            }
            set
            {
                this._deposit = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 MinBalance
        {
            get
            {
                return this._minBalance;
            }
            set
            {
                this._minBalance = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.Bool IsSufficient
        {
            get
            {
                return this._isSufficient;
            }
            set
            {
                this._isSufficient = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Accounts
        {
            get
            {
                return this._accounts;
            }
            set
            {
                this._accounts = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Sufficients
        {
            get
            {
                return this._sufficients;
            }
            set
            {
                this._sufficients = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Approvals
        {
            get
            {
                return this._approvals;
            }
            set
            {
                this._approvals = value;
            }
        }
        
        public Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_assets.types.EnumAssetStatus Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        
        public override string TypeName()
        {
            return "AssetDetails";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Owner.Encode());
            result.AddRange(Issuer.Encode());
            result.AddRange(Admin.Encode());
            result.AddRange(Freezer.Encode());
            result.AddRange(Supply.Encode());
            result.AddRange(Deposit.Encode());
            result.AddRange(MinBalance.Encode());
            result.AddRange(IsSufficient.Encode());
            result.AddRange(Accounts.Encode());
            result.AddRange(Sufficients.Encode());
            result.AddRange(Approvals.Encode());
            result.AddRange(Status.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Owner = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Owner.Decode(byteArray, ref p);
            Issuer = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Issuer.Decode(byteArray, ref p);
            Admin = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Admin.Decode(byteArray, ref p);
            Freezer = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Freezer.Decode(byteArray, ref p);
            Supply = new Substrate.NetApi.Model.Types.Primitive.U128();
            Supply.Decode(byteArray, ref p);
            Deposit = new Substrate.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            MinBalance = new Substrate.NetApi.Model.Types.Primitive.U128();
            MinBalance.Decode(byteArray, ref p);
            IsSufficient = new Substrate.NetApi.Model.Types.Primitive.Bool();
            IsSufficient.Decode(byteArray, ref p);
            Accounts = new Substrate.NetApi.Model.Types.Primitive.U32();
            Accounts.Decode(byteArray, ref p);
            Sufficients = new Substrate.NetApi.Model.Types.Primitive.U32();
            Sufficients.Decode(byteArray, ref p);
            Approvals = new Substrate.NetApi.Model.Types.Primitive.U32();
            Approvals.Decode(byteArray, ref p);
            Status = new Substrate.Shibuya.NET.NetApiExt.Generated.Model.pallet_assets.types.EnumAssetStatus();
            Status.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
