using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities;

namespace Academy.Week1.interfaces
{
    internal interface IRepositoryAlimentare
    {
        public List<Prodotto> getAlimentare();
        public void addAlimentare();
        public List<Prodotto> getCodiceAlimentare();
        public List<Prodotto> getScadenzaToday();
        public List<Prodotto> getScadenzaNear();
    }
}
