using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class news
    {
        public news()
        {
            this.simplemembers = new List<simplemember>();
        }

        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public virtual ICollection<simplemember> simplemembers { get; set; }
    }
}
