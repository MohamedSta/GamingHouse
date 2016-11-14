using System;
using System.Collections.Generic;

namespace gaming.data.Models
{
    public partial class news
    {
        public news()
        {
      //      this.users = new List<user>();
        }

        public long idNews { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public string Image{ get; set; }

        public DateTime DatePub { get; set; }
        //   public virtual ICollection<user> users { get; set; }
    }
}
