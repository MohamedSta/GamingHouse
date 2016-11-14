using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GUI.Models
{
    public class NewsViewModel
    {

        public long idNews { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public string Image { get; set; }
        public DateTime DatePub { get; set; }

    }
}