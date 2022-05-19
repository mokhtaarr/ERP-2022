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
    
    public partial class Sr_ShippingDeclaration
    {
        public int ShipDeclarId { get; set; }
        public Nullable<int> RoqId { get; set; }
        public Nullable<int> AId { get; set; }
        public Nullable<int> StoreId { get; set; }
        public Nullable<int> BookId { get; set; }
        public Nullable<int> TermId { get; set; }
        public Nullable<int> FinancialIntervalsId { get; set; }
        public Nullable<int> TrNo { get; set; }
        public string ManualTrNo { get; set; }
        public Nullable<System.DateTime> TrDate { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> ValidityDays { get; set; }
        public string Shipper { get; set; }
        public string Consignee { get; set; }
        public string VesselName { get; set; }
        public string PortOfLoading { get; set; }
        public string PortOfDischarge { get; set; }
        public string FreightPayableAt { get; set; }
        public string BillOfLading { get; set; }
        public string Notify { get; set; }
        public string MarksAndNumbers { get; set; }
        public string Remarks { get; set; }
        public string ContainersDRY { get; set; }
        public string NetWeightTons { get; set; }
        public string GrossWeightTons { get; set; }
        public string AddField1 { get; set; }
        public string AddField2 { get; set; }
        public string AddField3 { get; set; }
        public string AddField4 { get; set; }
        public Nullable<bool> IsPosted { get; set; }
        public string Postedby { get; set; }
        public Nullable<System.DateTime> PostedDate { get; set; }
        public Nullable<bool> Closed { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public Nullable<System.DateTime> UncloseDate { get; set; }
        public Nullable<int> ClosedBy { get; set; }
        public Nullable<int> UnclosedBy { get; set; }
        public Nullable<int> PermPrinted { get; set; }
        public Nullable<System.DateTime> PermPrintedAt { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
    }
}