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
            double? TotalPrice = pr.TotalPricePizza + tr.TotalPriceTopping;
            order.Total=TotalPrice;
            _context.Orders.Update(order);
            _context.SaveChanges();
            return order;
        }

        public ICollection<Order> GetAll()
        {

            IList<Order> order = _context.Orders.ToList();
            if (order.Count > 0)
                return order;
            else
                return null;
        }
    }
}
