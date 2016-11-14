using GUI.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using gaming.service;
using gaming.data.Models;
using gaming.domain.Models;

namespace GUI.Controllers
{
    public class TournamentController : Controller
    {

        ITournamentService service = null;



        public TournamentController()
        {
            service = new TournamentService();
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
        // GET: Tournament

        public ActionResult List()
        {
            var tournaments = service.GetMany();
            IList<TournamentViewModel> TVM = new List<TournamentViewModel>();
            foreach (var item in tournaments)

            {
                TVM.Add(
                    new TournamentViewModel
                    {
                        idtournament = item.idtournament,
                        title = item.title,
                        description = item.description,
                        date = item.date,
                      //  ImageUrl = item.ImageUrl,
                        ImageUrl = "/content/Upload/" + item.ImageUrl,
                        lieu = item.lieu,

                    });
            }
            return View(TVM);
        }

        // GET: Tournament/Details/5
        public ActionResult Details(int id)
        {
            var tour = service.GetById(id);
            // service.GetById(id);
            tournament obj = new tournament
            {
                idtournament = tour.idtournament,
                title = tour.title,
                description = tour.description,
                date = tour.date,
                lieu = tour.lieu,
                ImageUrl = "/content/Upload/" + tour.ImageUrl,
            };

            return View(obj);
        }

        // GET: Tournament/Create
        public ActionResult Create()
        {
            TournamentViewModel tvm = new TournamentViewModel();
            return View(tvm);
        }

        // POST: Tournament/Create
        [HttpPost]
        public ActionResult Create(tournament tour, HttpPostedFileBase Image)
        {
            try
            {
                if (!ModelState.IsValid || Image == null || Image.ContentLength == 0)
                {
                    RedirectToAction("Create");
                }

                tournament obj = new tournament
                {
                    idtournament = tour.idtournament,
                    date =tour.date,
                    description=tour.description,
                    title = tour.title,
                    lieu = tour.lieu,
                    ImageUrl = Image.FileName,


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

        // GET: Tournament/Edit/5
        public ActionResult Edit(int id)
        {
            tournament tour = service.GetById(id);

            return View(tour);
        }

        // POST: Tournament/Edit/5
        [HttpPost]
        public ActionResult Edit(tournament tour)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    service.Update(tour);
                    service.Commit();
                }

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }


        }

        // GET: Tournament/Delete/5
        public ActionResult Delete(int id)
        {

            tournament tour = service.GetById(id);

            service.Delete(tour);
            service.Commit();
            return RedirectToAction("List");
        }

        // POST: Tournament/Delete/5
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

        public ActionResult Show(int id)
        {
            tournament tour = service.GetById(id);
            string city = tour.lieu;
            ViewBag.someStringValue = tour.lieu;
            return View();
        }




    }
}
