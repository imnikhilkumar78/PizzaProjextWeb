using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Services
{
    public interface IOrder<K>
    {
        ICollection<K> GetAll();
    }
}
