using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class sponsor
    {
        public sponsor()
        {
            this.simplemembers = new List<simplemember>();
        }

        public int id { get; set; }
        public string contribution { get; set; }
        public string description { get; set; }
        public string level { get; set; }
        public virtual ICollection<simplemember> simplemembers { get; set; }
    }
}
