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
    
    public partial class Sys_UnitGroups
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sys_UnitGroups()
        {
            this.Sys_Units = new HashSet<Sys_Units>();
        }
    
        public int UnitGroupID { get; set; }
        public string UnitGroupDesc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Units> Sys_Units { get; set; }
    }
}
