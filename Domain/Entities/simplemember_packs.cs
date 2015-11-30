using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class simplemember_packs
    {
        public int simpleMember_id { get; set; }
        public int packss_id { get; set; }
        public int simpleMembers_id { get; set; }
        public virtual pack pack { get; set; }
        public virtual simplemember simplemember { get; set; }
        public virtual simplemember simplemember1 { get; set; }
    }
}
