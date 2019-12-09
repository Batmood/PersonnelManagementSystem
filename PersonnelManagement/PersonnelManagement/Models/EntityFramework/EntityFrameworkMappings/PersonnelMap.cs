using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace PersonnelManagement.Models.EntityFramework
{
    public class PersonnelMap : EntityTypeConfiguration<Personnel>
    {
        public PersonnelMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).IsRequired();
            this.Property(p => p.Name).HasMaxLength(50);
            this.Property(p => p.LastName).HasMaxLength(50);

            this.ToTable("Personnel");


        }
    }
}
