﻿using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
