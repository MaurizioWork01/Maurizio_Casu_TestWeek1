using Academy.Week1.interfaces;
using System;

namespace entities
{

	public abstract class Prodotto 
	{
			public string codice  { get; set; }
			public string descrizione  { get; set; }
			public double prezzo  { get; set; }


        public List<Prodotto> PrintAll()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return  $"Codice: {codice}\r\n" +
                    $"Descrizione: {descrizione}\r\n" +
                    $"Prezzo: {prezzo} euro\r\n";
        }   
    }
}
