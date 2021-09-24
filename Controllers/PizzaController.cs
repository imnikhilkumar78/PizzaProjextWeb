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
            return View(_repo.Get(id));
        }
    }
}
