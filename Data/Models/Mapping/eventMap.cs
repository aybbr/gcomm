using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class eventMap : EntityTypeConfiguration<Event>
    {
        public eventMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.lieu)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("event", "gcommunitydb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.fee).HasColumnName("fee");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.numberOfParticipants).HasColumnName("numberOfParticipants");
            this.Property(t => t.lieu).HasColumnName("lieu");
            this.Property(t => t.numberOfPlaces).HasColumnName("numberOfPlaces");

            // Relationships
            this.HasMany(t => t.simplemembers)
                .WithMany(t => t.events)
                .Map(m =>
                    {
                        m.ToTable("simplemember_event", "gcommunitydb");
                        m.MapLeftKey("events_id");
                        m.MapRightKey("simpleMember_id");
                    });


        }
    }
}
