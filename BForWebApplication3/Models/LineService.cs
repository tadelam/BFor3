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
    
    public partial class LineService
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LineService()
        {
            this.LineRoutes = new HashSet<LineRoute>();
        }
    
        public int LineServiceID { get; set; }
        public int LineID { get; set; }
        public int ServiceID { get; set; }
        public string FromServiceUnit { get; set; }
        public string ToServiceUnit { get; set; }
        public int ServiceUnitID { get; set; }
        public double ServiceUnitQuantity { get; set; }
        public string ServiceDetails { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LineRoute> LineRoutes { get; set; }
        public virtual Line Line { get; set; }
        public virtual Sys_Services Sys_Services { get; set; }
        public virtual Sys_Units Sys_Units { get; set; }
    }
}
