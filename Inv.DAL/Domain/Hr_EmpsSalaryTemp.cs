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
    
    public partial class Hr_EmpsSalaryTemp
    {
        public int EmpsSalaryTempId { get; set; }
        public Nullable<int> SalaryTypId { get; set; }
        public Nullable<int> EmpId { get; set; }
        public Nullable<int> JobId { get; set; }
        public Nullable<int> DepartMentId { get; set; }
        public Nullable<int> HREmpGroupId { get; set; }
        public Nullable<int> StoreId { get; set; }
        public Nullable<decimal> SalaryValu { get; set; }
        public Nullable<int> DebitAccId { get; set; }
        public Nullable<int> CreditAccId { get; set; }
        public Nullable<int> DebitCostCenterId { get; set; }
        public Nullable<int> CreditCostCenterId { get; set; }
        public Nullable<int> DebitEmpAccountId { get; set; }
        public Nullable<int> CreditEmpAccountId { get; set; }
    }
}
