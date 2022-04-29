using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.interfaces
{
    internal interface IRepositoryTecnologico
    {
        public List<Prodotto> getTecnologico();
        public void addTecnologico();
        public List<Prodotto> getTecnologicoMarca();
        public List<Prodotto> getNewTecnologico();



    }
}
