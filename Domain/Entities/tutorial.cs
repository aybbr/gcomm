using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class tutorial
    {
        public tutorial()
        {
            this.simplemember_tutorial = new List<simplemember_tutorial>();
        }

        public int id { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public Nullable<int> rate { get; set; }
        public Nullable<int> tutolev { get; set; }
        public Nullable<int> simplemember_id { get; set; }
        public virtual simplemember simplemember { get; set; }
        public virtual ICollection<simplemember_tutorial> simplemember_tutorial { get; set; }
    }
}
