using System;
using System.Windows.Forms;

namespace Cassa
{
	/*
	 * articoli: codice, descrizione, prezzo unitario.
	 * classe Articolo: metodo sconta() -5% in caso di carta fedeltà.
	 * suddividere articoli in:
	 * - articoli alimentari: anno di scadenza
	 * - + Alimentari freschi: scadenza (in n giorni) (max 5).
	 * - non alimentari: materiale principale, se è riciclabile
	 * 
	 * ridefinire il metodo sconta() in base alle seguenti regole:
	 * - articoli alimentari: sconto +20% se l’anno di scadenza è quello attuale;
	 * - alimentari freschi, sconto + (2*(6 - g))%
	 * - non al: sconto +10% se materiale riciclabile. 
	 * 
	 * diagramma UML + programma windows form: simulare la cassa:
	 * - inserire le info degli articoli, distinguendoli
	 * - se il cliente dispone della tessera fedeltà sconto 5%
	 * - applicare gli sconti
	 * 
	 * Terminato l’inserimento, visualizzare lo scontrino:
	 * - nome articoli
	 * - prezzo unitario
	 * - eventuale sconto
	 * - importo totale da pagare.
	 * 
	 * Utilizzare un array per memorizzare le informazioni degli articoli inseriti.
	 */
	internal static class Starter
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Cassa());
		}
	}
}
