using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class simplemember_tutorialMap : EntityTypeConfiguration<simplemember_tutorial>
    {
        public simplemember_tutorialMap()
        {
            // Primary Key
            this.HasKey(t => new { t.simpleMember_id, t.tutorials_id, t.simpleMembers_id });

            // Properties
            this.Property(t => t.simpleMember_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tutorials_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.simpleMembers_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("simplemember_tutorial", "gcommunitydb");
            this.Property(t => t.simpleMember_id).HasColumnName("simpleMember_id");
            this.Property(t => t.tutorials_id).HasColumnName("tutorials_id");
            this.Property(t => t.simpleMembers_id).HasColumnName("simpleMembers_id");

            // Relationships
            this.HasRequired(t => t.simplemember)
                .WithMany(t => t.simplemember_tutorial)
                .HasForeignKey(d => d.simpleMembers_id);
            this.HasRequired(t => t.simplemember1)
                .WithMany(t => t.simplemember_tutorial1)
                .HasForeignKey(d => d.simpleMember_id);
            this.HasRequired(t => t.tutorial)
                .WithMany(t => t.simplemember_tutorial)
                .HasForeignKey(d => d.tutorials_id);

        }
    }
}
