using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpTwit;
using System.Web.Mvc;

namespace Flutter.Models
{
    public class TweetDb
    {
        private Repository<Tweet> repo = new Repository<Tweet>();

        public void AddTweet(Tweet tweet)
        {
            tweet.CreatedAt = DateTime.Now;
            tweet.UpdatedAt = DateTime.Now;
            repo.Add(tweet);
            repo.SaveChanges();
            
        }
    }
}