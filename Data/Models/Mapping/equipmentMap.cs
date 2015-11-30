using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models.Mapping
{
    public class equipmentMap : EntityTypeConfiguration<equipment>
    {
        public equipmentMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.reference)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("equipment", "gcommunitydb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.reference).HasColumnName("reference");
            this.Property(t => t.state).HasColumnName("state");
        }
    }
}
