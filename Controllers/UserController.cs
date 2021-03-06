using Microsoft.AspNetCore.Mvc;
using PizzaApplication.Models;
using PizzaApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Controllers
{
    public class UserController : Controller
    {
        private readonly IRepo<User> _repo;

        public UserController(IRepo<User> repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(User m)
        {
            _repo.Add(m);
            return RedirectToAction("Index");
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User m)
        {
            if (ModelState.IsValid)
            {
                User s = _repo.Login(m);
               
                if (s != null)
                {
                    Console.WriteLine("Here");
                    return RedirectToAction("Index", "Pizza");
                }
                else
                {
                    ViewBag.alert = "Login Failed";
                    return View("Login");
                }
            }
            return View("Login");
        }

    }
}
