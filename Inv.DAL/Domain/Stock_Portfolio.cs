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
    
    public partial class Stock_Portfolio
    {
        public int StockPortfolioId { get; set; }
        public string Code { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public Nullable<int> PortfolioNo { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<int> StockBrokersId { get; set; }
        public Nullable<bool> ManagedByOthers { get; set; }
        public Nullable<bool> FollowOtherPortfolio { get; set; }
        public Nullable<decimal> StockBalance { get; set; }
        public Nullable<decimal> InvestBoxBalance { get; set; }
        public Nullable<decimal> CashBalance { get; set; }
        public Nullable<decimal> TotalBalance { get; set; }
        public string RemarksA { get; set; }
        public string RemarksE { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
    }
}
