using System;

namespace Cassa
{
	internal class Articolo : IEquatable<Articolo>
	{
		private string _codice;
		public string Codice
		{
			get => _codice;
			private set => _codice = value;
		}

		private string _descrizione;
		public string Descrizione
		{
			get => _descrizione;
			private set => _descrizione = value;
		}

		private float _prezzo;
		public float PrezzoUnitario
		{
			get => _prezzo;
			private set
			{
				if(value <= 0) throw new ArgumentException("prezzo maggiore di 0");
				_prezzo = value;
			}
		}

		public Articolo()
		{
			_codice = null;
			_descrizione = null;
			_prezzo = 0;
		}

		public Articolo(string codice, string descrizione, float prezzo)
		{
			Codice = codice;
			Descrizione = descrizione;
			PrezzoUnitario = prezzo;
		}

		public Articolo(Articolo ap)
			: this(ap.Codice, ap.Descrizione, ap.PrezzoUnitario) { }

		public Articolo Clone() => (Articolo)MemberwiseClone();

		public override bool Equals(object obj) => Equals(obj as Articolo);

		public bool Equals(Articolo art)
			=> art != null && Codice == art.Codice && Descrizione == art.Descrizione && PrezzoUnitario == art.PrezzoUnitario;

		public override int GetHashCode() => (Codice, Descrizione, PrezzoUnitario).GetHashCode();

		public override string ToString() => $"{Codice};{Descrizione};{PrezzoUnitario}";

		public virtual float Sconta(bool carta)
		{
			if(carta)
				return (float)Math.Round(PrezzoUnitario - PrezzoUnitario * 5 / 100, 2);
			return PrezzoUnitario;
		}
	}
}
