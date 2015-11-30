using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class vote
    {
        public int voted { get; set; }
        public int voter { get; set; }
        public Nullable<int> year { get; set; }
        public virtual simplemember simplemember { get; set; }
        public virtual simplemember simplemember1 { get; set; }
    }
}
