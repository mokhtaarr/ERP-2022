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
    
    public partial class Sr_Flight
    {
        public int FlightId { get; set; }
        public Nullable<int> TripId { get; set; }
        public string FlightCompany { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> Departure { get; set; }
        public Nullable<System.DateTime> Arrival { get; set; }
        public Nullable<int> TrafficLineId { get; set; }
        public Nullable<int> CityIDFrom { get; set; }
        public Nullable<int> CityIDTo { get; set; }
        public string PlaceFrom { get; set; }
        public string PlaceTo { get; set; }
        public string Remarks { get; set; }
    }
}
