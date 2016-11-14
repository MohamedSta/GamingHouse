using System;
using System.Collections.Generic;

namespace gaming.data.Models
{
    public partial class comment
    {
        public long idComment { get; set; }
        public string contents { get; set; }
        public Nullable<long> post_idPost { get; set; }
        public virtual post post { get; set; }
    }
}
