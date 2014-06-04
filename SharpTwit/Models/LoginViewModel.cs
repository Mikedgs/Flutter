using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpTwit;

namespace Flutter.Models
{
    public class LoginViewModel
    {
        public User User { get; set; }
        public bool IsValidUser { get; set; }

        public LoginViewModel(User user, bool isValidUser)
        {
            User = user;
            IsValidUser = isValidUser;
        }
    }
}