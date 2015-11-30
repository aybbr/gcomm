using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public partial class simplemember 
    {
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public int Id { get; set; }

        public string DTYPE { get; set; }
     
    
        public string email { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string server { get; set; }
        public string summonerName { get; set; }
        public string surname { get; set; }
        public string username { get; set; }
        public Nullable<double> xp { get; set; }
        public Nullable<bool> approved { get; set; }
        public Nullable<int> phone { get; set; }
        public string role { get; set; }
        public Nullable<int> membership_id { get; set; }
        public virtual membership membership { get; set; }
        public virtual ICollection<message> messages { get; set; }
        public virtual ICollection<notification> notifications { get; set; }
        public virtual ICollection<simplemember_streams> simplemember_streams { get; set; }
        public virtual ICollection<simplemember_packs> simplemember_packs { get; set; }
        public virtual ICollection<simplemember_streams> simplemember_streams1 { get; set; }
        public virtual ICollection<tutorial> tutorials { get; set; }
        public virtual ICollection<simplemember_model3d> simplemember_model3d { get; set; }
        public virtual ICollection<simplemember_tutorial> simplemember_tutorial { get; set; }
        public virtual ICollection<simplemember_model3d> simplemember_model3d1 { get; set; }
        public virtual ICollection<simplemember_packs> simplemember_packs1 { get; set; }
        public virtual ICollection<simplemember_streams> simplemember_streams2 { get; set; }
        public virtual ICollection<vote> votes { get; set; }
        public virtual ICollection<simplemember_tutorial> simplemember_tutorial1 { get; set; }
        public virtual ICollection<vote> votes1 { get; set; }
        public virtual ICollection<equipment> equipments { get; set; }
        public virtual ICollection<Event> events { get; set; }
        public virtual ICollection<news> news { get; set; }
        public virtual ICollection<sponsor> sponsors { get; set; }

   
        public simplemember()
        {
            this.messages = new List<message>();
            this.notifications = new List<notification>();
            this.simplemember_streams = new List<simplemember_streams>();
            this.simplemember_packs = new List<simplemember_packs>();
            this.simplemember_streams1 = new List<simplemember_streams>();
            this.tutorials = new List<tutorial>();
            this.simplemember_model3d = new List<simplemember_model3d>();
            this.simplemember_tutorial = new List<simplemember_tutorial>();
            this.simplemember_model3d1 = new List<simplemember_model3d>();
            this.simplemember_packs1 = new List<simplemember_packs>();
            this.simplemember_streams2 = new List<simplemember_streams>();
            this.votes = new List<vote>();
            this.simplemember_tutorial1 = new List<simplemember_tutorial>();
            this.votes1 = new List<vote>();
            this.equipments = new List<equipment>();
            this.events = new List<Event>();
            this.news = new List<news>();
            this.sponsors = new List<sponsor>();
        }

    }
}
