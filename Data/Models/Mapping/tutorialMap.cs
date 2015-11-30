using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class tutorialMap : EntityTypeConfiguration<tutorial>
    {
        public tutorialMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("tutorial", "gcommunitydb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.rate).HasColumnName("rate");
            this.Property(t => t.tutolev).HasColumnName("tutolev");
            this.Property(t => t.simplemember_id).HasColumnName("simplemember_id");

            // Relationships
            this.HasOptional(t => t.simplemember)
                .WithMany(t => t.tutorials)
                .HasForeignKey(d => d.simplemember_id);

        }
    }
}
