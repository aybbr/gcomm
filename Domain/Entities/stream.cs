using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class stream
    {
        public stream()
        {
            this.simplemember_streams = new List<simplemember_streams>();
            this.simplemember_streams1 = new List<simplemember_streams>();
        }

        public int id { get; set; }
        public Nullable<System.DateTime> date_diffusion { get; set; }
        public Nullable<int> viewers { get; set; }
        public string winner { get; set; }
        public string url { get; set; }
        public virtual ICollection<simplemember_streams> simplemember_streams { get; set; }
        public virtual ICollection<simplemember_streams> simplemember_streams1 { get; set; }
    }
}
