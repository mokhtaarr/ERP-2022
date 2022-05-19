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
    
    public partial class Cal_CostCenters
    {
        public int CostCenterId { get; set; }
        public Nullable<int> CostCenterCode { get; set; }
        public string CostCenterNameA { get; set; }
        public string CostCenterNameE { get; set; }
        public Nullable<int> mainCostCenterId { get; set; }
        public Nullable<int> CostCenterLevel { get; set; }
        public Nullable<byte> CenterCategory { get; set; }
        public Nullable<byte> CostType { get; set; }
        public Nullable<byte> CashFlowList { get; set; }
        public Nullable<int> Aid { get; set; }
        public Nullable<int> AccountId { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public string FunctionDescA { get; set; }
        public string FunctionDescE { get; set; }
        public Nullable<decimal> PreviousBalance { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
        public string RemarksA { get; set; }
        public string RemarksE { get; set; }
        public Nullable<int> Parent { get; set; }
        public Nullable<int> MonthlybalanceId { get; set; }
        public Nullable<byte> jopDesc { get; set; }
        public Nullable<int> BoxId { get; set; }
        public Nullable<int> AccCostCenterId { get; set; }
        public Nullable<decimal> OpenningBalanceDepit { get; set; }
        public Nullable<decimal> OpenningBalanceCredit { get; set; }
        public Nullable<decimal> CostCenterCurrTrancDepit { get; set; }
        public Nullable<decimal> CostCenterCurrTrancCredit { get; set; }
        public Nullable<decimal> CostCenterTotalDebit { get; set; }
        public Nullable<decimal> CostCenterTotaCredit { get; set; }
        public Nullable<decimal> BalanceDebitLocal { get; set; }
        public Nullable<decimal> BalanceCreditLocal { get; set; }
        public Nullable<decimal> OpenningBalanceDepitCurncy { get; set; }
        public Nullable<decimal> OpenningBalanceCreditCurncy { get; set; }
        public Nullable<decimal> CostCenterCurrTrancDepitCurncy { get; set; }
        public Nullable<decimal> CostCenterCurrTrancCreditCurncy { get; set; }
        public Nullable<decimal> CostCenterTotalDebitCurncy { get; set; }
        public Nullable<decimal> CostCenterTotaCreditCurncy { get; set; }
        public Nullable<decimal> BalanceDebitCurncy { get; set; }
        public Nullable<decimal> BalanceCreditCurncy { get; set; }
    }
}