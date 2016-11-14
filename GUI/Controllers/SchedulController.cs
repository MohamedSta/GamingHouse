using DHTMLX.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class SchedulController : Controller
    {
        // GET: Schedul
        public ActionResult Index()
        {
            var scheduler = new  DHXScheduler(this);
            scheduler.Extensions.Add(SchedulerExtensions.Extension.ActiveLinks);
            scheduler.Skin = DHXScheduler.Skins.Standart;

            return View(scheduler);
        }
    }
}
