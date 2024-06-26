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
    
    public partial class Ms_LetterOfGuaranteeTrans
    {
        public int LetOfGrnteeTranId { get; set; }
        public Nullable<int> LetOfGrnteeId { get; set; }
        public Nullable<int> StoreId { get; set; }
        public Nullable<int> LetOfGrnteeStatusId { get; set; }
        public Nullable<int> AId { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<int> LetOfGrnteeTypeId { get; set; }
        public Nullable<int> LetOfGrnteeCatId { get; set; }
        public Nullable<int> LetOfGrnteeStatusId1 { get; set; }
        public Nullable<byte> PaperDirection { get; set; }
        public string DBTableName { get; set; }
        public Nullable<int> DBTableId { get; set; }
        public string AccountTableName { get; set; }
        public Nullable<int> AccountId { get; set; }
        public Nullable<int> BankAccountId { get; set; }
        public Nullable<byte> ResourceType { get; set; }
        public Nullable<int> ResourceId { get; set; }
        public Nullable<int> BookId { get; set; }
        public Nullable<int> TermId { get; set; }
        public Nullable<int> FinancialIntervalsId { get; set; }
        public Nullable<int> CostCenterId1 { get; set; }
        public Nullable<int> CostCenterId2 { get; set; }
        public Nullable<int> LetrOfGAccountId { get; set; }
        public Nullable<int> LetrOfGExpensAccountId { get; set; }
        public Nullable<int> LetrOfGCommisionAccountId { get; set; }
        public string Description { get; set; }
        public string ReceiverName { get; set; }
        public string ManualTrNo { get; set; }
        public Nullable<int> TrNo { get; set; }
        public Nullable<System.DateTime> TrDate { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> PaidPrice { get; set; }
        public Nullable<decimal> ValueBeforeRate { get; set; }
        public Nullable<decimal> Commision { get; set; }
        public Nullable<decimal> CashMargin { get; set; }
        public Nullable<bool> IsCovered { get; set; }
        public Nullable<decimal> CoverPercent { get; set; }
        public Nullable<decimal> CoverValue { get; set; }
        public Nullable<decimal> Expenses { get; set; }
        public Nullable<System.DateTime> LetEndDate { get; set; }
        public string Conditions { get; set; }
        public Nullable<byte> ValuEffect { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> TermCostCenterId { get; set; }
        public Nullable<decimal> TermCostCenterValue { get; set; }
        public Nullable<bool> IsPosted { get; set; }
        public string Postedby { get; set; }
        public Nullable<System.DateTime> PostedDate { get; set; }
        public Nullable<bool> Closed { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public Nullable<System.DateTime> UncloseDate { get; set; }
        public Nullable<int> ClosedBy { get; set; }
        public Nullable<int> UnclosedBy { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
    }
}
