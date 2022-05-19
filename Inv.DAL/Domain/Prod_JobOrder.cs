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
    
    public partial class Prod_JobOrder
    {
        public int JobOrderId { get; set; }
        public Nullable<int> JOrderTypeId { get; set; }
        public Nullable<int> TermId { get; set; }
        public Nullable<int> BookId { get; set; }
        public Nullable<int> StoreId { get; set; }
        public Nullable<int> ItemCardId { get; set; }
        public Nullable<int> ItemAtrribBatchId { get; set; }
        public Nullable<int> AccountId { get; set; }
        public Nullable<int> InDirectExpensesAccountId { get; set; }
        public Nullable<int> CostCenterId { get; set; }
        public Nullable<int> CostCenterId2 { get; set; }
        public Nullable<int> PurInvId { get; set; }
        public Nullable<int> AId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<int> DepartMentId { get; set; }
        public Nullable<int> FinancialIntervalsId { get; set; }
        public Nullable<int> UnitId { get; set; }
        public Nullable<decimal> UnitRate { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<int> TrNo { get; set; }
        public string ManualTrNo { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public Nullable<System.DateTime> TrDate { get; set; }
        public Nullable<byte> OrderSource { get; set; }
        public Nullable<byte> OrderType { get; set; }
        public Nullable<byte> Priority { get; set; }
        public Nullable<byte> OrderStatus { get; set; }
        public Nullable<bool> Installation { get; set; }
        public string RefOrder { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public string Remarks { get; set; }
        public Nullable<decimal> ProducedQty { get; set; }
        public Nullable<decimal> TotalItemCost { get; set; }
        public Nullable<decimal> TotalTasksCose { get; set; }
        public Nullable<decimal> TotalJobsCost { get; set; }
        public Nullable<decimal> TotalEquipCost { get; set; }
        public Nullable<decimal> TotalExpensesCost { get; set; }
        public Nullable<decimal> CustomerCharged { get; set; }
        public Nullable<decimal> NetExpenses { get; set; }
        public Nullable<decimal> TotalPurchInvCost { get; set; }
        public Nullable<decimal> TotalServices { get; set; }
        public Nullable<decimal> TotalJpbOrder { get; set; }
        public Nullable<decimal> TotalProductsPrice { get; set; }
        public Nullable<decimal> TotalGoStock { get; set; }
        public Nullable<decimal> TotalScrap { get; set; }
        public Nullable<decimal> InstallationPrice { get; set; }
        public Nullable<decimal> DiscPercent { get; set; }
        public Nullable<decimal> DiscAmount { get; set; }
        public Nullable<decimal> TotalMaterialCostEstimate { get; set; }
        public Nullable<decimal> TotalGoStockCostEstimate { get; set; }
        public Nullable<decimal> TotalScrapCostEstimate { get; set; }
        public Nullable<decimal> TotalProductCostEstimate { get; set; }
        public Nullable<decimal> TotalEquipCostEstimate { get; set; }
        public Nullable<decimal> TotalJobsCostEstimate { get; set; }
        public Nullable<decimal> TotalExpensCostEstimate { get; set; }
        public Nullable<bool> IsDeliveredGoStock { get; set; }
        public Nullable<bool> IsDeliveredProducts { get; set; }
        public Nullable<bool> IsDeliveredScrap { get; set; }
        public Nullable<bool> IsDeliveredMaterial { get; set; }
        public Nullable<bool> IsPaid { get; set; }
        public Nullable<int> PaidDocId { get; set; }
        public Nullable<decimal> NotPaid { get; set; }
        public Nullable<decimal> TotalProducedMeter { get; set; }
        public Nullable<int> TermCostCenterId { get; set; }
        public Nullable<decimal> TermCostCenterValue { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
    }
}