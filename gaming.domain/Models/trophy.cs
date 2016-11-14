using System;
using System.Collections.Generic;

namespace gaming.data.Models
{
    public partial class trophy
    {
        public long idTrophy { get; set; }
        public string date { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string gamer_idGamer { get; set; }
   //     public virtual user user { get; set; }
    }
}
