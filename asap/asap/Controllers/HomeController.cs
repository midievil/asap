using Data.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;

namespace asap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            OrganizationsCollection c = new OrganizationsCollection();
            c.Create(new Organization { Name = "Test" });
            return View();
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