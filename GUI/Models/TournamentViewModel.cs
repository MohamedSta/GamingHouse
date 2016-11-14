using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUI.Models
{
    public class TournamentViewModel
    {
        public long idtournament { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string date { get; set; }
        public string ImageUrl { get; set; }
        public string lieu { get; set; }
    }
}