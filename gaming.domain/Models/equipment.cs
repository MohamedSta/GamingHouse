using System;
using System.Collections.Generic;

namespace gaming.data.Models
{
    public partial class equipment
    {
        public equipment()
        {
      //      this.users = new List<user>();
        }

        public long idEquipments { get; set; }
        public string name { get; set; }
        public string quantity { get; set; }
        public string type { get; set; }
      //  public virtual ICollection<user> users { get; set; }
    }
}
