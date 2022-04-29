using Academy.Week1.interfaces;
using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.repository
{
    internal class Repository : IRepository<Prodotto>
    {
        public List<Prodotto> PrintAll()
        {
            List<Prodotto> list = new List<Prodotto>();
            RepositoryAlimentare rp = new RepositoryAlimentare();
            RepositoryTecnologico rt = new RepositoryTecnologico();

            list = rp.getAlimentare();
            list.AddRange(rt.getTecnologico());
            return list;
            
        }
    }
}
