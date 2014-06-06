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
        public Repository<FollowTable> followRepo { get; set; }
        public int CurrentUserId { get; set; }
        public bool IsUserFollowing { get; set; }

        public ProfileViewModel(string username, int currentUserId)
        {
            UserName = username;
            TweetList = GetTweet(UserName);
            UserId = repoUser.Get(x => x.UserName == UserName).First().Id;
            CurrentUserId = currentUserId;
            //IsUserFollowing = IsFollowing();
        }

        public IEnumerable<Tweet> GetTweet(string username)
        {
            var user = repoUser.Get(x => x.UserName == username).First();
            return repoTweet.Get(x => x.UserId == user.Id).OrderByDescending(x => x.UpdatedAt);     
        }

        //public bool IsFollowing()
        //{
        //    var listoffollow = followRepo.GetAll();
        //    var list = followRepo.Get(x => User.UserName == UserName);
        //    if (list.Count > 0)
        //    {
        //        foreach (var follow in list) //as long as list is not null...
        //        {
        //            if (CurrentUserId == follow.FollowerId)
        //            {
        //                return true;
        //            }
        //            else return false;
        //        }
        //    }
        //    else 
        //        return false;

            //int id = 500;
            ////var followers = followRepo.Get(x => x.FollowerId == CurrentUserId).FirstOrDefault();
            //var followers = followRepo.Get(x => x.FollowerId == CurrentUserId).FirstOrDefault();
            //if (followers != null)
            //    id = followers.Id;
            //else
            //    id = 500;
            //return (UserId == id);
        
    }
}