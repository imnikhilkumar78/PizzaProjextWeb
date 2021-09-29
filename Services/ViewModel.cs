using Microsoft.EntityFrameworkCore;
using PizzaApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Services
{
    public class ViewModel
    {
        private readonly PizzaWebStoreContext _context;
        public ViewModel()
        {
            _context = new PizzaWebStoreContext();
        }

        public List<Pizza> Pizza1 = new List<Pizza>();
        public List<Topping> Topping1 = new List<Topping>();


        public int getOderId()
        {
            int orderId = _context.Orders.Max(or => or.OrderId);
            return orderId;
        }


        public List<int> getItemId(int orderId)
        {
            List<int> itemId = new List<int>();
            foreach (var item in _context.OrderDetails)
            {
                if (item.OrderId == orderId)
                {
                    itemId.Add(item.ItemId);

                }

            }
            return itemId;
        }

        public string getUserAddress()
        {
            string UAddress = "";
            string UEmail = "";
            int orderId = _context.Orders.Max(or => or.OrderId);
            foreach (var item in _context.Orders)
            {
                if (item.OrderId == orderId)
                {
                    UEmail = item.UserId;
                    break;
                }
            }
            foreach (var item in _context.Users)
            {
                if (item.UserEmail.Equals(UEmail))
                {
                    UAddress = item.Address;
                    break;
                }
            }
            
            return UAddress;
        }

        internal double getDeliveryCharge()
        {
            double totalPrice = 0;
            double deliveryCharge = 0;
            int orderId = _context.Orders.Max(or => or.OrderId);
            foreach (var item in _context.Orders)
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
            _context.SaveChanges();
            return deliveryCharge;

        }

        internal double getTotalPrice()
        {
            double totalPrice = 0;
            int orderId = _context.Orders.Max(or => or.OrderId);
            foreach (var item in _context.Orders)
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
            foreach (var item in _context.OrderDetails)
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
            foreach (var item in _context.ToppinngDetails)
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
            int orderId = _context.Orders.Max(or => or.OrderId);
            List<int> itemId = new List<int>();
            itemId = getItemId(orderId);
            List<int> PizzaId = new List<int>();

            foreach (var item in itemId)
            {

                PizzaId.AddRange(getPizzaId(item));
            }
            foreach (var item in PizzaId)
            {
                foreach (var Pizza in _context.Pizzas)
                {
                    if (Pizza.PizzaId == item)
                    {
                        Debug.WriteLine("---------- Pizza Name -- " + Pizza.Name);
                        Pizza1.Add(Pizza);
                    }
                }
            }

            foreach (var item in Topping1)
            {
                Debug.WriteLine("---------- Topping -- " + item);
            }

            return Pizza1;

        }


        public List<Topping> getToppingList()
        {
            int orderId = _context.Orders.Max(or => or.OrderId);
            List<int> itemId = new List<int>();
            itemId = getItemId(orderId);
            List<int> ToppingId = new List<int>();
            foreach (var item in itemId)
            {
                ToppingId.AddRange(getToppingId(item));
            }
            foreach (var item in ToppingId)
            {
                foreach (var toppings in _context.Toppings)
                {
                    if (toppings.ToppingId == item)
                    {
                        Debug.WriteLine("----------Topping Name -- " + toppings.Name);
                        Topping1.Add(toppings);
                    }
                }
            }
            
            return Topping1;

        }

        public List<OrderDetail> getItemToppingIdList()
        {
            int orderId = getOderId();

               List<OrderDetail> ItemToppingId = _context.OrderDetails.Include(a => a.ToppinngDetails)
                                                          .Where(od => od.OrderId == orderId)
                                                           .ToList();

        
            foreach (var item in ItemToppingId)
            {
                Debug.WriteLine("-------Pizza ID -- " + item.PizzaId+" === Pizza:  "+item.Pizza.Name);
                foreach (var i in item.ToppinngDetails)
                    Debug.WriteLine(" === Item  " + i.Topping.Name);
            }
            return ItemToppingId;

        }
    }
}
