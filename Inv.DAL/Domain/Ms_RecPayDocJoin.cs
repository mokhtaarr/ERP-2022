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
    
    public partial class Ms_RecPayDocJoin
    {
        public int InvRecPayId { get; set; }
        public Nullable<int> PayId { get; set; }
        public Nullable<int> RectId { get; set; }
        public Nullable<int> DocId { get; set; }
        public Nullable<byte> DocType { get; set; }
        public Nullable<decimal> Paid { get; set; }
        public Nullable<decimal> NotPaid { get; set; }
    }
}