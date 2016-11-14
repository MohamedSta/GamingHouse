using gaming.data.Models;
using gaming.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class ChartController : Controller
    {


        // GET: Chart
        INewsService service = null;



        public ChartController()
        {
            service = new NewsService();
        }

        public ActionResult Index()
            {
                Dictionary<string, double> dictNews = new Dictionary<string, double>()
            {
                { "news",0}
            };
                ViewBag.PercentageNews = dictNews;

            IEnumerable<news> totalNews = service.GetMany();

                //ViewBag.totalNewsiels = totalNewsiels;


                if (totalNews.Count() != 0)
                {
                    //ViewBag.idM = totalNewsiels;
                    ViewBag.PercentageNews = getDescriptionNews(totalNews);
                    //Debug.WriteLine("aaaa "+ViewBag.Percentagenewsiels["newsiels"]);
                }

                return View();
            }


            private Dictionary<string, double> getDescriptionNews(IEnumerable<news> newsss)
            {
                int sizeNews = newsss.Count();
                IEnumerable<news> test1 = newsss.Where(t => t.DatePub.Month==(DateTime.Now.Month-3));
                IEnumerable<news> test2 = newsss.Where(t => t.DatePub.Month== (DateTime.Now.Month -2));
                IEnumerable<news> test3 = newsss.Where(t => t.DatePub.Month == (DateTime.Now.Month -1));
                IEnumerable<news> test4 = newsss.Where(t => t.DatePub.Month == DateTime.Now.Month);

                double tauxtest1 = Math.Round((double)(test1.Count() * 100 / sizeNews));
                double tauxtest2 = Math.Round((double)(test2.Count() * 100 / sizeNews));
                double tauxtest3 = Math.Round((double)(test3.Count() * 100 / sizeNews));
                double tauxtest4 = Math.Round((double)(test4.Count() * 100 / sizeNews));
                return new Dictionary<string, double>
            {
                {"news",sizeNews },
                {"test1",tauxtest1 },
                {"test2",tauxtest2 },
                {"test3",tauxtest3 },
                {"test4",tauxtest4 }
            };


            }
        }
    }