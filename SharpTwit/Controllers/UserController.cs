using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Flutter.Models;
using SharpTwit;

namespace Flutter.Controllers
{
    public class UserController : Controller
    {
        public Repository<User> _repoUser = new Repository<User>();
        
        //
        // GET: /User/

        public ActionResult Index()
        {
            if ((string)Session["loggedIn"] == "true") // Checks if user is logged in
            {
                var user = _repoUser.FindById((int)Session["UserId"]);
                return View(user);
            }
            else
                return Redirect("/Login/Index"); // View Go to login page
        }

        [HttpGet]
        public ActionResult CreateUser()
        {
            //ViewData["User"] = _repoUser.GetAll();
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public ActionResult CreateUser(User addNewUser)
        {
            addNewUser.CreatedAt = DateTime.Now;
            addNewUser.UpdatedAt = DateTime.Now;
            addNewUser.Password = new HashProvider().GetMD5Hash(addNewUser.Password);
            _repoUser.Add(addNewUser);
            _repoUser.SaveChanges();
            Session["loggedIn"] = "true";
            Session["UserId"] = addNewUser.Id;
            return RedirectToAction("Index", "User"); //Redirect to user page
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Clear();
            return Redirect("/Login/Index");
        }
    }
}