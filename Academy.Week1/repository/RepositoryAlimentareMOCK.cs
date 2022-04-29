using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.repository
{
    internal class RepositoryAlimentareMOCK
    {

        public static List<Prodotto> RefillList()
        {
            List<Prodotto> listAlimentari = new List<Prodotto>();
            {
                listAlimentari.Add(new Alimentare { codice = "a1", descrizione = "POMODORI", prezzo = 1, scadenza = DateTime.Now, quantita = 1 });
                listAlimentari.Add(new Alimentare { codice = "b4", descrizione = "INSALATA", prezzo = 2, scadenza = DateTime.Now, quantita = 2 });
                listAlimentari.Add(new Alimentare { codice = "t5", descrizione = "HAMBURGER", prezzo = 3, scadenza = DateTime.Now, quantita = 3 });
            }
            
            
            return listAlimentari;
        }
        
    }
}
