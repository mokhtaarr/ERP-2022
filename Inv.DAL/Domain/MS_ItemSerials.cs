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
    
    public partial class MS_ItemSerials
    {
        public int ItemSerialId { get; set; }
        public Nullable<int> ItemCardId { get; set; }
        public string SRNo1 { get; set; }
        public string SRNo2 { get; set; }
        public string SRNo3 { get; set; }
        public string SRNo4 { get; set; }
        public string SRNo5 { get; set; }
        public Nullable<int> PurInvId { get; set; }
        public Nullable<int> RetPurchId { get; set; }
        public Nullable<int> InvId { get; set; }
        public Nullable<int> RetSaleId { get; set; }
        public Nullable<int> StockRecId { get; set; }
        public Nullable<int> DeliverId { get; set; }
        public Nullable<int> TranId { get; set; }
        public Nullable<int> SalesOrderId { get; set; }
        public Nullable<int> StockAdjustId { get; set; }
        public Nullable<int> TranReqId { get; set; }
        public Nullable<int> PurInvItemCardId { get; set; }
        public Nullable<int> InvItemCardId { get; set; }
        public Nullable<int> DelivItemCardId { get; set; }
        public Nullable<int> StockAdjustItemId { get; set; }
        public Nullable<int> OrderDetailItemCardId { get; set; }
        public Nullable<int> RetPurchItemCardId { get; set; }
        public Nullable<int> RetItemCardId { get; set; }
        public Nullable<int> StockRecItemCardId { get; set; }
        public Nullable<int> TrItenCardId { get; set; }
        public Nullable<int> TranReqItemCardId { get; set; }
        public Nullable<System.DateTime> WarrantyStrtDate { get; set; }
        public Nullable<System.DateTime> WarrantyEndDate { get; set; }
        public Nullable<bool> IsInOrOut { get; set; }
        public Nullable<int> StorePartId { get; set; }
        public Nullable<int> LotNumberExpiryId { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
    }
}