using AussieDivers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AussieDivers.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private AussieDiversContext db = new AussieDiversContext();
        [AllowAnonymous]
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View(db.People.ToList());
            }
            else
            {
                return Redirect("/Account/Login");
            }
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