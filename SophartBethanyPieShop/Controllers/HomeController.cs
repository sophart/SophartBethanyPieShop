﻿using Microsoft.AspNetCore.Mvc;

namespace SophartBethanyPieShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
