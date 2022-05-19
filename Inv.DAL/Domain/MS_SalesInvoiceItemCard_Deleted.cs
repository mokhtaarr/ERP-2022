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
    
    public partial class MS_SalesInvoiceItemCard_Deleted
    {
        public int DelInvItemcardId { get; set; }
        public int InvItemCardId { get; set; }
        public Nullable<int> InvId { get; set; }
        public Nullable<int> ItemCardId { get; set; }
        public Nullable<int> ItemAtrribBatchId { get; set; }
        public Nullable<int> StoreId { get; set; }
        public Nullable<int> StorePartId { get; set; }
        public Nullable<int> AlterToItemCardId { get; set; }
        public Nullable<int> CollectToItemCardId { get; set; }
        public Nullable<int> AlterTo { get; set; }
        public Nullable<int> LotNumberExpiryId { get; set; }
        public Nullable<int> TaxesId1 { get; set; }
        public Nullable<decimal> TaxValue1 { get; set; }
        public Nullable<int> TaxesId2 { get; set; }
        public Nullable<decimal> TaxValue2 { get; set; }
        public Nullable<int> TaxesId3 { get; set; }
        public Nullable<decimal> TaxValue3 { get; set; }
        public Nullable<int> UnitId { get; set; }
        public Nullable<decimal> UnitRate { get; set; }
        public Nullable<byte> ItemType { get; set; }
        public string BarCode { get; set; }
        public string BatchNumberFifoOrLifo { get; set; }
        public string LotNumberExpiry { get; set; }
        public Nullable<System.DateTime> ProductionDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> QtyBeforRate { get; set; }
        public Nullable<decimal> QuantityOut { get; set; }
        public Nullable<decimal> QtyOutBeforRate { get; set; }
        public Nullable<decimal> ReturnQty { get; set; }
        public Nullable<decimal> ReturnQtyBeforRate { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> PriceAfterRate { get; set; }
        public Nullable<decimal> DisAmount { get; set; }
        public Nullable<decimal> DisPercent { get; set; }
        public Nullable<decimal> DisAmountAfterRate { get; set; }
        public Nullable<decimal> FIFOCost { get; set; }
        public Nullable<decimal> FIFOCostUnit { get; set; }
        public Nullable<decimal> LIFOCost { get; set; }
        public Nullable<decimal> LIFOCostUnit { get; set; }
        public Nullable<decimal> CoastAverage { get; set; }
        public Nullable<decimal> CoastAverageUnit { get; set; }
        public Nullable<decimal> LastCost { get; set; }
        public Nullable<decimal> LastCostUnit { get; set; }
        public string Remarks { get; set; }
        public string Remarks1 { get; set; }
        public string Remarks2 { get; set; }
        public string Remarks3 { get; set; }
        public string ItemCardDesc { get; set; }
        public string ItemCardDescE { get; set; }
        public Nullable<bool> IsBonus { get; set; }
        public Nullable<bool> IsCollection { get; set; }
        public Nullable<int> FollowCollectionId { get; set; }
        public Nullable<int> ItemIdToFollow { get; set; }
        public Nullable<bool> AddOrEditMode { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
        public Nullable<bool> DeletedOrChanged { get; set; }
    }
}