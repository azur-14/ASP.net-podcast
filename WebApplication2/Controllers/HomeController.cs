using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getMainPage()
        {
            ViewBag.Title = "getMainPage";
            return View();
        }
        public ActionResult BlogDetails()
        {
            ViewBag.Title = "BlogDetails";
            return View();
        }
        public ActionResult Episodes()
        {
            ViewBag.Title = "Episodes";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Title = "About";
            return View();
        }
        public ActionResult Blog()
        {
            ViewBag.Title = "Blog";
            return View();
        }
        public ActionResult EpisodesDetails()
        {
            ViewBag.Title = "EpisodesDetails";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}