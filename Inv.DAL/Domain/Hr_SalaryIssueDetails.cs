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
    
    public partial class Hr_SalaryIssueDetails
    {
        public int SalaryIssuDetailId { get; set; }
        public Nullable<int> SalaryIssuDocId { get; set; }
        public Nullable<int> SalaryTypId { get; set; }
        public Nullable<decimal> ElementCount { get; set; }
        public string ElementCountDesc { get; set; }
        public Nullable<decimal> ElementUnitValue { get; set; }
        public Nullable<decimal> AddValue { get; set; }
        public Nullable<decimal> DeductValue { get; set; }
        public Nullable<decimal> OtherValue { get; set; }
        public Nullable<int> DebitAccountId { get; set; }
        public Nullable<int> CreditAccountId { get; set; }
        public Nullable<int> DebitCostcenterId { get; set; }
        public Nullable<int> CreditCostCenterId { get; set; }
        public Nullable<int> DebitEmpAccountId { get; set; }
        public Nullable<int> CreditEmpAccountId { get; set; }
    }
}
