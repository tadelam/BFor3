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
    
    public partial class RideTypeService
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RideTypeService()
        {
            this.ServiceTariffs = new HashSet<ServiceTariff>();
        }
    
        public int RideTypeServiceID { get; set; }
        public int CompanyID { get; set; }
        public int RideTypeID { get; set; }
        public int ServiceID { get; set; }
        public bool IsMandatory { get; set; }
    
        public virtual Company Company { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceTariff> ServiceTariffs { get; set; }
        public virtual Sys_RideTypes Sys_RideTypes { get; set; }
        public virtual Sys_Services Sys_Services { get; set; }
    }
}