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
    
    public partial class MS_PaymentNote
    {
        public int PayId { get; set; }
        public Nullable<int> PurInvId { get; set; }
        public Nullable<int> RetSaleId { get; set; }
        public Nullable<int> BoxId { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<int> VendorId { get; set; }
        public Nullable<int> StoreId { get; set; }
        public Nullable<int> EmpId { get; set; }
        public Nullable<int> CustodyEmpId { get; set; }
        public Nullable<int> BookId { get; set; }
        public Nullable<int> TermId { get; set; }
        public Nullable<int> ChequeOpenId { get; set; }
        public Nullable<int> ExpensesId { get; set; }
        public Nullable<int> BankNoticId { get; set; }
        public Nullable<int> FinancialIntervalsId { get; set; }
        public Nullable<int> TripId { get; set; }
        public string DBTableName { get; set; }
        public Nullable<int> DBTableId { get; set; }
        public string AccountTableName { get; set; }
        public Nullable<int> AccountId { get; set; }
        public Nullable<int> AId { get; set; }
        public int TrNo { get; set; }
        public string ManualTrNo { get; set; }
        public Nullable<System.DateTime> TrDate { get; set; }
        public Nullable<byte> TranType { get; set; }
        public Nullable<byte> RectSourceType { get; set; }
        public string OtherSource { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> PaidPrice { get; set; }
        public Nullable<decimal> NetPrice { get; set; }
        public Nullable<decimal> ValueBeforeRate { get; set; }
        public Nullable<decimal> Value1 { get; set; }
        public Nullable<decimal> Value1BeforeRate { get; set; }
        public Nullable<decimal> Value2 { get; set; }
        public Nullable<decimal> Value2BeforeRate { get; set; }
        public Nullable<decimal> Value3 { get; set; }
        public Nullable<decimal> Value3BeforeRate { get; set; }
        public Nullable<decimal> Value4 { get; set; }
        public Nullable<decimal> Value4BeforeRate { get; set; }
        public Nullable<decimal> Value5 { get; set; }
        public Nullable<decimal> Value5BeforeRate { get; set; }
        public Nullable<decimal> Value6 { get; set; }
        public Nullable<decimal> Value6BeforeRate { get; set; }
        public Nullable<decimal> Value7 { get; set; }
        public Nullable<decimal> Value7BeforeRate { get; set; }
        public Nullable<decimal> Value8 { get; set; }
        public Nullable<decimal> Value8BeforeRate { get; set; }
        public Nullable<decimal> Value9 { get; set; }
        public Nullable<decimal> Value9BeforeRate { get; set; }
        public Nullable<decimal> Value10 { get; set; }
        public Nullable<decimal> Value10BeforeRate { get; set; }
        public string Equation { get; set; }
        public string CheckNumber { get; set; }
        public string BankAccNumber { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<System.DateTime> PaidDate { get; set; }
        public Nullable<byte> CheckType { get; set; }
        public string strCustm1 { get; set; }
        public string strCustm2 { get; set; }
        public string Remarks { get; set; }
        public string AddField3 { get; set; }
        public string AddField4 { get; set; }
        public string AddField5 { get; set; }
        public string AddField6 { get; set; }
        public string AddField7 { get; set; }
        public Nullable<bool> IsPrinted { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public Nullable<bool> IsPettyCash { get; set; }
        public Nullable<int> CheqBookId { get; set; }
        public Nullable<int> NoteNum { get; set; }
        public Nullable<bool> IsKembiala { get; set; }
        public Nullable<bool> Closed { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public Nullable<System.DateTime> UncloseDate { get; set; }
        public Nullable<int> ClosedBy { get; set; }
        public Nullable<int> UnclosedBy { get; set; }
        public Nullable<bool> IsPosted { get; set; }
        public string Postedby { get; set; }
        public Nullable<System.DateTime> PostedDate { get; set; }
        public Nullable<decimal> TotalInvoices { get; set; }
        public Nullable<decimal> NotPaidInvoices { get; set; }
        public Nullable<decimal> DifferenceInvoices { get; set; }
        public Nullable<decimal> ResourceBalance { get; set; }
        public Nullable<bool> IsPaid { get; set; }
        public Nullable<int> PaidDocId { get; set; }
        public Nullable<decimal> NotPaid { get; set; }
        public Nullable<int> TermCostCenterId { get; set; }
        public Nullable<decimal> TermCostCenterValue { get; set; }
        public Nullable<decimal> TotalItems { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
    }
}
