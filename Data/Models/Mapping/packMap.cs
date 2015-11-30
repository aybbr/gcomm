using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class packMap : EntityTypeConfiguration<pack>
    {
        public packMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.category)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("packs", "gcommunitydb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.category).HasColumnName("category");
            this.Property(t => t.datemiseenligne).HasColumnName("datemiseenligne");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.quantity).HasColumnName("quantity");
        }
    }
}
