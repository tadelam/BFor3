//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BForWebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RideServiceObjectPrice
    {
        public int RideObjectID { get; set; }
        public int RideServiceID { get; set; }
        public int RideID { get; set; }
        public double Percentage { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual RideObject RideObject { get; set; }
        public virtual Ride Ride { get; set; }
        public virtual RideService RideService { get; set; }
    }
}
