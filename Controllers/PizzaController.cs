using Microsoft.AspNetCore.Mvc;
using PizzaApplication.Models;
using PizzaApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaRepo<Pizza> _repo;

        public PizzaController(IPizzaRepo<Pizza> repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }

        public IActionResult Select_This(int id)
        {
            ViewBag.Status = "Pizza Added";
            return View(_repo.Get(id));
            
        }

        public IActionResult Checkout()
        {
            return RedirectToAction("Index","View");
        }
        public IActionResult AddPizza()
        {
            return RedirectToAction("Index","Pizza");
        }
        public IActionResult AddTopping()
        {
            return RedirectToAction("Index", "Topping");
        }
    }
}
