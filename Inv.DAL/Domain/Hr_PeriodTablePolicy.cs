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
    
    public partial class Hr_PeriodTablePolicy
    {
        public int PeriodPolicyId { get; set; }
        public Nullable<int> PeriodTableId { get; set; }
        public Nullable<int> AttendElementId { get; set; }
        public Nullable<byte> AttendUnit { get; set; }
        public Nullable<decimal> Approximate { get; set; }
        public Nullable<decimal> Minimum { get; set; }
    }
}