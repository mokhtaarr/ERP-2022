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
    
    public partial class Sr_TrafficLines
    {
        public int TrafficLineId { get; set; }
        public string TrafficCode { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string TrafficFrom { get; set; }
        public string TrafficTo { get; set; }
        public Nullable<int> CityIDFrom { get; set; }
        public Nullable<int> CityIDTo { get; set; }
        public Nullable<int> FromHarborId { get; set; }
        public Nullable<int> ToHarborId { get; set; }
        public Nullable<decimal> KM { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<bool> PricebyContainer { get; set; }
        public Nullable<bool> PricebyVehicl { get; set; }
        public Nullable<decimal> EstimatCost { get; set; }
        public Nullable<bool> CostbyContainer { get; set; }
        public Nullable<bool> CostbyVehicl { get; set; }
        public string Remark { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
    }
}