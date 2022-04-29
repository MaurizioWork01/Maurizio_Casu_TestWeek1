using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.interfaces
{
    internal interface IRepository<T>
    {
        public List<T> PrintAll();
    }
}
