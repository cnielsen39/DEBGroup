﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEBGroup.Controllers
{
    public class FrontPageController : Controller
    {
        // GET: FrontPage
        public ActionResult Index()
        {
            return View();
        }
    }
}