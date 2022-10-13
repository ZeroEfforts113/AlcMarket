using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholLogic
{
    interface IDrinkRepository<T>
    {
        void Create(T drink);
        void Edit(T drink);
        void Delete(T drink);
       // void Find(T drink);
        
        
    }
}
