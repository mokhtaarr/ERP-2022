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
    
    public partial class MS_VendorCategory
    {
        public int VendorCatId { get; set; }
        public string CatCode { get; set; }
        public string CatDescA { get; set; }
        public string CatDescE { get; set; }
        public Nullable<int> ParentVendorCatId { get; set; }
        public Nullable<int> VendorCatParent { get; set; }
        public Nullable<int> VendorCatLevel { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
    }
}
