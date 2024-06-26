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
    
    public partial class MS_PurchaseInvoiceItemCard
    {
        public int InvItemCardId { get; set; }
        public Nullable<int> PurInvId { get; set; }
        public Nullable<int> ItemCardId { get; set; }
        public Nullable<int> ItemAtrribBatchId { get; set; }
        public Nullable<int> StoreId { get; set; }
        public Nullable<int> StorePartId { get; set; }
        public Nullable<int> CityIDFrom { get; set; }
        public Nullable<int> CityIDTo { get; set; }
        public Nullable<int> ItemIdToFollow { get; set; }
        public Nullable<int> FollowCollectionId { get; set; }
        public Nullable<int> LotNumberExpiryId { get; set; }
        public Nullable<int> TaxesId1 { get; set; }
        public Nullable<byte> Tax1Style { get; set; }
        public Nullable<bool> Tax1IsAccomulative { get; set; }
        public Nullable<bool> Tax1PlusOrMinus { get; set; }
        public Nullable<decimal> Tax1Percent { get; set; }
        public Nullable<decimal> TaxValue1 { get; set; }
        public Nullable<int> TaxesId2 { get; set; }
        public Nullable<byte> Tax2Style { get; set; }
        public Nullable<bool> Tax2IsAccomulative { get; set; }
        public Nullable<bool> Tax2PlusOrMinus { get; set; }
        public Nullable<decimal> Tax2Percent { get; set; }
        public Nullable<decimal> TaxValue2 { get; set; }
        public Nullable<int> TaxesId3 { get; set; }
        public Nullable<byte> Tax3Style { get; set; }
        public Nullable<bool> Tax3IsAccomulative { get; set; }
        public Nullable<bool> Tax3PlusOrMinus { get; set; }
        public Nullable<decimal> Tax3Percent { get; set; }
        public Nullable<decimal> TaxValue3 { get; set; }
        public Nullable<int> ScaleCardId { get; set; }
        public Nullable<int> UnitId { get; set; }
        public Nullable<decimal> UnitRate { get; set; }
        public Nullable<byte> ItemType { get; set; }
        public Nullable<int> PayId { get; set; }
        public Nullable<int> VJOrderId { get; set; }
        public Nullable<int> StockRecId { get; set; }
        public string BarCode { get; set; }
        public string BatchNumberFifoOrLifo { get; set; }
        public Nullable<decimal> QuantityRecieved { get; set; }
        public Nullable<decimal> QtyRecievedBeforRate { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> QtyBeforRate { get; set; }
        public Nullable<decimal> ReturnQty { get; set; }
        public Nullable<decimal> ReturnQtyBeforRate { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> PriceAfterRate { get; set; }
        public Nullable<decimal> DisAmount { get; set; }
        public Nullable<decimal> DisPercent { get; set; }
        public Nullable<decimal> DisAmountAfterRate { get; set; }
        public Nullable<decimal> MainDiscPercent { get; set; }
        public Nullable<decimal> MainDiscValue { get; set; }
        public Nullable<decimal> TaxableValue { get; set; }
        public Nullable<decimal> FIFOCost { get; set; }
        public Nullable<decimal> FIFOCostUnit { get; set; }
        public Nullable<decimal> LIFOCost { get; set; }
        public Nullable<decimal> LIFOCostUnit { get; set; }
        public Nullable<decimal> CoastAverage { get; set; }
        public Nullable<decimal> CoastAverageUnit { get; set; }
        public Nullable<bool> IsCollection { get; set; }
        public Nullable<decimal> ExpenseShare { get; set; }
        public Nullable<decimal> ExpenseShareUnit { get; set; }
        public Nullable<decimal> PriceAfterExpense { get; set; }
        public Nullable<decimal> PriceAfterExpenseUnit { get; set; }
        public Nullable<decimal> PriceAfterCurr { get; set; }
        public Nullable<decimal> PriceAfterCurrUnit { get; set; }
        public Nullable<decimal> ExpenseShareAfterCurr { get; set; }
        public Nullable<decimal> ExpenseShareAfterCurrUnit { get; set; }
        public Nullable<decimal> PriceAfterExpenseAfterCurr { get; set; }
        public Nullable<decimal> PriceAfterExpensAfterCurrUnit { get; set; }
        public string Remarks { get; set; }
        public string Remarks1 { get; set; }
        public string Remarks2 { get; set; }
        public string Remarks3 { get; set; }
        public string ItemCardDesc { get; set; }
        public string ItemCardDescE { get; set; }
        public Nullable<bool> PriceIncludTaxInPurch { get; set; }
        public Nullable<int> IsNoCostDeliver { get; set; }
        public Nullable<bool> DeliverNoCostExecut { get; set; }
        public Nullable<int> AId { get; set; }
        public string DBTableName { get; set; }
        public Nullable<int> DBTableId { get; set; }
        public string AccountTableName { get; set; }
        public Nullable<byte> RectSourceType { get; set; }
        public Nullable<int> AccountId { get; set; }
        public Nullable<int> RectSourceTypeId { get; set; }
        public Nullable<int> StockRecItemCardId { get; set; }
        public Nullable<decimal> ExecutedQty { get; set; }
        public Nullable<decimal> QtyIUnit2 { get; set; }
        public Nullable<decimal> ServicePrice { get; set; }
        public Nullable<decimal> ProfitPrice { get; set; }
        public Nullable<decimal> Kirat { get; set; }
        public Nullable<int> VehicleId { get; set; }
        public Nullable<decimal> QtyBeforDiscount { get; set; }
        public Nullable<decimal> QtyDiscount { get; set; }
        public Nullable<decimal> QualityDiscount { get; set; }
        public Nullable<decimal> QualityValueDisc { get; set; }
        public Nullable<decimal> QtyScalDiffrence { get; set; }
        public Nullable<decimal> QtyScalDiffrenceValue { get; set; }
        public byte[] LastUpdateTime { get; set; }
        public Nullable<int> MainServerId { get; set; }
        public Nullable<int> ServerUnitId { get; set; }
        public Nullable<int> ServerItemCardId { get; set; }
    }
}
