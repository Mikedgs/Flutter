using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SharpTwit;
using Flutter.Models;

namespace Flutter.Controllers
{
    public class TweetController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            Tweet tweet = new Tweet();
            if (Session["UserId"] != null)
                tweet.UserId = (int)Session["UserId"];
            else
                return Redirect("/Login/index");
            return View(model: tweet);
        }

        [HttpPost]
        public RedirectResult Tweet(Tweet tweet)
        {
            TweetDb tweetDb = new TweetDb();
            tweetDb.AddTweet(tweet);
            return Redirect("/User/Index");
        }

	}
}