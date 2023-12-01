namespace Cassa
{
	internal class ArticoloAlimentare : Articolo
	{
		/** Struct con anno, mese e giorno, creata per evitare DateTime */
		private CustomDate _scadenza;
		public CustomDate DataScadenza
		{
			get => _scadenza;
			private set => _scadenza = value;
		}

		public ArticoloAlimentare() : base() => DataScadenza = new CustomDate(1);

		public ArticoloAlimentare(string codice, string descrizione, float prezzo, CustomDate scadenza)
			: base(codice, descrizione, prezzo)
			=> DataScadenza = scadenza;

		public ArticoloAlimentare(ArticoloAlimentare articolo)
			: this(articolo.Codice, articolo.Descrizione, articolo.PrezzoUnitario, articolo.DataScadenza)
		{ }

		//metodo Clone
		public new ArticoloAlimentare Clone() => (ArticoloAlimentare)MemberwiseClone(); //new ?

		//metodo Equals
		public override bool Equals(object obj) => Equals(obj as ArticoloAlimentare);

		public bool Equals(ArticoloAlimentare art)
			=> art != null
			&& Codice == art.Codice
			&& Descrizione == art.Descrizione
			&& PrezzoUnitario == art.PrezzoUnitario
			&& DataScadenza == art.DataScadenza;

		//metodo GetHashCode
		public override int GetHashCode() => (Codice, Descrizione, PrezzoUnitario, DataScadenza).GetHashCode();

		//metodo ToString
		public override string ToString() => $"{base.ToString()};{DataScadenza}";

		//metodo sconta
		public override float Sconta(bool carta)
		{
			float finale = PrezzoUnitario;
			if(carta) finale -= finale * 5 / 100;
			if(DataScadenza.Year == CustomDate.ThisYear)
				finale -= finale * 20 / 100;
			return (float)System.Math.Round(finale, 2);
		}
	}
}
