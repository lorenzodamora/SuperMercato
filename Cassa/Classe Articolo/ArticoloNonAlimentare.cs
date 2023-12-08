namespace Cassa
{
	internal class ArticoloNonAlimentare : Articolo
	{
		private string _materiale;
		public string Materiale
		{
			get => _materiale;
			private set => _materiale = value;
		}

		private bool _isRiciclabile;
		public bool Riciclable
		{
			get => _isRiciclabile;
			private set => _isRiciclabile = value;
		}

		public ArticoloNonAlimentare() : base()
		{
			Materiale = "Aria";
			Riciclable = true;
		}

		public ArticoloNonAlimentare(
			string codice,
			string descrizione,
			float prezzo,
			string materiale,
			bool isRiciclabile)
			: base(codice, descrizione, prezzo)
		{
			Materiale = materiale;
			Riciclable = isRiciclabile;
		}

		public ArticoloNonAlimentare(ArticoloNonAlimentare articolo)
			: this(articolo.Codice,
			articolo.Descrizione,
			articolo.PrezzoUnitario,
			articolo.Materiale,
			articolo.Riciclable)
		{ }

		public new ArticoloNonAlimentare Clone() => (ArticoloNonAlimentare)MemberwiseClone();

		public override bool Equals(object obj) => Equals(obj as ArticoloNonAlimentare);

		public bool Equals(ArticoloNonAlimentare art)
			=> art != null
			&& Codice == art.Codice
			&& Descrizione == art.Descrizione
			&& PrezzoUnitario == art.PrezzoUnitario
			&& Materiale == art.Materiale
			&& Riciclable == art.Riciclable;

		public override int GetHashCode() => (Codice, Descrizione, PrezzoUnitario, Materiale, Riciclable).GetHashCode();

		public static explicit operator ArticoloNonAlimentare(string[] v)
	=> new ArticoloNonAlimentare(v[0], v[1], float.Parse(v[2]), v[3], v[4] == "Si");

		public override string ToString() => $"{base.ToString()};{Materiale};{Riciclable}";

		//metodo sconta
		public override float Sconta(bool carta)
		{
			float finale = PrezzoUnitario;
			if(carta) finale -= finale * 5 / 100;
			if(Riciclable) finale -= finale * 10 / 100;
			return (float)System.Math.Round(finale, 2);
		}
	}
}
