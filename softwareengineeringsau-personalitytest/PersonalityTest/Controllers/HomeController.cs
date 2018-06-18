using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PersonalityTest.Models;

namespace PersonalityTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dort_Renk_Yonerge()
        {
            ViewBag.Index = true;
            ViewBag.Title = "Dört Renk Anketi";
            return View();
        }
        public ActionResult Dort_Renk()
        {
            ViewBag.Index = true;
            ViewBag.Title = "Dört Renk Anketi";
            return View();
        }
        public ActionResult Sonuc(string id)
        {
            ViewBag.yazi = id;
            return View();
        }
    }
}
