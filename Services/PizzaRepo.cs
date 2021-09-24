using PizzaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Services
{
    public class PizzaRepo : IPizzaRepo<Pizza>
    {
        private readonly PizzaWebStoreContext _context;

        UserRepo ur = new UserRepo();
        public PizzaRepo(PizzaWebStoreContext context)
        {
            _context = context;
        }
        public Pizza Get(int id)
        {
            Pizza pizza = null;
            try
            {
                pizza = _context.Pizzas.FirstOrDefault(e => e.PizzaId == id);
                OrderDetail od = new OrderDetail();
                od.OrderId = _context.Orders.Max(od => od.OrderId); ;
                od.PizzaId = pizza.PizzaId;
                _context.OrderDetails.Add(od);
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
            return pizza;
        }

        public ICollection<Pizza> GetAll()
        {
            IList<Pizza> pizza = _context.Pizzas.ToList();
            if (pizza.Count > 0)
                return pizza;
            else
                return null;
        }
    }
}
