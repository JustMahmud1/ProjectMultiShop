﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ProjectMultiShop.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}