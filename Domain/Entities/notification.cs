using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class notification
    {
        public int idNotif { get; set; }
        public string description { get; set; }
        public int etat { get; set; }
        public Nullable<int> activeMember_id { get; set; }
        public Nullable<int> message_fk { get; set; }
        public virtual message message { get; set; }
        public virtual simplemember simplemember { get; set; }
    }
}
