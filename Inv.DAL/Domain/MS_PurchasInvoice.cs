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
    
    public partial class MS_PurchasInvoice
    {
        public int PurInvId { get; set; }
        public Nullable<int> VendorId { get; set; }
        public Nullable<int> StorId { get; set; }
        public Nullable<int> PurOrderId { get; set; }
        public Nullable<int> PurOrderReqId { get; set; }
        public Nullable<int> BookId { get; set; }
        public Nullable<int> TermId { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<int> VendBranchId { get; set; }
        public Nullable<int> ExpensesId { get; set; }
        public Nullable<int> FinancialIntervalsId { get; set; }
        public string DBTableName { get; set; }
        public Nullable<int> DBTableId { get; set; }
        public string AccountTableName { get; set; }
        public Nullable<byte> RectSourceType { get; set; }
        public Nullable<int> AccountId { get; set; }
        public Nullable<int> TaxesId1 { get; set; }
        public Nullable<decimal> TaxValue1 { get; set; }
        public Nullable<int> TaxesId2 { get; set; }
        public Nullable<decimal> TaxValue2 { get; set; }
        public Nullable<int> TaxesId3 { get; set; }
        public Nullable<decimal> TaxValue3 { get; set; }
        public Nullable<int> AId { get; set; }
        public Nullable<int> TrNo { get; set; }
        public string ManualTrNo { get; set; }
        public Nullable<System.DateTime> TrDate { get; set; }
        public string InvDescA { get; set; }
        public string InvDescE { get; set; }
        public string Remarks { get; set; }
        public string AddField3 { get; set; }
        public string AddField4 { get; set; }
        public string AddField5 { get; set; }
        public string AddField6 { get; set; }
        public string AddField7 { get; set; }
        public Nullable<byte> InvoiceType { get; set; }
        public Nullable<System.DateTime> InvDueDate { get; set; }
        public Nullable<decimal> TotalItemTax1 { get; set; }
        public Nullable<decimal> TotalItemTax2 { get; set; }
        public Nullable<decimal> TotalItemTax3 { get; set; }
        public Nullable<decimal> TotalTaxValu { get; set; }
        public Nullable<decimal> InvTotal { get; set; }
        public Nullable<decimal> DiscPercent { get; set; }
        public Nullable<decimal> DiscAmount { get; set; }
        public Nullable<decimal> DiscPercent2 { get; set; }
        public Nullable<decimal> DiscAmount2 { get; set; }
        public Nullable<decimal> DiscPercent3 { get; set; }
        public Nullable<decimal> DiscAmount3 { get; set; }
        public Nullable<decimal> DiscPercent4 { get; set; }
        public Nullable<decimal> DiscAmount4 { get; set; }
        public Nullable<decimal> PriceAfterTax { get; set; }
        public Nullable<decimal> ExpenValue { get; set; }
        public Nullable<decimal> PaidPrice { get; set; }
        public Nullable<decimal> NetPrice { get; set; }
        public Nullable<decimal> PaidPriceVisa { get; set; }
        public Nullable<bool> Closed { get; set; }
        public Nullable<bool> IsPrinted { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<decimal> NetPriceBeforCurr { get; set; }
        public Nullable<decimal> ExpenValueBeforCurr { get; set; }
        public Nullable<decimal> ExpenValueWithCurr { get; set; }
        public Nullable<bool> IsDelivered { get; set; }
        public Nullable<bool> IsPosted { get; set; }
        public string Postedby { get; set; }
        public Nullable<System.DateTime> PostedDate { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public Nullable<System.DateTime> UncloseDate { get; set; }
        public Nullable<int> ClosedBy { get; set; }
        public Nullable<int> UnclosedBy { get; set; }
        public Nullable<int> PermPrinted { get; set; }
        public Nullable<System.DateTime> PermPrintedAt { get; set; }
        public Nullable<bool> IsPaid { get; set; }
        public Nullable<int> PaidDocId { get; set; }
        public Nullable<decimal> NotPaid { get; set; }
        public Nullable<int> TermCostCenterId { get; set; }
        public Nullable<decimal> TermCostCenterValue { get; set; }
        public Nullable<bool> IsShippingInv { get; set; }
        public Nullable<int> IsNoCostDeliver { get; set; }
        public Nullable<bool> DeliverNoCostExecut { get; set; }
        public Nullable<bool> MultiResourceDeliver { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
        public Nullable<decimal> AdvancExpenseWithCurr { get; set; }
        public Nullable<decimal> AdvancExpenseBeforCurr { get; set; }
        public Nullable<bool> EtaxSent { get; set; }
        public Nullable<System.DateTime> EtaxSentTime { get; set; }
        public string EtaxRemarks { get; set; }
        public string EtaxReference { get; set; }
        public Nullable<bool> IsReturned { get; set; }
        public Nullable<int> ShiftId { get; set; }
        public byte[] LastUpdateTime { get; set; }
        public Nullable<bool> IsRemoteEntity { get; set; }
        public Nullable<int> RemotId { get; set; }
        public Nullable<int> MainVendServerId { get; set; }
    }
}
