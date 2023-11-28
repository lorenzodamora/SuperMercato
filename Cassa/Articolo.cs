using System;

namespace Cassa
{
	internal class Articolo : IEquatable<Articolo>
	{
		//properties
		public int Codice { get; set; } = 0;
		public string Descrizione { get; set; } = null;
		private float _prezzo = 0;
		public float PrezzoUnitario
		{
			get => _prezzo;
			private set => SetPrezzo(value);
		}

		public Articolo() => throw new NotImplementedException();

		public Articolo(int codice, string descrizione, float prezzo)
		{
			Codice = codice;
			Descrizione = descrizione;
			SetPrezzo(prezzo);
		}

		//costruttore di copia
		public Articolo(Articolo ap)
			: this(ap.Codice, ap.Descrizione, ap.PrezzoUnitario) { }

		private void SetPrezzo(float prezzo)
		{
			if(prezzo <= 0) throw new ArgumentException("prezzo maggiore di 0");
			_prezzo = prezzo;
		}

		//metodo Clone
		public virtual Articolo Clone() => (Articolo)MemberwiseClone();

		//metodo Equals
		public override bool Equals(object obj) => Equals(obj as Articolo);

		public bool Equals(Articolo art) => art != null && Codice == art.Codice && Descrizione == art.Descrizione && PrezzoUnitario == art.PrezzoUnitario;

		//metodo GetHashCode
		public override int GetHashCode() => (Codice, Descrizione, PrezzoUnitario).GetHashCode();

		//metodo ToString
		public override string ToString() => Codice.ToString() + ";" + Descrizione.ToString() + ";" + PrezzoUnitario.ToString();

		//metodo sconta
		public virtual float Sconta(bool carta)
		{
			if(carta)
				return (float)Math.Round(PrezzoUnitario - PrezzoUnitario * 5 / 100, 2);
			return PrezzoUnitario;
		}
	}
}
