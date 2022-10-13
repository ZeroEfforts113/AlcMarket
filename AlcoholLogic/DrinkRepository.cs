using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholLogic
{
    class DrinkRepository <T>:IDrinkRepository<T>
    {
        ICollection<T> Drinks { get; set;}

        public void Create(T drink)
        {
            throw new NotImplementedException();
        }

        public void Delete(T drink)
        {
            throw new NotImplementedException();
        }

        public void Edit(T drink)
        {
            throw new NotImplementedException();
        }
    }

    
}
