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
    
    public partial class MS_Expenses
    {
        public int ExpensesId { get; set; }
        public string ExpensesCode { get; set; }
        public string ExpensesDescA { get; set; }
        public string ExpensesDescE { get; set; }
        public Nullable<byte> ExpensesType { get; set; }
        public Nullable<decimal> ExpensesValue { get; set; }
        public Nullable<int> AccountId { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
    }
}
