using Academy.Week1.interfaces;
using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.repository
{
    internal class RepositoryAlimentare : IRepositoryAlimentare
    {
        public List<Prodotto> getAlimentare()
        {
            string path = @"C:\Users\LittleManOfAir\source\repos\Academy.Week1.TestWeek1\Academy.Week1\repository\Alimentare.txt";
            List<Prodotto> listAlimentare = new List<Prodotto>();
            StreamReader sr = new StreamReader(path);
            do
            {
                string riga0 = sr.ReadLine();
                if (riga0 == null || riga0.Equals(""))
                {
                    listAlimentare = RepositoryAlimentareMOCK.RefillList();
                }
                else
                {

                    string[] riga = riga0.Split(",");
                    listAlimentare.Add
                        (
                            new Alimentare()
                            {
                                codice = riga[0],
                                descrizione = riga[1],
                                prezzo = double.Parse(riga[2]),
                                quantita = int.Parse(riga[3]),
                                scadenza = DateTime.Parse(riga[4]),
                                giorniScadenza = int.Parse(riga[5])

                            }
                        );
                }
            } while (!sr.EndOfStream);
            sr.Close();
            return listAlimentare;
        }

        public List<Prodotto> getCodiceAlimentare()
        {
            throw new NotImplementedException();
        }

        public List<Prodotto> getScadenzaNear()
        {
            throw new NotImplementedException();
        }

        public List<Prodotto> getScadenzaToday()
        {
            throw new NotImplementedException();
        }

        public void addAlimentare()
        {
            string rigascrittura = "";
            string path = @"C:\Users\LittleManOfAir\source\repos\Academy.Week1.TestWeek1\Academy.Week1\repository\Alimentare.txt";
            StreamWriter sw = new StreamWriter(path, true);
            Console.WriteLine("Inserire i valori del prodotto alimentare che si vuole inserire");
            Console.WriteLine("Inserire il codice identificativo:");
            rigascrittura += Console.ReadLine() + ",";
            Console.WriteLine("Inserire la descrizione del prodotto");
            rigascrittura += Console.ReadLine() + ",";
            Console.WriteLine("Inserire il prezzo del prodotto");
            rigascrittura += Console.ReadLine() + ",";
            Console.WriteLine("Inserire la quantità del prodotto");
            rigascrittura += Console.ReadLine() + ",";
            Console.WriteLine("Indicare la data di scadenza del prodotto");
            rigascrittura += Console.ReadLine() + ",";
            Console.WriteLine("Indicare i giorni mancanti alla data di scadenza");
            rigascrittura += Console.ReadLine();


            sw.WriteLine(rigascrittura);
            sw.Close();
        }
    }
}
