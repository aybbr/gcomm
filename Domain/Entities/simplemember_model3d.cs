using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class simplemember_model3d
    {
        public int simpleMember_id { get; set; }
        public int model3Ds_id { get; set; }
        public int simpleMembers_id { get; set; }
        public virtual model3d model3d { get; set; }
        public virtual simplemember simplemember { get; set; }
        public virtual simplemember simplemember1 { get; set; }
    }
}
