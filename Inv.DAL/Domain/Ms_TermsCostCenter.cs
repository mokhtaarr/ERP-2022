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
    
    public partial class Ms_TermsCostCenter
    {
        public int TermCostCenterId { get; set; }
        public Nullable<int> TermId { get; set; }
        public Nullable<int> CostCenterIdDebit { get; set; }
        public Nullable<bool> CostCenterDebitFixed { get; set; }
        public string ValuCostCenterDebit { get; set; }
        public Nullable<int> CostCenterCredit { get; set; }
        public Nullable<bool> CostCenterCreditFixed { get; set; }
        public string ValuCostCenterCredit { get; set; }
        public Nullable<int> CostCenterIdDisc { get; set; }
        public Nullable<bool> CostCenterDiscIsFixed { get; set; }
        public string ValuCostCenterDisc { get; set; }
        public Nullable<int> CostCenterIdCash { get; set; }
        public Nullable<bool> CostCenterCashIsFixed { get; set; }
        public string ValuCostCenterCash { get; set; }
        public Nullable<int> CostCenterIdTax { get; set; }
        public Nullable<bool> CostCenterTaxIsFixed { get; set; }
        public string ValuCostCenterTax { get; set; }
        public Nullable<bool> CenterDiscDebitOrCredit { get; set; }
        public Nullable<bool> CenterCashDebitOrCredit { get; set; }
        public Nullable<bool> CenterTaxDebitOrCredit { get; set; }
        public Nullable<int> AddCostCenterId1 { get; set; }
        public Nullable<bool> AddCostCenter1IsFixed { get; set; }
        public string ValuAddCostCenter1 { get; set; }
        public Nullable<int> AddCostCenterId2 { get; set; }
        public Nullable<bool> AddCostCenterIsFixed2 { get; set; }
        public string ValuAddCostCenter2 { get; set; }
        public Nullable<int> AddCostCenterId3 { get; set; }
        public Nullable<bool> AddCostCenterIsFixed3 { get; set; }
        public string ValuAddCostCenter3 { get; set; }
        public Nullable<int> AddCostCenterId4 { get; set; }
        public Nullable<bool> AddCostCenterIsFixed4 { get; set; }
        public string ValuAddCostCenter4 { get; set; }
        public Nullable<int> AddCostCenterId5 { get; set; }
        public Nullable<bool> AddCostCenterIsFixed5 { get; set; }
        public string ValuAddCostCenter5 { get; set; }
        public Nullable<bool> AddCenter1DebitOrCredit { get; set; }
        public Nullable<bool> AddCenter2DebitOrCredit { get; set; }
        public Nullable<bool> AddCenter3DebitOrCredit { get; set; }
        public Nullable<bool> AddCenter4DebitOrCredit { get; set; }
        public Nullable<bool> AddCenter5DebitOrCredit { get; set; }
    }
}