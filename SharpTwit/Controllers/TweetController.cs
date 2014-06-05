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
        Repository<Tweet> tweetRepo = new Repository<Tweet>();

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

        [HttpGet]
        public ActionResult ReTweet(int tweetId)
        {
            var tweet = tweetRepo.FindById(tweetId);
            RetweetViewModel model = new RetweetViewModel(tweet);
            model.newTweet.UserId = (int)Session["UserId"];
            return View(model);
        }

        [HttpPost]
        public ActionResult ReTweet(Tweet twit)
        {
            TweetDb tweetDb = new TweetDb();
            tweetDb.AddTweet(twit);
            return Redirect("/User/Index");
        }

	}
}