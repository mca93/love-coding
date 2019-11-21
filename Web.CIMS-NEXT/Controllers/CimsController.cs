using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Web.CIMS_NEXT.ViewModels;

namespace Web.CIMS_NEXT.Controllers
{
    public class CimsController : Controller
    {
        public ActionResult Login(LoginViewModel loginVewModel)
        {


            if (!ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(loginVewModel.UserName))
                {
                    ViewBag.UserNameError = "Username is required";
                }
                if (string.IsNullOrEmpty(loginVewModel.Password))
                {
                    ViewBag.PasswordError = "Password is required";
                }

                return View(loginVewModel);
            }



            //ViewBag.errorMessage = username + " Error";
            return View(loginVewModel);
        }

        public ActionResult RegisterAdmin()
        {
            // Register the first user.

            return View();
        }

        public async Task<ActionResult> TestLogin(LoginViewModel model, string returnUrl)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Check if the User exists in LDAP
            if (Membership.GetUser(model.UserName) == null)
            {
                ModelState.AddModelError("", "Wrong username or password");
                return this.View(model);
            }
            return this.View(model);



        }
    }
}