using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class simplemember_tutorial
    {
        public int simpleMember_id { get; set; }
        public int tutorials_id { get; set; }
        public int simpleMembers_id { get; set; }
        public virtual simplemember simplemember { get; set; }
        public virtual simplemember simplemember1 { get; set; }
        public virtual tutorial tutorial { get; set; }
    }
}
