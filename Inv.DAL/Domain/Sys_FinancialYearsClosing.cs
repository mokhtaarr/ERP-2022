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
    
    public partial class Sys_FinancialYearsClosing
    {
        public int ClosingId { get; set; }
        public Nullable<int> ClosingCode { get; set; }
        public int FinancialYearsId { get; set; }
        public Nullable<System.DateTime> ClosingDate { get; set; }
        public Nullable<System.DateTime> ClosingDateHejri { get; set; }
        public Nullable<int> CurrentYear { get; set; }
        public Nullable<int> ClosingAccountId { get; set; }
        public string RemarksA { get; set; }
        public string RemarksE { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
        public Nullable<bool> IsCancel { get; set; }
        public Nullable<bool> IsTransfer { get; set; }
    }
}
