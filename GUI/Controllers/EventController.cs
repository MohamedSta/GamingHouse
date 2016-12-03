

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
    public class EventController : Controller


    {

        IEventService service = null;



        public EventController()
        {
            service = new EventService();

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                service.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult Show(int idEvent)
        {
            var events = service.GetById(idEvent);
            string city = events.lieu;
            ViewBag.someStringValue = events.lieu;
            return View();
        }

        public ActionResult Index() {
            return View();

        }
        public ActionResult Stream()
        {
            return View();

        }
        // GET: Event
        public ActionResult List()
        {
            var events = service.GetMany();
            IList<EventViewModel> EVM = new List<EventViewModel>();
            foreach (var item in events)

            {
                EVM.Add(
                    new EventViewModel
                    {
                        idEvent= item.idEvent,
                        dateEvent = item.dateEvent,
                        Etitle = item.Etitle,
                        type = item.type,
                        lieu = item.lieu,
                        Pic = "/content/Upload/" + item.Pic,

                    });
            }
            return View(EVM);
        }

        // GET: Event/Details/5
        public ActionResult Details(int idEvent)
        { var ev = service.GetById(idEvent);
            Event obj = new Event
            {
                idEvent
                = ev.idEvent,
                dateEvent = ev.dateEvent,
                Etitle = ev.Etitle,
                type = ev.type,
                lieu = ev.lieu,
                Pic = "/content/Upload/" + ev.Pic,
               
              




            };

            return View(obj);
        }

        /*  public ActionResult Details(int id)
          {
              service.GetById(id);
              var events = service.GetMany();
              IList<EventViewModel> EVM = new List<EventViewModel>();

              foreach (var item in events)
                  if (item.id==id)
                  {
                      {
                          EVM.Add(
                              new EventViewModel
                              {
                                  id = item.id,
                                  dateEvent = item.dateEvent,
                                  title = item.title,
                                  type = item.type,
                                  Pic = "/content/Upload/" + item.Pic,

                              });
                      }
                  }

              return View(EVM);
          }
  */
        // GET: Event/Create
        public ActionResult Create()
        {

            EventViewModel evm = new EventViewModel();
            return View(evm);
        }

        // POST: Event/Create
        [HttpPost]
        public ActionResult Create(Event  ev, HttpPostedFileBase Image)   //, HttpPostedFileBase Image
        {
            try
            {
                if (!ModelState.IsValid || Image == null || Image.ContentLength == 0)
                {
                    RedirectToAction("Create");
                }

                Event obj = new Event
                {
                    idEvent = ev.idEvent,
                    dateEvent = ev.dateEvent,
                    Etitle = ev.Etitle,
                    type = ev.type,
                    lieu = ev.lieu,
                    Pic = Image.FileName,
                  
                   



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

        // GET: Event/Edit/5
        public ActionResult Edit(int idEvent)
        {
            Event ev = service.GetById(idEvent);

            return View(ev);
        }

        // POST: Event/Edit/5
        [HttpPost]
        public ActionResult Edit(Event ev)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    service.Update(ev);
                    service.Commit();
                }

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Event/Delete/5
        public ActionResult Delete(int idEvent)
        {
            Event ev = service.GetById(idEvent);

            service.Delete(ev);
            service.Commit();
            return RedirectToAction("List");
        }

        // POST: Event/Delete/5
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
    }



}
