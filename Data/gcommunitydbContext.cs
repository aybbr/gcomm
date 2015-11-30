using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Data.Models.Mapping;
using Domain.Entities;

namespace Data
{
    public partial class gcommunitydbContext : DbContext
    {
        static gcommunitydbContext()
        {
            Database.SetInitializer<gcommunitydbContext>(null);
        }

        public gcommunitydbContext()
            : base("Name=gcommunitydbContext")
        {
        }

        public DbSet<equipment> equipments { get; set; }
        public DbSet<Event> events { get; set; }
        public DbSet<membership> memberships { get; set; }
        public DbSet<message> messages { get; set; }
        public DbSet<model3d> model3d { get; set; }
        public DbSet<news> news { get; set; }
        public DbSet<notification> notifications { get; set; }
        public DbSet<pack> packs { get; set; }
        public DbSet<simplemember> simplemembers { get; set; }
        public DbSet<simplemember_model3d> simplemember_model3d { get; set; }
        public DbSet<simplemember_packs> simplemember_packs { get; set; }
        public DbSet<simplemember_streams> simplemember_streams { get; set; }
        public DbSet<simplemember_tutorial> simplemember_tutorial { get; set; }
        public DbSet<sponsor> sponsors { get; set; }
        public DbSet<stream> streams { get; set; }
        public DbSet<tutorial> tutorials { get; set; }
        public DbSet<vote> votes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new equipmentMap());
            modelBuilder.Configurations.Add(new eventMap());
            modelBuilder.Configurations.Add(new membershipMap());
            modelBuilder.Configurations.Add(new messageMap());
            modelBuilder.Configurations.Add(new model3dMap());
            modelBuilder.Configurations.Add(new newsMap());
            modelBuilder.Configurations.Add(new notificationMap());
            modelBuilder.Configurations.Add(new packMap());
            modelBuilder.Configurations.Add(new simplememberMap());
            modelBuilder.Configurations.Add(new simplemember_model3dMap());
            modelBuilder.Configurations.Add(new simplemember_packsMap());
            modelBuilder.Configurations.Add(new simplemember_streamsMap());
            modelBuilder.Configurations.Add(new simplemember_tutorialMap());
            modelBuilder.Configurations.Add(new sponsorMap());
            modelBuilder.Configurations.Add(new streamMap());
            modelBuilder.Configurations.Add(new tutorialMap());
            modelBuilder.Configurations.Add(new voteMap());
        }
    }
}
