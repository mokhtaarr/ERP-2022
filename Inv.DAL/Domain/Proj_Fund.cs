//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inv.DAL.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Proj_Fund
    {
        public int ProjectFundId { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<int> AccountId { get; set; }
        public string FundName1 { get; set; }
        public string FundName2 { get; set; }
        public Nullable<decimal> FundPercent { get; set; }
        public Nullable<decimal> FundValue { get; set; }
        public string Description { get; set; }
        public string Contact { get; set; }
    }
}
