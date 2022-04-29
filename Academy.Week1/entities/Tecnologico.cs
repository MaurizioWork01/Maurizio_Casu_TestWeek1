using System;

namespace entities
{

	public class Tecnologico : Prodotto 
	{
		public string marca { get; set; }
		public bool isNew { get; set; }


		public Tecnologico()
		{


		}
        public override string ToString()
        {
            return  $"Codice: {base.codice}\r\n" +
                    $"Descrizione: {base.descrizione}\r\n" +
                    $"Prezzo: {base.prezzo} euro\r\n" +
                    $"Marca: {marca}\r\n" +
                    $"Nuovo: {(isNew ? "true" : "false")}\r\n";
        }
    }
}
