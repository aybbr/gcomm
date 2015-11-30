namespace PiDev_GCommunity_GUI.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using PiDev_GCommunity.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PiDev_GCommunity.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "PiDev_GCommunity.Models.ApplicationDbContext";
        }

        protected override void Seed(PiDev_GCommunity.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            // seed roles
            var store = new RoleStore<IdentityRole>(context);
            var manager = new RoleManager<IdentityRole>(store);
            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var role = new IdentityRole { Name = "Admin" };
                manager.Create(role);
            }
            if (!context.Roles.Any(r => r.Name == "ContentAdmin"))
            {
                var role = new IdentityRole { Name = "ContentAdmin" };
                manager.Create(role);
            }
            if (!context.Roles.Any(r => r.Name == "User"))
            {
                var role = new IdentityRole { Name = "User" };
                manager.Create(role);
            }

            // seed users
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);
            if (!(context.Users.Any(u => u.UserName == "ayoub.briki@gmail.com")))
            {
                var userToInsert = new ApplicationUser
                {
                    UserName = "ayoub.briki@gmail.com",
                    PhoneNumber = "+306940112629",
                    Email = "ayoub.briki@gmail.com",
                    EmailConfirmed = true,
                    TwoFactorEnabled = true
                };
                userManager.Create(userToInsert, "p@$$w0rd");

                userManager.AddToRole(userToInsert.Id, "Admin");
                userManager.AddToRole(userToInsert.Id, "ContentAdmin");
                userManager.AddToRole(userToInsert.Id, "User");
            }

            base.Seed(context);
        }
    }
}
