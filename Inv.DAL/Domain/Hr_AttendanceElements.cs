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
    
    public partial class Hr_AttendanceElements
    {
        public int AttendElementId { get; set; }
        public string ElementCode { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string UnitDescription { get; set; }
        public Nullable<decimal> FixedValue { get; set; }
        public Nullable<byte> ValueType { get; set; }
        public Nullable<byte> ElementUsage { get; set; }
        public Nullable<byte> VacationEffect { get; set; }
        public Nullable<bool> EnablEditOnEmpActivity { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
    }
}
