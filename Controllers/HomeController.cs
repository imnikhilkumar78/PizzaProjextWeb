﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            String[] images = { "/img/cyl.png" };
            ViewBag.images = images;
            return View();
        }

        public IActionResult Login()
        {
            return RedirectToAction("Login", "User");
        }

        public IActionResult Register()
        {
            return RedirectToAction("Index", "User");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
