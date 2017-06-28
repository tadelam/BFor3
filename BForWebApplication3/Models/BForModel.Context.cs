﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<CalendarDate> CalendarDates { get; set; }
        public virtual DbSet<Calendar> Calendars { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyUserNotifyType> CompanyUserNotifyTypes { get; set; }
        public virtual DbSet<CompanyUser> CompanyUsers { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DriverLicens> DriverLicenses { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<LineObject> LineObjects { get; set; }
        public virtual DbSet<LineRoute> LineRoutes { get; set; }
        public virtual DbSet<Line> Lines { get; set; }
        public virtual DbSet<LineSchedule> LineSchedules { get; set; }
        public virtual DbSet<LineService> LineServices { get; set; }
        public virtual DbSet<ObjectTypeGroup> ObjectTypeGroups { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<RideObject> RideObjects { get; set; }
        public virtual DbSet<RideRoute> RideRoutes { get; set; }
        public virtual DbSet<Ride> Rides { get; set; }
        public virtual DbSet<RideServiceObjectPrice> RideServiceObjectPrices { get; set; }
        public virtual DbSet<RideService> RideServices { get; set; }
        public virtual DbSet<RideStatus> RideStatuses { get; set; }
        public virtual DbSet<RideTypeService> RideTypeServices { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ServiceTariff> ServiceTariffs { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Sys_CompanyTypes> Sys_CompanyTypes { get; set; }
        public virtual DbSet<Sys_ContactTypes> Sys_ContactTypes { get; set; }
        public virtual DbSet<Sys_Currencies> Sys_Currencies { get; set; }
        public virtual DbSet<Sys_Distances> Sys_Distances { get; set; }
        public virtual DbSet<Sys_DriverTypes> Sys_DriverTypes { get; set; }
        public virtual DbSet<Sys_Languages> Sys_Languages { get; set; }
        public virtual DbSet<Sys_LicenseTypes> Sys_LicenseTypes { get; set; }
        public virtual DbSet<Sys_LineAccesskeys> Sys_LineAccesskeys { get; set; }
        public virtual DbSet<Sys_NotifyTypes> Sys_NotifyTypes { get; set; }
        public virtual DbSet<Sys_ObjectTypes> Sys_ObjectTypes { get; set; }
        public virtual DbSet<Sys_RideStatuses> Sys_RideStatuses { get; set; }
        public virtual DbSet<Sys_RideTypes> Sys_RideTypes { get; set; }
        public virtual DbSet<Sys_Services> Sys_Services { get; set; }
        public virtual DbSet<Sys_SysItems> Sys_SysItems { get; set; }
        public virtual DbSet<Sys_UnitGroups> Sys_UnitGroups { get; set; }
        public virtual DbSet<Sys_Units> Sys_Units { get; set; }
        public virtual DbSet<Sys_VehicleBrands> Sys_VehicleBrands { get; set; }
        public virtual DbSet<Sys_VehicleTypeLicenseTypes> Sys_VehicleTypeLicenseTypes { get; set; }
        public virtual DbSet<Sys_VehicleTypes> Sys_VehicleTypes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Z_Hazmanot> Z_Hazmanot { get; set; }
        public virtual DbSet<Z_Lakohot> Z_Lakohot { get; set; }
        public virtual DbSet<Z_Nesiot> Z_Nesiot { get; set; }
        public virtual DbSet<Z_Sapakim> Z_Sapakim { get; set; }
    }
}
