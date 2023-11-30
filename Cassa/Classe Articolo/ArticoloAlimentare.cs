namespace Cassa
{
	internal class ArticoloAlimentare : Articolo
	{
		private CustomDate _scadenza;
		public CustomDate DataScadenza
		{
			get => _scadenza;
			private set => _scadenza = value;
		}

		public ArticoloAlimentare() : base() => DataScadenza = CustomDate.Today;

		public ArticoloAlimentare(string codice, string descrizione, float prezzo, CustomDate scadenza)
			: base(codice, descrizione, prezzo)
			=> DataScadenza = scadenza;

		public ArticoloAlimentare(ArticoloAlimentare ap) : this(ap.Codice, ap.Descrizione, ap.PrezzoUnitario, ap.DataScadenza) { }

		//metodo Clone
		new public ArticoloAlimentare Clone() => (ArticoloAlimentare)MemberwiseClone(); //new ?

		//metodo Equals
		public override bool Equals(object obj) => Equals(obj as ArticoloAlimentare);

		public bool Equals(ArticoloAlimentare art)
			=> art != null && Codice == art.Codice && Descrizione == art.Descrizione && PrezzoUnitario == art.PrezzoUnitario && DataScadenza == art.DataScadenza;

		//metodo GetHashCode
		public override int GetHashCode() => (Codice, Descrizione, PrezzoUnitario, DataScadenza).GetHashCode();

		//metodo ToString
		public override string ToString() => base.ToString() + ";" + DataScadenza.ToString();

		//metodo sconta
		public override float Sconta(bool c)
		{
			float ps = PrezzoUnitario;
			if(c) ps -= ps * 5 / 100;
			if(DataScadenza.Year == CustomDate.Today.Year)
				ps -= ps * 20 / 100;
			return (float)System.Math.Round(ps, 2);
		}
	}
}
