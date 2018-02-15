using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bitcoin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bitcoin()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Ether()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult BitcoinCash()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}