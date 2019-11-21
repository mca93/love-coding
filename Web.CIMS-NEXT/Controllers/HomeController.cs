using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.CIMS_NEXT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("../Authenticated/Admin/Index");
        }


        public ActionResult RegisterUser()
        {
            return View("../Authenticated/Admin/Manage-Users/Register");
        }
        //public ActionResult FrontOfficer()
        //{
        //    return View("../Authenticated/FrontOfficer/Index");
        //}

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