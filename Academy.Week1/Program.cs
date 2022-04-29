// See https://aka.ms/new-console-template for more information




//RISPOSTE PARTE TEORICA
//1a) inizializzazione
//1b) dichiarazione
//1c) assegnazione

//2) a [Valore]

//3) c [int i = FaiQualcosa(arrayDiStringhe);


using Academy.Week1.interfaces;
using Academy.Week1.repository;
using entities;

string output = "";
bool esci = false;
string scelta = "";

do
{
    Console.WriteLine("Benvenuto, signor Amministratore, scelga l'operazione desiderata tra le seguenti:");
    Console.WriteLine(  "1. Visualizzare tutti i prodotti presenti in store;\r\n"+
                        "2.Visualizzare solo i prodotti Alimentari;\r\n"+
                        "3.Visualizzare solo i prodotti Tecnologici\r\n"+
                        "4. Aggiungere un nuovo Prodotto Tecnologico.\r\n"+
                        "5. Aggiungere un nuovo Prodotto Alimentare.\r\n" +
                        "6. Cercare un prodotto Alimentare per codice;\r\n" +
                        "7.Cercare un prodotto tecnologico per Marca;\r\n" +
                        "8.Visualizzare i Prodotti Tecnologici nuovi.\r\n" +
                        "9. Visualizzare i prodotti alimentari in scadenza oggi\r\n" +
                        "10. Visualizzare i prodotti alimentari che scadono tra meno 3 giorni.:\r\n" +
                        "PREMI 0 PER USCIRE DAL PROGRAMMA");

    scelta= Console.ReadLine();
    switch (scelta)
    {
     case "1":
            {
                output = "";
                IRepository<Prodotto> repository = new Repository();
                List<Prodotto> lista = repository.PrintAll();
                foreach (Prodotto prodotto in lista)
                {
                    output += prodotto.ToString();
                }
                break;
            }
     case "2":
            {
                output = "";
                IRepositoryAlimentare ra = new RepositoryAlimentare();
                List<Prodotto> lista = ra.getAlimentare();
                foreach (Prodotto p in lista)
                {
                    Alimentare ali = p as Alimentare;
                    output += ali.ToString()+"\r\n";
                }
                break;
            }
    case "3":
            {
                output = "";
                IRepositoryTecnologico ra = new RepositoryTecnologico();
                List<Prodotto> lista = ra.getTecnologico();
                foreach (Prodotto p in lista)
                {
                    Tecnologico tec = p as Tecnologico;
                    output += tec.ToString();
                }
                break;
            }
    case "4":
            {
                output = "";
                IRepositoryTecnologico ra = new RepositoryTecnologico();
                List<Tecnologico> lista = new List<Tecnologico>();
                
                ra.addTecnologico();
                break;
            }
    case "5":
            {
                output = "";
                IRepositoryAlimentare ra = new RepositoryAlimentare();
                List<Alimentare> lista = new List<Alimentare>();

                ra.addAlimentare();
                break;
            }
    case "6":
            {
                Console.WriteLine("Inserire il codice dell'alimentare desiderato:");
                string ricerca = Console.ReadLine();
                output = "";
                IRepositoryAlimentare ra = new RepositoryAlimentare();
                List<Prodotto> lista = ra.getAlimentare();
                foreach (Prodotto p in lista)
                {
                    Alimentare ali = p as Alimentare;
                    if (ali.codice.Equals(ricerca))
                    {
                    output += ali.ToString() + "\r\n";
                    }
                  
                }
                break;
            }
    case "7":
            {
                Console.WriteLine("Inserire il la marca del prodotto tecnologico desiderato:");
                string ricerca = Console.ReadLine();
                output = "";
                IRepositoryTecnologico ra = new RepositoryTecnologico();
                List<Prodotto> lista = ra.getTecnologico();
                foreach (Prodotto p in lista)
                {
                    Tecnologico tec = p as Tecnologico;
                    if (tec.marca.Equals(ricerca))
                    {
                        output +=tec.ToString() + "\r\n";
                    }

                }
                break;
            }
    case "8":
            {
                output = "";
                IRepositoryTecnologico ra = new RepositoryTecnologico();
                List<Prodotto> lista = ra.getTecnologico();
                foreach (Prodotto p in lista)
                {
                    Tecnologico tec = p as Tecnologico;
                    if (tec.isNew)
                    {
                        output += tec.ToString() + "\r\n";
                    }
                }
                break;
            }
    case "9":
            {             
                output = "";
                IRepositoryAlimentare ra = new RepositoryAlimentare();
                List<Prodotto> lista = ra.getAlimentare();
                foreach (Prodotto p in lista)
                {
                    Alimentare ali = p as Alimentare;
                    if (DateTime.Compare(ali.scadenza, DateTime.Today)==0)
                    {
                        output += ali.ToString() + "\r\n";
                    }

                }
                break;
            }
    case "10":
            {
                output = "";
                IRepositoryAlimentare ra = new RepositoryAlimentare();
                List<Prodotto> lista = ra.getAlimentare();
                foreach (Prodotto p in lista)
                {
                    Alimentare ali = p as Alimentare;
                    if (ali.giorniScadenza<3)
                    {
                        output += ali.ToString() + "\r\n";
                    }

                }
                break;
            }
        default:
        {
        output = "";
        esci = true;
        break;      
        }
    } 
Console.WriteLine(output + "\r\n");
}
while(!esci);






