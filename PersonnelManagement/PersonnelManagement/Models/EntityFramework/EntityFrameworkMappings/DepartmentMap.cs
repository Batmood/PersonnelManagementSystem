using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace PersonnelManagement.Models.EntityFramework.EntityFrameworkMappings
{
    public class DepartmentMap: EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            this.HasKey(d => d.Id);

            this.Property(d => d.Name).HasMaxLength(50);


            this.ToTable("Department");

        }
    }
}