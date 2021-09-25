using PizzaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Services
{
    public class ToppingRepo : IPizzaRepo<Topping>
    {
        public double? TotalPriceTopping = 0;
        private readonly PizzaWebStoreContext _context;
        public ToppingRepo(PizzaWebStoreContext context)
        {
            _context = context;
        }

        public ToppingRepo()
        {

        }
        public Topping Get(int id)
        {
            Topping topping = null;
            try
            {
                topping = _context.Toppings.FirstOrDefault(e => e.ToppingId == id);
                ToppinngDetail td = new ToppinngDetail();
                td.ItemId = _context.OrderDetails.Max(od => od.ItemId);
                td.ToppingId = topping.ToppingId;
                _context.ToppinngDetails.Add(td);
                TotalPriceTopping += topping.Price;
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
            return topping;
        }

        public ICollection<Topping> GetAll()
        {
            IList<Topping> toppings = _context.Toppings.ToList();
            if (toppings.Count > 0)
                return toppings;
            else
                return null;
        }
    }
}
