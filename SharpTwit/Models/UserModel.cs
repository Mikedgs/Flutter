using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpTwit;

namespace Flutter.Models
{
    public class UserModel
    {
        private Repository<User> repo;

        public UserModel()
        {
            repo = new Repository<User>();
        }

        public void SaveUser(User user)
        {
            user.UpdatedAt = DateTime.Now;
            user.CreatedAt = DateTime.Now;
            repo.Add(user);
            repo.SaveChanges();
        }

        public User Validate(User user)
        {
            string password = new HashProvider().GetMD5Hash(user.Password);
            return repo.Get(x => x.UserName == user.UserName && x.Password == password).FirstOrDefault();

        }
    }
}