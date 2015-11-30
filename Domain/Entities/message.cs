using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class message
    {
        public message()
        {
            this.notifications = new List<notification>();
        }

        public int idMessage { get; set; }
        public string content { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string subject { get; set; }
        public Nullable<int> activeMember_id { get; set; }
        public int idto { get; set; }
        public virtual simplemember simplemember { get; set; }
        public virtual ICollection<notification> notifications { get; set; }
    }
}
