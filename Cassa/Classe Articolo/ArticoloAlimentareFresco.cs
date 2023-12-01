namespace Cassa
{
	internal class ArticoloAlimentareFresco : ArticoloAlimentare
	{
		private int _numgiorni;
		public int NumGiorni
		{
			get => _numgiorni;
			private set
			{
				if(value < 6 && value > 0)
					_numgiorni = value;
				else throw new System.ArgumentOutOfRangeException("da 1 a 5");
			}
		}

		public ArticoloAlimentareFresco() : base() => NumGiorni = 1;

		/// <param name="giorniScadenza">numero giorni di scadenza del prodotto dopo l'apertura</param>
		public ArticoloAlimentareFresco(
			string codice,
			string descrizione,
			float prezzo,
			CustomDate scadenza,
			int giorniScadenza)
			: base(codice, descrizione, prezzo, scadenza)
			=> NumGiorni = giorniScadenza;

		public ArticoloAlimentareFresco(ArticoloAlimentareFresco articolo)
			: this(articolo.Codice,
					articolo.Descrizione,
					articolo.PrezzoUnitario,
					articolo.DataScadenza,
					articolo.NumGiorni) { }

		public new ArticoloAlimentareFresco Clone() => (ArticoloAlimentareFresco)MemberwiseClone();

		public override bool Equals(object obj) => Equals(obj as ArticoloAlimentareFresco);

		public bool Equals(ArticoloAlimentareFresco art)
			=> art != null
			&& Codice == art.Codice
			&& Descrizione == art.Descrizione
			&& PrezzoUnitario == art.PrezzoUnitario
			&& DataScadenza == art.DataScadenza
			&& NumGiorni == art.NumGiorni;

		public override int GetHashCode() => (Codice, Descrizione, PrezzoUnitario, DataScadenza, NumGiorni).GetHashCode();

		public override string ToString() => $"{base.ToString()};{NumGiorni}";

		public override float Sconta(bool carta)
		{
			float finale = PrezzoUnitario;
			if(carta) finale -= finale * 5 / 100;
			return (float)System.Math.Round(finale - finale * 2 * (6 - NumGiorni) / 100, 2);
		}
	}
}
