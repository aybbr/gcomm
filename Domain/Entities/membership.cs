using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class membership
    {
        public membership()
        {
            this.simplemembers = new List<simplemember>();
        }

        public int id { get; set; }
        public Nullable<float> fee { get; set; }
        public virtual ICollection<simplemember> simplemembers { get; set; }
    }
}
