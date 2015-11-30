using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class model3d
    {
        public model3d()
        {
            this.simplemember_model3d = new List<simplemember_model3d>();
        }

        public int id { get; set; }
        public Nullable<System.DateTime> datePost { get; set; }
        public string img { get; set; }
        public string name { get; set; }
        public virtual ICollection<simplemember_model3d> simplemember_model3d { get; set; }
    }
}
