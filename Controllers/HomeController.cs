using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Hosting;
using System.Web;
using System;

namespace DashboardLayout.Controllers
{
    public class HomeController : Controller
    {
        public class spacingModel
        {
            public double[] cellSpacing { get; set; }
        }
        public ActionResult Index()
        {
            spacingModel modelValue = new spacingModel();
            modelValue.cellSpacing = new double[] { 10, 10 };
            return View(modelValue);
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