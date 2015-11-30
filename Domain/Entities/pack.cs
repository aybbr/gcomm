using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class pack
    {
        public pack()
        {
            this.simplemember_packs = new List<simplemember_packs>();
        }

        public int id { get; set; }
        public string category { get; set; }
        public Nullable<System.DateTime> datemiseenligne { get; set; }
        public string name { get; set; }
        public Nullable<float> price { get; set; }
        public Nullable<int> quantity { get; set; }
        public virtual ICollection<simplemember_packs> simplemember_packs { get; set; }
    }
}
