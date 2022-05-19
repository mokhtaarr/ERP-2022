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
    
    public partial class Stock_Stocks
    {
        public int StockId { get; set; }
        public string Code { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Symbol { get; set; }
        public string SymbolAr { get; set; }
        public Nullable<decimal> SharePercent { get; set; }
        public Nullable<int> StockMarketId { get; set; }
        public Nullable<int> StockSectorsId { get; set; }
        public Nullable<int> StockCatId { get; set; }
        public Nullable<int> CurrencyId { get; set; }
        public Nullable<System.DateTime> FinancialEndDate { get; set; }
        public Nullable<bool> Listed { get; set; }
        public Nullable<decimal> StockPrice { get; set; }
        public string ZakatOnInvest { get; set; }
        public string IslamicCompatibility { get; set; }
        public string DocType { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string WebSite { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> LastMemberDate { get; set; }
        public Nullable<System.DateTime> NextMemberDate { get; set; }
        public Nullable<System.DateTime> EstablishDate { get; set; }
        public Nullable<System.DateTime> MarketListDate { get; set; }
        public Nullable<decimal> PaidCapital { get; set; }
        public Nullable<decimal> StockNameValue { get; set; }
        public Nullable<int> StockIssuesNo { get; set; }
        public Nullable<int> StockCurrentNo { get; set; }
        public Nullable<int> StockTreasuryNo { get; set; }
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