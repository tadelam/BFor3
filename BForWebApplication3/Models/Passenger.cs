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
    
    public partial class Passenger
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Passenger()
        {
            this.LineSchedules = new HashSet<LineSchedule>();
            this.LineRoutes = new HashSet<LineRoute>();
            this.RideRoutes = new HashSet<RideRoute>();
        }
    
        public int PassengerID { get; set; }
        public int CompanyID { get; set; }
        public string EmploeeID { get; set; }
        public Nullable<System.DateTime> EmploeeFromDate { get; set; }
        public string FatherName { get; set; }
        public int Gender { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Title { get; set; }
        public int ObjectTypeGroupID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LineSchedule> LineSchedules { get; set; }
        public virtual ObjectTypeGroup ObjectTypeGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LineRoute> LineRoutes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RideRoute> RideRoutes { get; set; }
    }
}
