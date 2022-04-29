using Academy.Week1.interfaces;
using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.repository
{
    internal class RepositoryTecnologico : IRepositoryTecnologico
    {
        public void addTecnologico()
        {
            string rigascrittura = "";
            string path = @"C:\Users\LittleManOfAir\source\repos\Academy.Week1.TestWeek1\Academy.Week1\repository\Tecnologico.txt";
            StreamWriter sw = new StreamWriter(path, true);
            Console.WriteLine("Inserire i valori del prodotto tecnologico che si vuole inserire");
            Console.WriteLine("Inserire il codice identificativo:");
            rigascrittura += Console.ReadLine() + ",";

            Console.WriteLine("Inserire la descrizione del prodotto");
            rigascrittura += Console.ReadLine() + ",";
            Console.WriteLine("Inserire il prezzo del prodotto");
            rigascrittura += Console.ReadLine() + ",";
            Console.WriteLine("Inserire la marca del prodotto");
            rigascrittura += Console.ReadLine() + ",";
            Console.WriteLine("Indicare se il prodotto è nuovo");
            string controllo = Console.ReadLine().ToLower();
            while (!((controllo.Equals("true")) || !(controllo.Equals(false))))
            {
                Console.WriteLine("Inserire true o false per continuare!");

                controllo = Console.ReadLine().ToLower();
            }
            rigascrittura += controllo;

            sw.WriteLine(rigascrittura);
            sw.Close();
        }
        public List<Prodotto> getNewTecnologico()
        {
            throw new NotImplementedException();
        }

        public List<Prodotto> getTecnologico()
        {
            string path = @"C:\Users\LittleManOfAir\source\repos\Academy.Week1.TestWeek1\Academy.Week1\repository\Tecnologico.txt";
            List<Prodotto> listaTecnologico = new List<Prodotto>();
            StreamReader sr = new StreamReader(path);
            do
            {
                string riga0 = sr.ReadLine();
                if (riga0 == null || riga0.Equals(""))
                {
                listaTecnologico = RepositoryTecnologicoMOCK.RefillList();
                }
                else
                {
                
                    string[] riga = riga0.Split(",");
                    listaTecnologico.Add
                        (
                            new Tecnologico()
                            {
                            codice = riga[0],
                            descrizione = riga[1],
                            prezzo = double.Parse(riga[2]),
                            marca = riga[3],
                            isNew = riga[4].Equals("true") ? true : false

                            }
                        );  
                } 
            } while (!sr.EndOfStream);
            sr.Close();
            return listaTecnologico;
        }

        public List<Prodotto> getTecnologicoMarca()
        {
            throw new NotImplementedException();
        }

        public List<Prodotto> PrintAll()
        {
            throw new NotImplementedException();
        }
    }
}
