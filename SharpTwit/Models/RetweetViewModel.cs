using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpTwit;
using System.Web.Mvc;

namespace Flutter.Models
{
    public class RetweetViewModel
    {
        public Tweet Twet { get; set; }
        public Repository<Tweet> repoTweet = new Repository<Tweet>();
        public Tweet newTweet = new Tweet();

        public RetweetViewModel(Tweet twit)
        {
            Twet = twit;
        }

    }
}