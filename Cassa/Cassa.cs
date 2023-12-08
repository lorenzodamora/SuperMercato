﻿using System;
using System.Windows.Forms;

namespace Cassa
{
	public partial class Cassa : Form
	{
		/// <summary> Struct che contiene anche array che si resize-ano. </summary>
		internal struct Scontrino
		{
			internal Articolo[] _articoli;
			internal int[] _amount;
			private float _totale;
			private int _count;
			private int _size;

			public float Totale => _totale;
			public float Count => _count;
			public float Size => _size;

			/// <summary> Attenzione! non ci sono controlli implementati.</summary>
			public Scontrino(int size)
			{
				_articoli = new Articolo[size];
				_amount = new int[size];
				_count = 0;
				_totale = 0;
				_size = size;
			}

			/// <summary> Attenzione! Modifica del totale non implementata. </summary>
			public Articolo this[int index]
			{
				get
				{
					if(index >= 0 && index < _count+1)
						return _articoli[index];
					else
						throw new IndexOutOfRangeException("Index out of range.");
				}
				set
				{
					if(index >= 0 && index < _count+1)
						_articoli[index] = value;
					else
						throw new IndexOutOfRangeException("Index out of range.");
				}
			}

			public int GetAmount(int index)
			{
				if(index >= 0 && index < _count + 1)
					return _amount[index];
				else
					throw new IndexOutOfRangeException("Index out of range.");
			}
			/// <summary> Attenzione! Modifica del totale non implementata. </summary>
			public void SetAmount(int index, int amount)
			{
				if(index >= 0 && index < _count + 1)
					_amount[index] = amount;
				else
					throw new IndexOutOfRangeException("Index out of range.");
			}

			private static void Resize(ref Scontrino scontrino, int newSize)
			{
				if(scontrino._size == newSize) return;

				Scontrino s2 = new Scontrino(newSize);
				if(scontrino._size < newSize) //se newsize è più grande, copia fino ad array.length e il resto rimane default
					for(int i = 0; i < scontrino._size; ++i)
						s2.Add(scontrino[i], scontrino.GetAmount(i));
				else //se newsize è più piccolo copia fino a newsize
					for(int i = 0; i < newSize; i++)
						s2.Add(scontrino[i], scontrino.GetAmount(i));
				s2._size = newSize;
				scontrino = s2;
			}

			public void Add(Articolo articolo, int amount)
			{
				int GetLength(int tot)
				{
					if(tot < 20) return 20;
					return tot/20 * 20 + 20;
				}
				if(_count == _size)
					Resize(ref this, GetLength(_size));
				_articoli[_count] = articolo;
				_amount[_count++] = amount;
				_totale += articolo.PrezzoUnitario * amount;
			}

		}

		Scontrino scontrino = new Scontrino(20);
		public Cassa()
		{
			InitializeComponent();
		}

		/// <summary> Switch grafico del dateTimePicker </summary>
		void SubPagine_Selecting(object sender, TabControlCancelEventArgs e)
		{
			if((sender as TabControl).SelectedTab == PageAlimentareFresco)
			{
				PageAlimentareNormale.Controls.Remove(lbl_scadenza);
				PageAlimentareNormale.Controls.Remove(date_scadenza);
				PageAlimentareFresco.Controls.Add(lbl_scadenza);
				PageAlimentareFresco.Controls.Add(date_scadenza);
				return;
			}
			PageAlimentareFresco.Controls.Remove(lbl_scadenza);
			PageAlimentareFresco.Controls.Remove(date_scadenza);
			PageAlimentareNormale.Controls.Add(lbl_scadenza);
			PageAlimentareNormale.Controls.Add(date_scadenza);
		}

		private void SendAlimentareSemplice_Click(object sender, EventArgs e)
		{
			if(CheckArticolo() || CheckScadenza()) return;

			string[] articolo = (
				$"{txt_codice.Text.Trim()};" +
				$"{txt_descrizione.Text};" +
				$"{txt_prezzo.Text.Trim()};" +
				$"{txt_amount.Text.Trim()};" +
				$"{(CustomDate)date_scadenza.Value}"
			).Split(';');

			var item = new ListViewItem((view_alimentareSemplice.Items.Count+1).ToString());
			foreach(string articoloitem in articolo)
				item.SubItems.Add(articoloitem);
			view_alimentareSemplice.Items.Add(item);

			var item_ = item.Clone() as ListViewItem;
				item_.Text = (view_articolo.Items.Count+1).ToString();
			item_.SubItems[5].Text = "alimentare";
			item_.SubItems.Add($"scadenza: {(CustomDate)date_scadenza.Value}");
			view_articolo.Items.Add(item_);

			scontrino.Add(
				(ArticoloAlimentare)(new string[]{ articolo[0], articolo[1], articolo[2], articolo[4] }),
				int.Parse(articolo[3])
			);
		}

		/// <returns>true se c'è errore.</returns>
		private bool CheckArticolo()
		{
			string errore = "Errore nell'inserimento";
			string codice = txt_codice.Text.Trim();
			string prezzo = txt_prezzo.Text.Trim();
			string amount = txt_amount.Text.Trim();
			if(codice == "" || txt_descrizione.Text == "" || prezzo == "" || amount == "")
			{
				MessageBox.Show("Riempi almeno le TextBox: Codice, Descrizione, Prezzo, Quantità.", errore);
				return true;
			}
			if(!System.Linq.Enumerable.All(codice, char.IsDigit))
			{
				MessageBox.Show("Il Codice deve essere solo numerico [0-9]", errore);
				return true;
			}

			/// <summary>funzione locale</summary>
			/// <returns>true se è valido.</returns>
			bool IsValidPrice(string input)
			{
				/**
				 * Espressione regolare per un prezzo con massimo due cifre decimali
				 * Ecco una spiegazione dettagliata:
				 * - ^: Rappresenta l'inizio della stringa.
				 * - \d+: Corrisponde a uno o più cifre (0-9).
				 * - (: Inizia un gruppo di cattura.
				 * - \.: Corrisponde a un punto decimale.
				 * - \d{1,2}: Corrisponde a una o due cifre decimali.
				 * - ): Chiude il gruppo di cattura.
				 * - ?: Indica che il gruppo di cattura precedente (il punto decimale seguito da una o due cifre decimali) può essere presente o assente.
				 * - $: Rappresenta la fine della stringa.
				 */
				string pattern = @"^\d+(\.\d{1,2})?$";
				// Verifica se la stringa corrisponde al pattern
				if(System.Text.RegularExpressions.Regex.IsMatch(input, pattern))
				{
					// Converte la stringa in un numero per ulteriori controlli
					if(float.TryParse(input, out float price))
					{
						// Controlla che il numero sia positivo
						return price > 0;
					}
				}
				return false;
			}

			if(!IsValidPrice(prezzo))
			{
				MessageBox.Show("Il prezzo non è valido", errore);
				return true;
			}
			if(!int.TryParse(amount, out int amount_) || amount_ < 1)
			{
				MessageBox.Show("La quantità non è valida", errore);
				return true;
			}

			return false;
		}

		/// <returns>true se c'è errore.</returns>
		private bool CheckScadenza()
		{
			if(date_scadenza.Value < DateTime.Today)
			{
				MessageBox.Show("L'articolo è già scaduto.", "Articolo non vendibile");
				return true;
			}
			return false;
		}
	}
}
