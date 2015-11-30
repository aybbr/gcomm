using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class notificationMap : EntityTypeConfiguration<notification>
    {
        public notificationMap()
        {
            // Primary Key
            this.HasKey(t => t.idNotif);

            // Properties
            this.Property(t => t.idNotif)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("notification", "gcommunitydb");
            this.Property(t => t.idNotif).HasColumnName("idNotif");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.etat).HasColumnName("etat");
            this.Property(t => t.activeMember_id).HasColumnName("activeMember_id");
            this.Property(t => t.message_fk).HasColumnName("message_fk");

            // Relationships
            this.HasOptional(t => t.message)
                .WithMany(t => t.notifications)
                .HasForeignKey(d => d.message_fk);
            this.HasOptional(t => t.simplemember)
                .WithMany(t => t.notifications)
                .HasForeignKey(d => d.activeMember_id);

        }
    }
}
