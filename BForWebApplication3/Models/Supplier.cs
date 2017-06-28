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
    
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            this.Drivers = new HashSet<Driver>();
            this.Suppliers1 = new HashSet<Supplier>();
        }
    
        public int SupplierID { get; set; }
        public int CompanyAID { get; set; }
        public Nullable<int> CompanyBID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> ObjectTypeGroupID { get; set; }
        public Nullable<int> MainSupplierID { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Company Company1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Driver> Drivers { get; set; }
        public virtual ObjectTypeGroup ObjectTypeGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supplier> Suppliers1 { get; set; }
        public virtual Supplier Supplier1 { get; set; }
    }
}
