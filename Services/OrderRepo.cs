using Microsoft.Extensions.Logging;
using PizzaApplication.Controllers;
using PizzaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Services
{
    public class OrderRepo : IPizzaRepo<Order>
    {
        private readonly PizzaWebStoreContext _context;
     

        public OrderRepo(PizzaWebStoreContext context)
        {
            _context = context;


        }
        PizzaRepo pr = new PizzaRepo();
        ToppingRepo tr = new ToppingRepo();
        public Order Get(int id)
        {
            Order order = new Order();
            try
            {
                order.OrderId = _context.Orders.Max(or => or.OrderId);

                double? totalPrice = _context.Orders.Find(order.OrderId).Total; 

                if (totalPrice > 25)
                    order.DeliveryCharge = 0;
                else
                    order.DeliveryCharge = 5;

               

                _context.Orders.Update(order);
                _context.SaveChanges();
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

                return order;
        }

        public ICollection<Order> GetAll()
        {
          

            IList<Order> orders = _context.Orders.ToList();
          
            if (orders.Count > 0)
                return orders;
            else
                return null;
        }
    }
}
