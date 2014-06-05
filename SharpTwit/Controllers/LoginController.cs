using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Flutter.Models;
using Flutter;
using SharpTwit;
using System.Web.Routing;

namespace Flutter.Controllers
{
    public class LoginController : Controller
    {

        [HttpGet]
        public ActionResult Index(bool validUser = true)
        {
            User user = new User();
            LoginViewModel ivm = new LoginViewModel(user, validUser);
            return View(model: ivm);
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            User validUser = new UserModel().Validate(user);
            if (validUser != null)
            {
                Session["UserName"] = validUser.UserName;
                return Redirect("/user/Profile?userName=" + validUser.UserName);
            }
            else
            {
                var rvDic = new RouteValueDictionary();
                rvDic.Add("validUser", false);
                return RedirectToAction("Index", "Login", rvDic);
            }
        }
	}
}