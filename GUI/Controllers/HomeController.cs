using gaming.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class HomeController : Controller
        

    {


        IEventService Eservice = null;
        INewsService Nservice = null;
        ITournamentService Tservice = null;

        public HomeController()
        {
            Tservice = new TournamentService();
            Eservice = new EventService();
            Nservice = new NewsService();
        }

        public ActionResult Index()
        {
            var events = Eservice.GetMany();
            var newss = Nservice.GetMany();
            var trnmss = Tservice.GetMany();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}