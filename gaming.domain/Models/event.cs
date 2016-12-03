using System;
using System.Collections.Generic;

namespace gaming.data.Models
{
    public partial class Event
    {
        public Event()
        {
          //  this.users = new List<user>();
        }

        public long idEvent { get; set; }
      
        public DateTime dateEvent { get; set; }
        public string Etitle { get; set; }
        public string type { get; set; }
        public string Pic { get; set; }
        public string lieu { get; set; }
      
        //  public virtual ICollection<user> users { get; set; }
    }
}
