using System;

namespace Cassa
{
	internal class Articolo : IEquatable<Articolo>
	{
		private string _codice;
		public string Codice
		{
			get => _codice;
			private set
			{
				if(System.Linq.Enumerable.All(value, char.IsDigit) && !string.IsNullOrEmpty(value))
					_codice = value;
				else throw new ArgumentException("Il codice deve essere esclusivamente numerico [0-9]");
			}
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
			_codice = "1";
			_descrizione = "Articolo Predefinito";
			_prezzo = 0.01f;
		}

		public Articolo(string codice, string descrizione, float prezzo)
		{
			Codice = codice;
			Descrizione = descrizione;
			PrezzoUnitario = prezzo;
		}

		public Articolo(Articolo articolo)
			: this(articolo.Codice, articolo.Descrizione, articolo.PrezzoUnitario) { }

		public Articolo Clone() => (Articolo)MemberwiseClone();

		public override bool Equals(object obj) => Equals(obj as Articolo);

		public bool Equals(Articolo art)
			=> art != null && Codice == art.Codice && Descrizione == art.Descrizione && PrezzoUnitario == art.PrezzoUnitario;

		public override int GetHashCode() => (Codice, Descrizione, PrezzoUnitario).GetHashCode();

		public static explicit operator Articolo(string[] v)
			=> new Articolo(v[0], v[1], float.Parse(v[2]));

		public override string ToString() => $"{Codice};{Descrizione};{PrezzoUnitario}";

		public virtual float Sconta(bool carta)
		{
			if(carta)
				return (float)Math.Round(PrezzoUnitario - PrezzoUnitario * 5 / 100, 2);
			return PrezzoUnitario;
		}
	}
}
