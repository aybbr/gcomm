using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class streamMap : EntityTypeConfiguration<stream>
    {
        public streamMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.winner)
                .HasMaxLength(255);

            this.Property(t => t.url)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("streams", "gcommunitydb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.date_diffusion).HasColumnName("date_diffusion");
            this.Property(t => t.viewers).HasColumnName("viewers");
            this.Property(t => t.winner).HasColumnName("winner");
            this.Property(t => t.url).HasColumnName("url");
        }
    }
}
