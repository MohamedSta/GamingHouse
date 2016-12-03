using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUI.Models
{
    public class EventViewModel
    {


        public decimal idEvent { get; set; }
        public DateTime dateEvent { get; set; }
        public string Etitle { get; set; }
        public string type { get; set; }
        public string Pic { get; set; }
        public string lieu { get; set; }
      

        //// foreign key
        //public int? idGame { get; set; } // ? nullable
        //public IEnumerable<SelectListItem> Games { get; set; }


    }
}