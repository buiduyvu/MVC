using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMvcMultiLoginPage.Controllers
{
    public class HomeController : Controller
    {
        [CustomAuthorization(LoginPage="~/Account/Login")]
        public ActionResult Index()
        {
            return View();
        }

        [CustomAuthorization(LoginPage = "~/Admin/Account/Login")]
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