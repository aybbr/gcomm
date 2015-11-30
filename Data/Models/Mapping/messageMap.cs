using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class messageMap : EntityTypeConfiguration<message>
    {
        public messageMap()
        {
            // Primary Key
            this.HasKey(t => t.idMessage);

            // Properties
            this.Property(t => t.idMessage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.content)
                .HasMaxLength(255);

            this.Property(t => t.subject)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("message", "gcommunitydb");
            this.Property(t => t.idMessage).HasColumnName("idMessage");
            this.Property(t => t.content).HasColumnName("content");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.subject).HasColumnName("subject");
            this.Property(t => t.activeMember_id).HasColumnName("activeMember_id");
            this.Property(t => t.idto).HasColumnName("idto");

            // Relationships
            this.HasOptional(t => t.simplemember)
                .WithMany(t => t.messages)
                .HasForeignKey(d => d.activeMember_id);

        }
    }
}
