using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class equipment
    {
        public equipment()
        {
            this.simplemembers = new List<simplemember>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public string reference { get; set; }
        public Nullable<bool> state { get; set; }
        public virtual ICollection<simplemember> simplemembers { get; set; }
    }
}
