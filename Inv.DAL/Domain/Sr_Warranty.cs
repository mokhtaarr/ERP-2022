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
    
    public partial class Sr_Warranty
    {
        public int WId { get; set; }
        public string WCode { get; set; }
        public string WName1 { get; set; }
        public string WName2 { get; set; }
        public string WConditions { get; set; }
        public Nullable<byte> WMethod { get; set; }
        public Nullable<int> WPeriodMonths { get; set; }
        public Nullable<int> WDistance { get; set; }
        public Nullable<bool> WUse { get; set; }
        public Nullable<bool> Exemption { get; set; }
        public Nullable<byte> ExemptionPercnt { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
    }
}
