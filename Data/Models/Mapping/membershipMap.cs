using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class membershipMap : EntityTypeConfiguration<membership>
    {
        public membershipMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("membership", "gcommunitydb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.fee).HasColumnName("fee");
        }
    }
}
