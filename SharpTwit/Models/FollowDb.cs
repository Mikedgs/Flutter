using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SharpTwit;
using System.Web.Mvc;

namespace Flutter.Models
{
    public class FollowDb
    {
        public Repository<FollowTable> repo = new Repository<FollowTable>();

        public void AddFollower(FollowTable follow)
        {

        }
    }
}