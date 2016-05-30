using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TS.ServiceInterfaces;

namespace TS.Web.Controllers
{
    public class HomeController : Controller
    {
        [Dependency]
        public ITestService TestService { get; set; }
        public ActionResult Index()
        {
            TestService.Test();
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