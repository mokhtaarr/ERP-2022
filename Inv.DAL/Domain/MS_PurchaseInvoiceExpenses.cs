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
    
    public partial class MS_PurchaseInvoiceExpenses
    {
        public int PurExpenseId { get; set; }
        public Nullable<int> PurInvId { get; set; }
        public Nullable<int> ExpensesId { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> ValueCurrency { get; set; }
        public Nullable<decimal> ValueAfterRate { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> CreditAccountId { get; set; }
    }
}
