using System;
using System.Collections.Generic;

namespace gaming.data.Models
{
    public partial class post
    {
        public post()
        {
            this.comments = new List<comment>();
        }

        public long idPost { get; set; }
        public string contents { get; set; }
        public string gamer_idGamer { get; set; }
        public virtual ICollection<comment> comments { get; set; }
     //   public virtual user user { get; set; }
    }
}
