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
    
    public partial class Ms_Commission
    {
        public int CommissionDocId { get; set; }
        public Nullable<int> TrNo { get; set; }
        public Nullable<System.DateTime> TrDate { get; set; }
        public Nullable<int> EmpId { get; set; }
        public Nullable<byte> CalcMethod { get; set; }
        public Nullable<decimal> CommissionPercent { get; set; }
        public Nullable<decimal> CommissionValue { get; set; }
        public Nullable<int> FromBookId { get; set; }
        public Nullable<int> ToBookId { get; set; }
        public Nullable<bool> IsPaid { get; set; }
        public Nullable<int> PaidDocId { get; set; }
    }
}