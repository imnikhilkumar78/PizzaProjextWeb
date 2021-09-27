using PizzaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Services
{
    public class ViewRepo : IOrder<Pizza>
    {
       

        public ICollection<Pizza> GetAll()
        {
            ViewModel vm = new ViewModel();
           
           
            IList<Pizza> pizzaList = vm.getListPizza();
            return pizzaList;
        }
    }
}
