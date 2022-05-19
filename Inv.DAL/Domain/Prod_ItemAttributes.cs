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
    
    public partial class Prod_ItemAttributes
    {
        public int AttributId { get; set; }
        public string AttributCode { get; set; }
        public string AttributName1 { get; set; }
        public string AttributName2 { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsMandatory { get; set; }
        public Nullable<byte> Dimension { get; set; }
        public Nullable<bool> IsFixedMenuValues { get; set; }
        public Nullable<bool> IsOptionalWithAlarm { get; set; }
        public Nullable<int> BasUnitId { get; set; }
        public Nullable<byte> DataType { get; set; }
        public Nullable<decimal> MinValu { get; set; }
        public Nullable<decimal> MaxValu { get; set; }
        public Nullable<decimal> IncrementalValu { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
    }
}