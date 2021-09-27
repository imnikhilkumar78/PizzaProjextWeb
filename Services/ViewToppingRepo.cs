using PizzaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Services
{
    public class ViewToppingRepo : IOrder<Topping>
    {
        public ICollection<Topping> GetAll()
        {
            ViewModel vm = new ViewModel();


            IList<Topping> toppingList = vm.getToppingList();
            return toppingList;
        }
    }
}
