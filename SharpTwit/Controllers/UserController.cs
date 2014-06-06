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
        public Repository<FollowTable> _repoFollowTable = new Repository<FollowTable>();
        
        //
        // GET: /User/

        public ActionResult Index()
        {
            if ((string)Session["loggedIn"] == "true") // Checks if user is logged in
            {
                var user = _repoUser.FindById((int)Session["UserId"]);
                UserViewModel model = new UserViewModel(user);
                return View(model);
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

        [HttpGet]
        public ActionResult Profile(string username)
        {
            ProfileViewModel profile = new ProfileViewModel(username);
            return View(profile);
        }

        public ActionResult Follow(string username)
        {
            var follow = new FollowTable();
            var following = _repoUser.Get(x => x.UserName == username).First();
            follow.UserId = following.Id;
            follow.FollowerId = (Int32)Session["UserId"];
            _repoFollowTable.Add(follow);
            _repoFollowTable.SaveChanges();
            return Redirect("/User/Profile?=" + username);
        }


    }
}