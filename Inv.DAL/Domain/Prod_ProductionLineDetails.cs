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
    
    public partial class Prod_ProductionLineDetails
    {
        public int ProdLineDetailId { get; set; }
        public Nullable<int> ProLineId { get; set; }
        public Nullable<int> TaskId { get; set; }
        public Nullable<decimal> TimeBeforFormat { get; set; }
        public Nullable<byte> TimeUnit { get; set; }
        public Nullable<decimal> Minutes { get; set; }
        public Nullable<decimal> Hours { get; set; }
        public Nullable<decimal> Days { get; set; }
        public Nullable<decimal> Months { get; set; }
        public string Remarks { get; set; }
    }
}
