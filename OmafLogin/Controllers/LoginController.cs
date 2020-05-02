using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OmafLogin.Models;

namespace OmafLogin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Authorise(User user)
        {
            using (DBModels db = new DBModels ())
            {
                var userDetail = db.Users.Where(x => x.UserName == user.UserName && x.Password == user.Password).FirstOrDefault();
                if (userDetail == null)
                {
                    user.LoginErrorMsg = "Invalid username or password.";
                    return View("Index", user);
                }
                else
                {
                    Session["userId"] = user.UserId;
                    Session["userName"] = user.UserName;
                    return RedirectToAction("Index", "Home");
                }
            }
        }
        public ActionResult LogOut()
        {
            int userId = (int) Session["userId"];
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}