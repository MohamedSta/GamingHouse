using gaming.data.Models;
using gaming.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class StatController : Controller
    {   // GET: Chart
        INewsService service = null;
        string moix1 = (DateTime.Now.Month - 3).ToString();
        string moix2 = (DateTime.Now.Month - 2).ToString();
        string moix3 = (DateTime.Now.Month - 1).ToString();
        string moix4 = (DateTime.Now.Month ).ToString();


        public StatController()
        {
            service = new NewsService();
        }

        public ActionResult Index()
        {
            Dictionary<string, double> dictNews = new Dictionary<string, double>()
            {
                { "newss",0}
            };
            ViewBag.PercentageNews = dictNews;

            IEnumerable<news> totalNews = service.GetMany();

            //ViewBag.totalMateriels = totalMateriels;


            if (totalNews.Count() != 0)
            {
                //ViewBag.idM = totalMateriels;
                ViewBag.PercentageNews = getDescriptionNews(totalNews);
                //Debug.WriteLine("aaaa "+ViewBag.PercentageMateriels["materiels"]);
            }

            return View();
        }


        private Dictionary<string, double> getDescriptionNews(IEnumerable<news> news)
        {
            int sizeNews = news.Count();
            IEnumerable<news> moix1 = news.Where(t => t.DatePub.Month == (DateTime.Now.Month - 3));
            IEnumerable<news> Imprimante = news.Where(t => t.DatePub.Month == (DateTime.Now.Month - 2));
            IEnumerable<news> FAX = news.Where(t => t.DatePub.Month == (DateTime.Now.Month - 1));
            IEnumerable<news> Chaise = news.Where(t => t.DatePub.Month == (DateTime.Now.Month));

            double tauxPC = Math.Round((double)(moix1.Count() * 100 / sizeNews));
            double tauxImprimante = Math.Round((double)(Imprimante.Count() * 100 / sizeNews));
            double tauxFAX = Math.Round((double)(FAX.Count() * 100 / sizeNews));
            double tauxChaise = Math.Round((double)(Chaise.Count() * 100 / sizeNews));
            return new Dictionary<string, double>
            {
                {"news",sizeNews },
                {"moix1",tauxPC },
                {"imprimante",tauxImprimante },
                {"fax",tauxFAX },
                {"chaise",tauxChaise }
            };


        }
    }
}