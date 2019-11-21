using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.CIMS_NEXT.Controllers
{
    public class FrontOfficerController : Controller
    {
        // GET: FrontOfficer
        public ActionResult Index()
        {
            return View("../Authenticated/FrontOfficer/Index");
        }

        public ActionResult FrontLineView()
        {
            return View("../Authenticated/FrontOfficer/FrontLineView");
        }
    }
}