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
    
    public partial class Vehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicle()
        {
            this.Drivers = new HashSet<Driver>();
            this.LineSchedules = new HashSet<LineSchedule>();
        }
    
        public int VehicleID { get; set; }
        public string PlatNo { get; set; }
        public int CompanyID { get; set; }
        public int BrandID { get; set; }
        public string Model { get; set; }
        public Nullable<long> Year { get; set; }
        public Nullable<long> EngineCC { get; set; }
        public Nullable<int> VehicleTypeID { get; set; }
        public Nullable<System.DateTime> LicenseDate { get; set; }
        public Nullable<System.DateTime> InsuranceDate { get; set; }
        public int CompanyObjectTypeGroupID { get; set; }
        public Nullable<int> MainDriverID { get; set; }
        public Nullable<int> RelationshipID { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Driver Driver { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Driver> Drivers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LineSchedule> LineSchedules { get; set; }
        public virtual ObjectTypeGroup ObjectTypeGroup { get; set; }
        public virtual Sys_VehicleBrands Sys_VehicleBrands { get; set; }
        public virtual Sys_VehicleTypes Sys_VehicleTypes { get; set; }
    }
}
