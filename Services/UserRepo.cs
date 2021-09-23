using Microsoft.EntityFrameworkCore;
using PizzaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Services
{
    public class UserRepo : IRepo<User>
    {
        private readonly PizzaWebStoreContext _context;
        public UserRepo(PizzaWebStoreContext context)
        {
            _context = context;
        }
        public User Add(User k)
        {
            try
            {
                _context.Users.Add(k);
                _context.SaveChanges();
                return k;
            }
            catch (DbUpdateConcurrencyException ducex)
            {
                Console.WriteLine(ducex.Message);
            }
            catch (DbUpdateException dbuex)
            {
                Console.WriteLine(dbuex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        
    }
}
