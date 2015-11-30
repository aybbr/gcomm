using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class simplemember_streams
    {
        public int activeMembers_id { get; set; }
        public int streamsss_id { get; set; }
        public int simpleMember_id { get; set; }
        public int streamss_id { get; set; }
        public int simpleMembers_id { get; set; }
        public virtual simplemember simplemember { get; set; }
        public virtual simplemember simplemember1 { get; set; }
        public virtual simplemember simplemember2 { get; set; }
        public virtual stream stream { get; set; }
        public virtual stream stream1 { get; set; }
    }
}
