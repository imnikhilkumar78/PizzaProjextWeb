using Microsoft.AspNetCore.Mvc;
using PizzaApplication.Models;
using PizzaApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Controllers
{
    public class OrderController : Controller
    {
        private readonly IPizzaRepo<Order> _repo;

        public OrderController(IPizzaRepo<Order> repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }

        public IActionResult Checkout(int id)
        {
            return View(_repo.Get(id));
        }
    }
}
