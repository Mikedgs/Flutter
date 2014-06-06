using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpTwit;

namespace Flutter.Models
{
    public class ProfileViewModel
    {
        public string UserName { get; set; }
        public IEnumerable<Tweet> TweetList { get; set; }
        public Repository<User> repoUser = new Repository<User>();
        public Repository<Tweet> repoTweet = new Repository<Tweet>();
        public int UserId { get; set; }
        public User User { get; set; }

        public ProfileViewModel(string username)
        {
            UserName = username;
            TweetList = GetTweet(UserName);
            UserId = repoUser.Get(x => x.UserName == UserName).First().Id;
        }

        public IEnumerable<Tweet> GetTweet(string username)
        {
            var user = repoUser.Get(x => x.UserName == username).First();
            return repoTweet.Get(x => x.UserId == user.Id).OrderByDescending(x => x.UpdatedAt);     
        }

    }
}