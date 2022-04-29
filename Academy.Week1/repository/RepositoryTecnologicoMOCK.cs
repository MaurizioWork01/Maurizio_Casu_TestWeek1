using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.repository
{
    internal class RepositoryTecnologicoMOCK
    {
        public static List<Prodotto> RefillList()
        {
            List<Prodotto> listaTecnologico = new List<Prodotto>();
            {
                listaTecnologico.Add(new Tecnologico { codice = "g5", descrizione = "Tastiera", prezzo = 1, marca = "", isNew = true  });
                listaTecnologico.Add(new Tecnologico { codice = "h4", descrizione = "Monitor", prezzo = 2, marca = "", isNew = false });
                listaTecnologico.Add(new Tecnologico { codice = "u2", descrizione = "Mouse Gaming", prezzo = 3, marca = "", isNew = true });
            }
            foreach (Prodotto p in listaTecnologico)
            {
                p.ToString();
            }
            return listaTecnologico;
        }
    }
}
