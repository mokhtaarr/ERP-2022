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
    
    public partial class MS_ItemCategory
    {
        public int ItemCategoryId { get; set; }
        public string ItemCatCode { get; set; }
        public string ItemCatDescA { get; set; }
        public string ItemCatDescE { get; set; }
        public Nullable<int> ParentItemCategoryId { get; set; }
        public Nullable<byte> ItemCategoryType { get; set; }
        public Nullable<int> ItemCategoryCatLevel { get; set; }
        public byte[] CategoryImage { get; set; }
        public Nullable<int> CurrentTrNo { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
    }
}
