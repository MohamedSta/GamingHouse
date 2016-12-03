
using gaming.service;
using GUI.Models;

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
            IList<Index> IN = new List<Index>();
            foreach (var item in events)
            {
                IN.Add(
                    new Index
                    {
                        Pic = "/content/Upload/" + item.Pic,
                        Etitle = item.Etitle,
                        idEvent = item.idEvent

                    });
            }
            foreach (var item in newss)
            {
                IN.Add(
                    new Index
                    {
                        description = item.description,
                        DatePub = item.DatePub,
                        Image = "/content/Upload/" + item.Image,
                        Ntitle = item.title,
                        idNews = item.idNews

                    });
            }
            foreach (var item in trnmss)
            {
                IN.Add(
                    new Index
                    {
                        ImageUrl = "/content/Upload/" + item.ImageUrl,
                        title = item.title,
                        idT = item.idtournament
                    });
            }




            return View(IN);
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