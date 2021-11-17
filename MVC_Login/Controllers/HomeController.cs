using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Login.Controllers
{
    [Authorize] // Bu attribute kullanıcının otomatik olarak login olup olmadığını kontrol eder.
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        
    }
}