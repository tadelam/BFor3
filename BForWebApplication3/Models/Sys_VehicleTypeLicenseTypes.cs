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
    
    public partial class Sys_VehicleTypeLicenseTypes
    {
        public int ComapnyID { get; set; }
        public int LicenseTypeID { get; set; }
        public int VehicleTypeID { get; set; }
    
        public virtual Sys_LicenseTypes Sys_LicenseTypes { get; set; }
        public virtual Sys_VehicleTypes Sys_VehicleTypes { get; set; }
    }
}
