using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gaming.domain.Models
{
    public partial class tournament
    {
        //constructeur
       
        public tournament() { }
        public long idtournament { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string date { get; set; }
        public string ImageUrl { get; set; }
        public string lieu { get; set; }
    }

}
