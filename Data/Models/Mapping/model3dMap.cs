using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class model3dMap : EntityTypeConfiguration<model3d>
    {
        public model3dMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.img)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("model3d", "gcommunitydb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.datePost).HasColumnName("datePost");
            this.Property(t => t.img).HasColumnName("img");
            this.Property(t => t.name).HasColumnName("name");
        }
    }
}
