using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Event
    {
        public Event()
        {
            this.simplemembers = new List<simplemember>();
        }

        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string description { get; set; }
        public Nullable<double> fee { get; set; }
        public string name { get; set; }
        public int numberOfParticipants { get; set; }
        public string lieu { get; set; }
        public int numberOfPlaces { get; set; }
        public virtual ICollection<simplemember> simplemembers { get; set; }
    }
}
