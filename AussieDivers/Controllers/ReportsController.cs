using AussieDivers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMVCSite.Controllers
{
    [Authorize]
    public class ReportsController : Controller
    {
        private AussieDiversContext db = new AussieDiversContext();
        // GET: Reports
        public ActionResult Index()
        {
            return View(db.People.ToList());
        }
    }
}