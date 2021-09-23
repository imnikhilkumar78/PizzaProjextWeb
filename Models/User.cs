﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PizzaApplication.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public string UserEmail { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
