using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.CIMS_NEXT.Controllers
{
    public class TellerController : Controller
    {
        // GET: Teller
        public ActionResult Index()
        {
            return View("../Authenticated/Admin/Index");
        }


    }
}
