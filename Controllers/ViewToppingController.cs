using Microsoft.AspNetCore.Mvc;
using PizzaApplication.Models;
using PizzaApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Controllers
{
    public class ViewToppingController : Controller
    {
        private readonly IOrder<Topping> _repo;


        public ViewToppingController(IOrder<Topping> repo)
        {
            _repo = repo;

        }
        public IActionResult Index()
        {
            return PartialView(_repo.GetAll());
        }
    }
}
