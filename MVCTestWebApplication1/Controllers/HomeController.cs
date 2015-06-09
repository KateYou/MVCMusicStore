using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestWebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //corresponds with Views/Home/Index.cshtml
        {
            return View();  //corresponds with Views/Home/Index.cshtml
        }

        public ActionResult About() //corresponds with Views/Home/About.cshtml
        {
            ViewBag.Message = "Your application description page.";

            return View();  //corresponds with the file at Views/Home/About.cshtml
        }

        public ActionResult Contact()  //corresponds with Views/Home/Contact.cshtml
        {
            ViewBag.Message = "Your contact page.";

            return View();  //corresponds with Views/Home/Contact.cshtml
        }
    }
}