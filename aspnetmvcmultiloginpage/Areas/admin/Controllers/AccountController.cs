using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMvcMultiLoginPage.Areas.admin.Controllers
{
    public class AccountController : Controller
    {
        // GET: admin/Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}