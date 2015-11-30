using Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class simplememberMap : EntityTypeConfiguration<simplemember>
    {
        public simplememberMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.DTYPE)
                .IsRequired()
                .HasMaxLength(31);

            this.Property(t => t.email)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.password)
                .HasMaxLength(255);

            this.Property(t => t.server)
                .HasMaxLength(255);

            this.Property(t => t.summonerName)
                .HasMaxLength(255);

            this.Property(t => t.surname)
                .HasMaxLength(255);

            this.Property(t => t.username)
                .HasMaxLength(255);

            this.Property(t => t.role)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("simplemember", "gcommunitydb");
            this.Property(t => t.DTYPE).HasColumnName("DTYPE");
            this.Property(t => t.Id).HasColumnName("id");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.server).HasColumnName("server");
            this.Property(t => t.summonerName).HasColumnName("summonerName");
            this.Property(t => t.surname).HasColumnName("surname");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.xp).HasColumnName("xp");
            this.Property(t => t.approved).HasColumnName("approved");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.role).HasColumnName("role");
            this.Property(t => t.membership_id).HasColumnName("membership_id");

            // Relationships
            this.HasMany(t => t.equipments)
                .WithMany(t => t.simplemembers)
                .Map(m =>
                    {
                        m.ToTable("simplemember_equipment", "gcommunitydb");
                        m.MapLeftKey("activeMembers_id");
                        m.MapRightKey("equipments_id");
                    });

            this.HasMany(t => t.news)
                .WithMany(t => t.simplemembers)
                .Map(m =>
                    {
                        m.ToTable("simplemember_news", "gcommunitydb");
                        m.MapLeftKey("activeMembers_id");
                        m.MapRightKey("news_id");
                    });

            this.HasOptional(t => t.membership)
                .WithMany(t => t.simplemembers)
                .HasForeignKey(d => d.membership_id);

        }
    }
}
