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
    
    public partial class VW_SearchAllAccounts
    {
        public string AccountCode { get; set; }
        public string AccountNameA { get; set; }
        public Nullable<int> AccountLevel { get; set; }
        public Nullable<bool> CalcMethod { get; set; }
        public int AccType { get; set; }
        public string AccDesc { get; set; }
        public Nullable<decimal> BalanceDebitCurncy { get; set; }
        public Nullable<decimal> BalanceCreditCurncy { get; set; }
        public Nullable<byte> AccountType { get; set; }
        public Nullable<byte> AccountNature { get; set; }
        public Nullable<byte> AccountGroup { get; set; }
        public Nullable<byte> AccCashFlow { get; set; }
        public string AccDesc2 { get; set; }
        public string AccountDescription { get; set; }
        public Nullable<int> CurrencyId { get; set; }
    }
}
