using ECommerceTaynan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceTaynan.Controllers
{
    public class HomeController : Controller
    {
        private ECommerceContext db = new ECommerceContext();

        public ActionResult Index()
        {
            var user = db.Users.Where(u => u.Email == User.Identity.Name).FirstOrDefault();
            return View(user);
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