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
    
    public partial class Proj_ReserveUnitSellers
    {
        public int ReservSellerId { get; set; }
        public Nullable<int> ReservId { get; set; }
        public Nullable<int> ResourceId { get; set; }
        public Nullable<bool> IsMainOwner { get; set; }
        public Nullable<byte> ResourceType { get; set; }
        public Nullable<int> ResourceAccountId { get; set; }
        public Nullable<int> HelpAccId { get; set; }
        public string HelpAccType { get; set; }
        public string AccountDescription { get; set; }
        public Nullable<decimal> ShareValue { get; set; }
        public Nullable<decimal> SharePercent { get; set; }
        public string Remarks1 { get; set; }
        public string Remarks2 { get; set; }
    }
}
