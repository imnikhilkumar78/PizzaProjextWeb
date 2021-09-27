using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Models
{
    public class PizzaToppingModel
    {
        public List<Pizza> ListOfPizza { get; set; }
        public List<Topping> ListofToppings { get; set; }
        public double TotalPrice { get; set; }
        public double DeliveryCharge { get; set; }
        public string Address { get; set; }
    }
}
