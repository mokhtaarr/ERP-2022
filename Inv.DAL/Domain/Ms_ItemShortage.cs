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
    
    public partial class Ms_ItemShortage
    {
        public int ItemShortId { get; set; }
        public Nullable<int> ItemCardId { get; set; }
        public Nullable<int> UnitId { get; set; }
        public Nullable<decimal> RequestedQuantity { get; set; }
        public Nullable<decimal> UnitRate { get; set; }
        public Nullable<decimal> RequestedQtyBeforeRate { get; set; }
        public Nullable<int> InvId { get; set; }
        public Nullable<System.DateTime> TrDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
    }
}