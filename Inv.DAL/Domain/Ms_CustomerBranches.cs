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
    
    public partial class Ms_CustomerBranches
    {
        public int CustBranchId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string CustBranchCode { get; set; }
        public string CustBranchName1 { get; set; }
        public string CustBranchName2 { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> CityID { get; set; }
        public string Address { get; set; }
    }
}