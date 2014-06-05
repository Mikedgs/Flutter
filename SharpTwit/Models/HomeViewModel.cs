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
        public Repository<User> repoUser = new Repository<User>();
        public IEnumerable<User> ListOfUsers { get; set; }

        public HomeViewModel()
        {
            ListOfTweets = GetAllTweet();
            ListOfUsers = GetAllUsers();
        }

        public IEnumerable<Tweet> GetAllTweet()
        {
            List<Tweet> top2 = new List<Tweet>();
            var tweetList = repoTweet.GetAll().OrderByDescending(x => x.UpdatedAt);
            if (tweetList.Count() > 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    top2.Add(tweetList.ElementAt(i));
                }
            }
            return top2;
        }

        public IEnumerable<User> GetAllUsers()
        {
            List<User> top2 = new List<User>();
            var userList = repoUser.GetAll().OrderByDescending(x => x.UpdatedAt);
            if (userList.Count() > 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    top2.Add(userList.ElementAt(i));
                }
            }
            return top2;
        }
    }
}