using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class simplemember_packsMap : EntityTypeConfiguration<simplemember_packs>
    {
        public simplemember_packsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.simpleMember_id, t.packss_id, t.simpleMembers_id });

            // Properties
            this.Property(t => t.simpleMember_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.packss_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.simpleMembers_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("simplemember_packs", "gcommunitydb");
            this.Property(t => t.simpleMember_id).HasColumnName("simpleMember_id");
            this.Property(t => t.packss_id).HasColumnName("packss_id");
            this.Property(t => t.simpleMembers_id).HasColumnName("simpleMembers_id");

            // Relationships
            this.HasRequired(t => t.pack)
                .WithMany(t => t.simplemember_packs)
                .HasForeignKey(d => d.packss_id);
            this.HasRequired(t => t.simplemember)
                .WithMany(t => t.simplemember_packs)
                .HasForeignKey(d => d.simpleMember_id);
            this.HasRequired(t => t.simplemember1)
                .WithMany(t => t.simplemember_packs1)
                .HasForeignKey(d => d.simpleMembers_id);

        }
    }
}
