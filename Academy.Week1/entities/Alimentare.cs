using System;

namespace entities
{


	public class Alimentare : Prodotto
	{
		public int quantita { get; set; }
		public DateTime scadenza { get; set; }
		public int giorniScadenza { get; set; }


		public Alimentare()
		{


		}
        public override string ToString()
        {
         return $"Codice: {base.codice}\r\n" +
                $"Descrizione: {base.descrizione}\r\n" +
                $"Prezzo: {base.prezzo} euro\r\n" +
                $"Quantità: {quantita}\r\n" +
                $"Data di Scadenza: {scadenza.ToShortDateString()}\r\n" +
                $"Giorni prima della data di scadenza: {giorniScadenza}\r\n";
        }
    }

}