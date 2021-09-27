using Microsoft.AspNetCore.Mvc;
using PizzaApplication.Models;
using PizzaApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Controllers
{
    public class ViewController : Controller
    {
        private readonly IOrder<Pizza> _repo;
       

        public ViewController(IOrder<Pizza> repo)
        {
            _repo = repo;
          
        }
      
        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }
        
    }
}
