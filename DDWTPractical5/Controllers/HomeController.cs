﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDWTPractical5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Detail()
        {
            ViewBag.Message = "Detail";

            return View();
        }

      
        public ActionResult Create()
        {
            ViewBag.Title = "Create";
            return View();
        }
    }
}