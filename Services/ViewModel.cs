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
        public List<Topping> Topping1 = new List<Topping>();





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

        internal double getDeliveryCharge()
        {
            double totalPrice = 0;
            double deliveryCharge = 0;
            int orderId = context.Orders.Max(or => or.OrderId);
            foreach (var item in context.Orders)
            {
                if (item.OrderId == orderId)
                {
                    totalPrice =Convert.ToDouble(item.Total);
                    if (totalPrice <= 25)
                    {
                        deliveryCharge = 5;
                        item.DeliveryCharge = 5;
                    }
                    else
                    {
                        item.DeliveryCharge = 0;
                    }

                }
            }
            context.SaveChanges();
            return deliveryCharge;

        }

        internal double getTotalPrice()
        {
            double totalPrice = 0;
            int orderId = context.Orders.Max(or => or.OrderId);
            foreach (var item in context.Orders)
            {
                if (item.OrderId == orderId)
                {
                    totalPrice = Convert.ToDouble(item.Total);
                }
            }
            return totalPrice;
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
        private List<int> getToppingId(int itemId)
        {

            List<int> ToppingId = new List<int>();
            foreach (var item in context.ToppinngDetails)
            {
                if (item.ItemId == itemId)
                {
                    ToppingId.Add(item.ToppingId);

                }
            }

            return ToppingId;
        }

        public List<Pizza> getListPizza()
        {
            int orderId = context.Orders.Max(or => or.OrderId);
            List<int> itemId = new List<int>();
            itemId = getItemId(orderId);
            List<int> PizzaId = new List<int>();

            foreach (var item in itemId)
            {

                PizzaId.AddRange(getPizzaId(item));
            }
            foreach (var item in PizzaId)
            {
                foreach (var Pizza in context.Pizzas)
                {
                    if (Pizza.PizzaId == item)
                    {
                        Pizza1.Add(Pizza);
                    }
                }
            }
            return Pizza1;

        }


        public List<Topping> getToppingList()
        {
            int orderId = context.Orders.Max(or => or.OrderId);
            List<int> itemId = new List<int>();
            itemId = getItemId(orderId);
            List<int> ToppingId = new List<int>();
            foreach (var item in itemId)
            {
                ToppingId.AddRange(getToppingId(item));
            }
            foreach (var item in ToppingId)
            {
                foreach (var toppings in context.Toppings)
                {
                    if (toppings.ToppingId == item)
                    {
                        Topping1.Add(toppings);
                    }
                }
            }

            return Topping1;

        }


    }
}
