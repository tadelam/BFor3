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
    
    public partial class LineSchedule
    {
        public int LineID { get; set; }
        public bool IsInSunday { get; set; }
        public bool IsInMonday { get; set; }
        public bool IsInTuesday { get; set; }
        public bool IsInWednesday { get; set; }
        public bool IsInThursday { get; set; }
        public bool IsInFriday { get; set; }
        public bool IsInSaturday { get; set; }
        public System.TimeSpan ApprearanceTime { get; set; }
        public System.TimeSpan FromTime { get; set; }
        public System.TimeSpan ToTime { get; set; }
        public int DriverID { get; set; }
        public int VehicleID { get; set; }
        public int EscortID { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Driver Driver { get; set; }
        public virtual Passenger Passenger { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
