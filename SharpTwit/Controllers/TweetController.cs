﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Flutter.Controllers
{
    public class TweetController : Controller
    {
        //
        // GET: /Tweet/
        public ActionResult Index()
        {
            return View();
        }
	}
}