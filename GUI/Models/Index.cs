using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GUI.Models
{
    public class Index
    {
        public long idEvent { get; set; }
        public long idNews { get; set; }
        public long idT { get; set; }
        public DateTime DatePub { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public string Ntitle { get; set; }
        public string Etitle { get; set; }

        public string Image { get; set; }

        public string Pic { get; set; }
        public string ImageUrl { get; set; }
    }
}