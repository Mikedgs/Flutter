using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpTwit;

namespace Flutter.Models
{
    public class HomeViewModel
    {
        public Repository<Tweet> repoTweet = new Repository<Tweet>();
        public IEnumerable<Tweet> ListOfTweets { get; set; }

        public HomeViewModel()
        {
            ListOfTweets = GetAllTweet();
        }

        public IEnumerable<Tweet> GetAllTweet()
        {
            List<Tweet> top20 = new List<Tweet>();
            var tweetList = repoTweet.GetAll().OrderBy(x => x.UpdatedAt);
            for (int i = 0; i < 2; i++)
            {
                top20.Add(tweetList.ElementAt(i));
            }
            return top20;
        }
    }
}