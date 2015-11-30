using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class simplemember_model3dMap : EntityTypeConfiguration<simplemember_model3d>
    {
        public simplemember_model3dMap()
        {
            // Primary Key
            this.HasKey(t => new { t.simpleMember_id, t.model3Ds_id, t.simpleMembers_id });

            // Properties
            this.Property(t => t.simpleMember_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.model3Ds_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.simpleMembers_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("simplemember_model3d", "gcommunitydb");
            this.Property(t => t.simpleMember_id).HasColumnName("simpleMember_id");
            this.Property(t => t.model3Ds_id).HasColumnName("model3Ds_id");
            this.Property(t => t.simpleMembers_id).HasColumnName("simpleMembers_id");

            // Relationships
            this.HasRequired(t => t.model3d)
                .WithMany(t => t.simplemember_model3d)
                .HasForeignKey(d => d.model3Ds_id);
            this.HasRequired(t => t.simplemember)
                .WithMany(t => t.simplemember_model3d)
                .HasForeignKey(d => d.simpleMember_id);
            this.HasRequired(t => t.simplemember1)
                .WithMany(t => t.simplemember_model3d1)
                .HasForeignKey(d => d.simpleMembers_id);

        }
    }
}
