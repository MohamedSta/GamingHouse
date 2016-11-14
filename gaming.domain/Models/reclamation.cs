using System;
using System.Collections.Generic;

namespace gaming.data.Models
{
    public partial class reclamation
    {
        public long idReclam { get; set; }
        public string content { get; set; }
        public string subject { get; set; }
        public string title { get; set; }
        public string admin_idAdmin { get; set; }
      //  public virtual user user { get; set; }
    }
}
