using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Flutter.Controllers
{
    public class TweetController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            Tweet tweet = new Tweet();
            tweet.UserId = Session["UserId"];
            return View(model: tweet);
        }

        [HttpPost]
        public ActionResult Tweet(Tweet tweet)
        {
            TweetDb.AddTweet(tweet);
            return Redirect("Index", "User");
        }

	}
}