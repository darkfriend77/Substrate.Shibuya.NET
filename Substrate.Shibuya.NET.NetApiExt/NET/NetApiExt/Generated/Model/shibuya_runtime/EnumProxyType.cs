//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Shibuya.NET.NetApiExt.Generated.Model.shibuya_runtime
{
    
    
    public enum ProxyType
    {
        
        Any = 0,
        
        NonTransfer = 1,
        
        Balances = 2,
        
        Assets = 3,
        
        Governance = 4,
        
        IdentityJudgement = 5,
        
        CancelProxy = 6,
        
        DappsStaking = 7,
        
        StakerRewardClaim = 8,
    }
    
    /// <summary>
    /// >> 40 - Variant[shibuya_runtime.ProxyType]
    /// </summary>
    public sealed class EnumProxyType : BaseEnum<ProxyType>
    {
    }
}
