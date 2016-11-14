using System;
using System.Collections.Generic;

namespace gaming.data.Models
{
    public partial class schedule
    {
        public schedule()
        {
     //       this.users = new List<user>();
        }

        public long idSchedule { get; set; }
        public string dateSchedule { get; set; }
    //    public virtual ICollection<user> users { get; set; }
    }
}
