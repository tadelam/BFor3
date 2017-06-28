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
    
    public partial class CompanyUser
    {
        public int CompanyUserID { get; set; }
        public int CompanyAID { get; set; }
        public int ObjectTypeID { get; set; }
        public int ObjectID { get; set; }
        public Nullable<int> CompanyBID { get; set; }
        public Nullable<int> UserID { get; set; }
        public int RoleID { get; set; }
        public System.Guid Token { get; set; }
        public System.DateTime TokenDT { get; set; }
        public System.DateTime TokenExpirationDT { get; set; }
        public Nullable<System.DateTime> TokenApprovedDT { get; set; }
        public Nullable<bool> NotifyByEmail { get; set; }
        public string NotifyByEmailTiming { get; set; }
        public Nullable<System.TimeSpan> NotifyByEmailAt { get; set; }
        public string NotifyBySMS { get; set; }
        public string NotifyByAlert { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Company Company1 { get; set; }
        public virtual Role Role { get; set; }
        public virtual Sys_ObjectTypes Sys_ObjectTypes { get; set; }
        public virtual User User { get; set; }
    }
}