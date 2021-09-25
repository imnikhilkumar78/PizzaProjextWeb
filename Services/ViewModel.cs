using PizzaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Services
{
    public class ViewModel
    {
        private readonly PizzaWebStoreContext context;
        public ViewModel()
        {
            context = new PizzaWebStoreContext();
        }

        public List<Pizza> Pizza1 = new List<Pizza>();

        private List<int> getItemId(int orderId)
        {
            List<int> itemId = new List<int>();
            foreach (var item in context.OrderDetails)
            {
                if (item.OrderId == orderId)
                {
                    itemId.Add(item.ItemId);

                }

            }
            return itemId;
        }
        private List<int> getPizzaId(int itemId)
        {
            List<int> PizzaId = new List<int>();
            foreach (var item in context.OrderDetails)
            {
                if (item.ItemId == itemId)
                {
                    PizzaId.Add(item.PizzaId);
                }
            }
            return PizzaId;
        }

        public List<Pizza> getListPizza()
        {
            int orderId= context.Orders.Max(or => or.OrderId);
            List<int> itemId = new List<int>();
            itemId = getItemId(orderId);
            List<int> PizzaId = new List<int>();
            foreach (var item in itemId)
            {
                PizzaId = getPizzaId(item);
            }
            foreach (var item in PizzaId)
            {
                foreach (var Pizza in context.Pizzas)
                {
                    if (Pizza.PizzaId==item)
                    {
                        Pizza1.Add(Pizza);
                    }
                }
            }
            return Pizza1;
        }
    }
}
