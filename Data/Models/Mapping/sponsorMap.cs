using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class sponsorMap : EntityTypeConfiguration<sponsor>
    {
        public sponsorMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.contribution)
                .HasMaxLength(255);

            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.level)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("sponsor", "gcommunitydb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.contribution).HasColumnName("contribution");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.level).HasColumnName("level");

            // Relationships
            this.HasMany(t => t.simplemembers)
                .WithMany(t => t.sponsors)
                .Map(m =>
                    {
                        m.ToTable("simplemember_sponsor", "gcommunitydb");
                        m.MapLeftKey("sponsors_id");
                        m.MapRightKey("activeMembers_id");
                    });


        }
    }
}
