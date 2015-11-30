using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class simplemember_streamsMap : EntityTypeConfiguration<simplemember_streams>
    {
        public simplemember_streamsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.activeMembers_id, t.streamsss_id, t.simpleMember_id, t.streamss_id, t.simpleMembers_id });

            // Properties
            this.Property(t => t.activeMembers_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.streamsss_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.simpleMember_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.streamss_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.simpleMembers_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("simplemember_streams", "gcommunitydb");
            this.Property(t => t.activeMembers_id).HasColumnName("activeMembers_id");
            this.Property(t => t.streamsss_id).HasColumnName("streamsss_id");
            this.Property(t => t.simpleMember_id).HasColumnName("simpleMember_id");
            this.Property(t => t.streamss_id).HasColumnName("streamss_id");
            this.Property(t => t.simpleMembers_id).HasColumnName("simpleMembers_id");

            // Relationships
            this.HasRequired(t => t.simplemember)
                .WithMany(t => t.simplemember_streams)
                .HasForeignKey(d => d.simpleMembers_id);
            this.HasRequired(t => t.simplemember1)
                .WithMany(t => t.simplemember_streams1)
                .HasForeignKey(d => d.activeMembers_id);
            this.HasRequired(t => t.simplemember2)
                .WithMany(t => t.simplemember_streams2)
                .HasForeignKey(d => d.simpleMember_id);
            this.HasRequired(t => t.stream)
                .WithMany(t => t.simplemember_streams)
                .HasForeignKey(d => d.streamss_id);
            this.HasRequired(t => t.stream1)
                .WithMany(t => t.simplemember_streams1)
                .HasForeignKey(d => d.streamsss_id);

        }
    }
}
