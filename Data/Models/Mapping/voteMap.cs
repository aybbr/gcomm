using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class voteMap : EntityTypeConfiguration<vote>
    {
        public voteMap()
        {
            // Primary Key
            this.HasKey(t => new { t.voted, t.voter });

            // Properties
            this.Property(t => t.voted)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.voter)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vote", "gcommunitydb");
            this.Property(t => t.voted).HasColumnName("voted");
            this.Property(t => t.voter).HasColumnName("voter");
            this.Property(t => t.year).HasColumnName("year");

            // Relationships
            this.HasRequired(t => t.simplemember)
                .WithMany(t => t.votes)
                .HasForeignKey(d => d.voter);
            this.HasRequired(t => t.simplemember1)
                .WithMany(t => t.votes1)
                .HasForeignKey(d => d.voted);

        }
    }
}
