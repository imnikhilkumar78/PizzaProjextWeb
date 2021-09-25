using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApplication.Services
{
    public interface IPizzaRepo<K>
    {
        ICollection<K> GetAll();
        K Get(int id);
    }
}
