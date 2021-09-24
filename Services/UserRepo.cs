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

        public int order_id { get; set; }

        public string uemail = "";

        public UserRepo()
        {
            
        }
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

        public User Login(User k)
        {
            try
            {
                bool flag = checklogin(k.UserEmail, k.Password);
                if(flag==true)
                {
                    Order order = new Order();
                    order.UserId = k.UserEmail;
                    order.Status = "In Transit";
                    _context.Orders.Add(order);
                    _context.SaveChanges();
                    foreach (var item in _context.Orders)
                    {
                        if (item.UserId.Equals(k.UserEmail))
                        {
                            order_id = item.OrderId;
                            
                        }
                       

                    }



                    return k;
                }
                else if(flag == false)
                {

                    return null;
                }
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

       


        private bool checklogin(string userEmail, string password)
        {
            bool flag = false;
            foreach (var item in _context.Users)
            {
                if(item.UserEmail.Equals(userEmail) && item.Password.Equals(password))
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
}
