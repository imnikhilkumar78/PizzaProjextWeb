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
        //private readonly IOrder<Pizza> _repo;


        //public ViewController(IOrder<Pizza> repo)
        //{
        //    _repo = repo;

        //}

        public IActionResult Index()
        {
            ViewModel vm = new ViewModel();
            List<Pizza> PizzaList = vm.getListPizza();
            List<Topping> toppingList = vm.getToppingList();
            double totalPrice = vm.getTotalPrice();
            double Deliverycharge = vm.getDeliveryCharge();
          

            var PizzaToppingList = new PizzaToppingModel
            {
                ListOfPizza = PizzaList,
                ListofToppings = toppingList,
                TotalPrice = totalPrice,
                DeliveryCharge = Deliverycharge,
             

            };
            return View(PizzaToppingList);
        }
        public IActionResult Confirm()
        {
            ViewModel vm = new ViewModel();
            string UAddress = vm.getUserAddress();
            var PizzaToppingList = new PizzaToppingModel
            {
                Address = UAddress
            };
            return View(PizzaToppingList);
        }
        public IActionResult Cancel()
        {
            return RedirectToAction("Login","User");
        }

    }
}
