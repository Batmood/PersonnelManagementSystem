using PersonnelManagement.Models.EntityFramework.EntityFrameworkMappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PersonnelManagement.Models.EntityFramework
{
    public class PersonnelContext : DbContext
    {
        public PersonnelContext():base("PersonnelMngConStr")
        {
            Database.SetInitializer(new DataInitilaizer());
        }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonnelMap());
            modelBuilder.Configurations.Add(new DepartmentMap());
        }

    }

}