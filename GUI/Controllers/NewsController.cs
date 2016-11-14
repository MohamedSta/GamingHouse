using gaming.data.Models;
using gaming.service;
using GUI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class NewsController : Controller
    {

        INewsService service = null;



        public NewsController()
        {
            service = new NewsService();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                service.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult Index()
        {
            return View();
        }
        // GET: News
        public ActionResult List()
        {
            var newss = service.GetMany();
            IList<NewsViewModel> NVM = new List<NewsViewModel>();
            foreach (var item in newss)
            {
                NVM.Add(
                    new NewsViewModel
                    {
                        idNews = item.idNews,
                        title = item.title,
                        description = item.description,
                        DatePub=item.DatePub,
                        // ImageUrl = item.ImageUrl
                        Image = "/content/Upload/" + item.Image,


                    });
            }
            return View(NVM);
        }

        // GET: News/Details/5

        public ActionResult Details(int id)
        {
            var nws = service.GetById(id);
           
            news obj = new news
            {
                idNews = nws.idNews,
                title = nws.title,
                description = nws.description,
                Image= "/content/Upload/" + nws.Image,

            };

            return View(obj);
        }

        // GET: News/Create
        public ActionResult Create()
        {
            NewsViewModel nvm = new NewsViewModel();
            return View(nvm);

        }

        // POST: News/Create
        [HttpPost]
        public ActionResult Create(news ne, HttpPostedFileBase Image)
        {
            try
            {
                if (!ModelState.IsValid || Image == null || Image.ContentLength == 0)
                {
                    RedirectToAction("Create");
                }

                news obj = new news
                {
                    idNews = ne.idNews,
                    title = ne.title,
                    description = ne.description,
                    DatePub= DateTime.Now,
                    Image = Image.FileName

                };
                var path = Path.Combine(Server.MapPath("~/content/Upload"), Image.FileName);
                Image.SaveAs(path);
                service.Add(obj);
                service.Commit();



                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: News/Edit/5
        public ActionResult Edit(int id)
        {
            news nws = service.GetById(id);

            return View(nws);
        }

        // POST: News/Edit/5
        [HttpPost]
        public ActionResult Edit(news nws)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    service.Update(nws);
                    service.Commit();
                }

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: News/Delete/5
        public ActionResult Delete(int id)
        {
            news nws = service.GetById(id);

            service.Delete(nws);
            service.Commit();
            return RedirectToAction("List");
        }

        // POST: News/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Chart()
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
            string date1 = (DateTime.Now.Month - 3).ToString();
            int sizeNews = newsss.Count();
            IEnumerable<news> test1 = newsss.Where(t => t.DatePub.Month == (DateTime.Now.Month - 3));
            IEnumerable<news> test2 = newsss.Where(t => t.DatePub.Month == (DateTime.Now.Month - 2));
            IEnumerable<news> test3 = newsss.Where(t => t.DatePub.Month == (DateTime.Now.Month - 1));
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
