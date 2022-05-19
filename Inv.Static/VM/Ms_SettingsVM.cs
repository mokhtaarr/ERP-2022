﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inv.Static.VM
{
    public class Ms_SettingsVM
    {
        public int SettingId { get; set; }
        public Nullable<bool> ExpUseColor { get; set; }
        public Nullable<int> ExpPeriod { get; set; }
        public Nullable<bool> chekAlert { get; set; }
        public Nullable<bool> ItemLimitAlert { get; set; }
        public Nullable<bool> ItemMaxAlert { get; set; }
        public Nullable<bool> AlertCustCredit { get; set; }
        public Nullable<bool> AlertVendCredit { get; set; }
        public Nullable<int> AlertTimeOut { get; set; }
        public Nullable<bool> CustCodOrNam { get; set; }
        public Nullable<bool> VendCodOrNam { get; set; }
        public Nullable<bool> PartCodOrNam { get; set; }
        public Nullable<byte> AccountsDecimals { get; set; }
        public Nullable<byte> QuantityDicimals { get; set; }
        public Nullable<byte> PriceDicimals { get; set; }
        public Nullable<byte> CostDicimals { get; set; }
        public Nullable<byte> ValuesDicimals { get; set; }
        public Nullable<byte> PercentDicimals { get; set; }
        public Nullable<byte> DimensionDicimals { get; set; }
        public Nullable<byte> TimeDecimals { get; set; }
        public Nullable<bool> UseBarCodes { get; set; }
        public Nullable<bool> UseBasicOrAlterBarcod { get; set; }
        public Nullable<bool> UseSerialNumber { get; set; }
        public Nullable<bool> UseExpirySystem { get; set; }
        public Nullable<bool> UseExpiryDateColumn { get; set; }
        public Nullable<bool> UseProducDateColumn { get; set; }
        public Nullable<bool> UseLotNumberColumn { get; set; }
        public Nullable<bool> UseAlterItems { get; set; }
        public Nullable<bool> UseAttributes { get; set; }
        public Nullable<bool> UseHightColumn { get; set; }
        public Nullable<bool> UseWidthColumn { get; set; }
        public Nullable<bool> UseLengthColumn { get; set; }
        public Nullable<bool> UseUnitColumn { get; set; }
        public Nullable<bool> UseBrancheCodeColumn { get; set; }
        public Nullable<bool> UseBrancheNameColumn { get; set; }
        public Nullable<bool> UsePartitionCodeColumn { get; set; }
        public Nullable<bool> UsePartitionNameColumn { get; set; }
        public Nullable<byte> NoOfItemRemarksFields { get; set; }
        public string ItemCostAffectDoc { get; set; }
        public string SalesReturnItemCost { get; set; }
        public string PurchReturnItemCost { get; set; }
        public Nullable<byte> AskForAttachMove { get; set; }
        public string AttachmentPath { get; set; }
        public Nullable<bool> UseWeightCardSystem { get; set; }
        public Nullable<bool> UseCurrency { get; set; }
        public Nullable<bool> UseHijiryDate { get; set; }
        public string SysDateFormat { get; set; }
        public Nullable<bool> ScaleAutoRead { get; set; }
        public string ScaleAppPath { get; set; }
        public string ScaleDataPath { get; set; }
        public Nullable<byte> ItemIssueCostMethod { get; set; }
        public Nullable<byte> ItemIssueWhichCost { get; set; }
        public Nullable<bool> UseFinancialQtyOnly { get; set; }
        public Nullable<bool> UseSimpleExpirySystem { get; set; }
        public Nullable<bool> UseComposItem { get; set; }
        public Nullable<bool> HideDeletedDocs { get; set; }
        public Nullable<bool> HideCustBranch { get; set; }
        public Nullable<bool> HideCurrency { get; set; }
        public Nullable<bool> HideSalesMan { get; set; }
        public Nullable<bool> HideMoneyCollector { get; set; }
        public Nullable<bool> DistDiscOnJobOrderItems { get; set; }
        public Nullable<bool> UseSalesJobOrders { get; set; }
        public Nullable<bool> UseItemTaxInPurch { get; set; }
        public Nullable<bool> UseItemTaxInSales { get; set; }
        public Nullable<bool> UseAnalyticalCode { get; set; }
        public Nullable<bool> UseShipping { get; set; }
        public Nullable<bool> UseVehicles { get; set; }
        public Nullable<int> ItemDefTax { get; set; }
        public Nullable<bool> PriceIncludTaxInSales { get; set; }
        public Nullable<bool> PriceIncludTaxInPurch { get; set; }
        public Nullable<bool> SearchItemWithQtySales { get; set; }
        public Nullable<bool> UseCatCodInItems { get; set; }
        public string ItemSeparator { get; set; }
        public Nullable<bool> UseCatCodInCust { get; set; }
        public string CustSeparator { get; set; }
        public Nullable<bool> UseCatCodInVend { get; set; }
        public string VendSeparator { get; set; }
    }
}