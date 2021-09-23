using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Services
{
    public interface IRepo<K>
    {
        K Add(K k);
        K Login(K k);
      
    }
}
