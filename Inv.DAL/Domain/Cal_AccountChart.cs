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
    
    public partial class Cal_AccountChart
    {
        public int AccountId { get; set; }
        public Nullable<long> AccountCode { get; set; }
        public string AccountNameA { get; set; }
        public string AccountNameE { get; set; }
        public Nullable<int> mainAccountId { get; set; }
        public Nullable<int> AccountLevel { get; set; }
        public Nullable<byte> AccountType { get; set; }
        public Nullable<byte> AccountNature { get; set; }
        public Nullable<byte> AccountGroup { get; set; }
        public Nullable<byte> AccCashFlow { get; set; }
        public Nullable<bool> CalcMethod { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<int> Aid { get; set; }
        public Nullable<int> AccBulkAccount { get; set; }
        public Nullable<int> AccountCategory { get; set; }
        public Nullable<bool> CostCentersDistribute { get; set; }
        public Nullable<bool> CurrencyReevaluation { get; set; }
        public Nullable<bool> AccountStopped { get; set; }
        public string RemarksA { get; set; }
        public string RemarksE { get; set; }
        public Nullable<decimal> OpenningBalanceDepit { get; set; }
        public Nullable<decimal> OpenningBalanceCredit { get; set; }
        public Nullable<decimal> AccCurrTrancDepit { get; set; }
        public Nullable<decimal> AccCurrTrancCredit { get; set; }
        public Nullable<decimal> AccTotalDebit { get; set; }
        public Nullable<decimal> AccTotaCredit { get; set; }
        public Nullable<decimal> BalanceDebitLocal { get; set; }
        public Nullable<decimal> BalanceCreditLocal { get; set; }
        public Nullable<decimal> OpenningBalanceDepitCurncy { get; set; }
        public Nullable<decimal> OpenningBalanceCreditCurncy { get; set; }
        public Nullable<decimal> AccCurrTrancDepitCurncy { get; set; }
        public Nullable<decimal> AccCurrTrancCreditCurncy { get; set; }
        public Nullable<decimal> AccTotalDebitCurncy { get; set; }
        public Nullable<decimal> AccTotaCreditCurncy { get; set; }
        public Nullable<decimal> BalanceDebitCurncy { get; set; }
        public Nullable<decimal> BalanceCreditCurncy { get; set; }
        public Nullable<decimal> AccApproxim { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
        public Nullable<byte> CostCenterOption { get; set; }
    }
}