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
    
    public partial class Stock_OpenningBalanceDetails
    {
        public int StockOpenDetailId { get; set; }
        public Nullable<int> StockOpenId { get; set; }
        public Nullable<int> StockId { get; set; }
        public Nullable<int> StockCurrencyId { get; set; }
        public Nullable<decimal> CurrencyRate { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<decimal> TotalPriceLocal { get; set; }
    }
}
