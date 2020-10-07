using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "his profile page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "일반사항";

            return View();
        }

        public ActionResult MENU(int? n)  //    int? : nullable type
        {

            ViewBag.Message = $"Your Option page. #{n}";

            return View();
        }
    }
}