using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoNET.Controllers
{
    public class StatsController : Controller
    {
        // GET: Stats
        public ActionResult Index()
        {
            ViewBag.LastDayUploads = 1;
            ViewBag.LastWeekUploads = 7;
            ViewBag.LastMonthUploads = 23;

            return View();
        }
    }
}