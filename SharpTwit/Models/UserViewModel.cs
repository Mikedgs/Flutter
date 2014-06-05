using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpTwit;
using Flutter.Models;

namespace Flutter.Models
{
    public class UserViewModel
    {
        public User UserObject { get; set; }
        public IEnumerable<Tweet> TweetList { get; set; }
        public Repository<User> repoUser = new Repository<User>();
        public Repository<Tweet> repoTweet = new Repository<Tweet>();
        public Repository<FollowTable> repoFollow = new Repository<FollowTable>();

        public UserViewModel(User userObject)
        {
            UserObject = userObject;
            TweetList = GetTweet(UserObject);
        }
        

        public IEnumerable<Tweet> GetTweet(User user)
        {
            return repoTweet.Get(x => x.UserId == user.Id);            
        }
    }
}