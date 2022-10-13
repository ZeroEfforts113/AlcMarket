using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholLogic
{
    interface IDataTransfer<T>
    {
        ICollection<T> drinks { get; set;}
    }
}
