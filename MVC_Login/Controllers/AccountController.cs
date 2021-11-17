using MVC_Login.Models.Data.Context;
using MVC_Login.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_Login.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            //Kullanıcı oturum açmış mı diye sorduğumuz sorunun cevabı evet ise , kullanıcı home içindeki index'e gelsin
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home"); 

            
            return View();
        }
        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                using (ProjectContext db = new ProjectContext())
                {
                    var user = db.Users.FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);

                    if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(user.Name, true);
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            

            ViewBag.Message = "Kullanıcı adı veya Parola hatalıdır.";
            return View();
        }
    }
}