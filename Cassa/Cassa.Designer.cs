namespace Cassa
{
	partial class Cassa
	{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
			this.Pagine = new System.Windows.Forms.TabControl();
			this.PageAlimentare = new System.Windows.Forms.TabPage();
			this.SubPagine = new System.Windows.Forms.TabControl();
			this.PageAlimentareNormale = new System.Windows.Forms.TabPage();
			this.lbl_scadenza = new System.Windows.Forms.Label();
			this.date_scadenza = new System.Windows.Forms.DateTimePicker();
			this.btn_sendAlimentareSemplice = new System.Windows.Forms.Button();
			this.PageAlimentareFresco = new System.Windows.Forms.TabPage();
			this.txt_scadenzaFresco = new System.Windows.Forms.TextBox();
			this.lbl_scadenzaFresco = new System.Windows.Forms.Label();
			this.btn_sendAlimentareFresco = new System.Windows.Forms.Button();
			this.PageNonAlimentare = new System.Windows.Forms.TabPage();
			this.btn_riciclabile = new System.Windows.Forms.Button();
			this.lbl_riciclabile = new System.Windows.Forms.Label();
			this.txt_materiale = new System.Windows.Forms.TextBox();
			this.lbl_materiale = new System.Windows.Forms.Label();
			this.btn_sendNonAlimentare = new System.Windows.Forms.Button();
			this.GraphicTitle = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_prezzo = new System.Windows.Forms.Label();
			this.lbl_descrizione = new System.Windows.Forms.Label();
			this.lbl_codice = new System.Windows.Forms.Label();
			this.txt_descrizione = new System.Windows.Forms.TextBox();
			this.txt_codice = new System.Windows.Forms.TextBox();
			this.lbl_amount = new System.Windows.Forms.Label();
			this.txt_prezzo = new System.Windows.Forms.TextBox();
			this.txt_amount = new System.Windows.Forms.TextBox();
			this.Pagine.SuspendLayout();
			this.PageAlimentare.SuspendLayout();
			this.SubPagine.SuspendLayout();
			this.PageAlimentareNormale.SuspendLayout();
			this.PageAlimentareFresco.SuspendLayout();
			this.PageNonAlimentare.SuspendLayout();
			this.SuspendLayout();
			// 
			// Pagine
			// 
			this.Pagine.Controls.Add(this.PageAlimentare);
			this.Pagine.Controls.Add(this.PageNonAlimentare);
			this.Pagine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Pagine.Location = new System.Drawing.Point(10, 374);
			this.Pagine.Name = "Pagine";
			this.Pagine.SelectedIndex = 0;
			this.Pagine.Size = new System.Drawing.Size(355, 361);
			this.Pagine.TabIndex = 0;
			// 
			// PageAlimentare
			// 
			this.PageAlimentare.Controls.Add(this.SubPagine);
			this.PageAlimentare.Location = new System.Drawing.Point(4, 25);
			this.PageAlimentare.Name = "PageAlimentare";
			this.PageAlimentare.Padding = new System.Windows.Forms.Padding(3);
			this.PageAlimentare.Size = new System.Drawing.Size(347, 332);
			this.PageAlimentare.TabIndex = 0;
			this.PageAlimentare.Text = "Alimentare";
			this.PageAlimentare.UseVisualStyleBackColor = true;
			// 
			// SubPagine
			// 
			this.SubPagine.Controls.Add(this.PageAlimentareNormale);
			this.SubPagine.Controls.Add(this.PageAlimentareFresco);
			this.SubPagine.Location = new System.Drawing.Point(6, 6);
			this.SubPagine.Name = "SubPagine";
			this.SubPagine.SelectedIndex = 0;
			this.SubPagine.Size = new System.Drawing.Size(329, 323);
			this.SubPagine.TabIndex = 0;
			this.SubPagine.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.SubPagine_Selecting);
			// 
			// PageAlimentareNormale
			// 
			this.PageAlimentareNormale.Controls.Add(this.lbl_scadenza);
			this.PageAlimentareNormale.Controls.Add(this.date_scadenza);
			this.PageAlimentareNormale.Controls.Add(this.btn_sendAlimentareSemplice);
			this.PageAlimentareNormale.Location = new System.Drawing.Point(4, 25);
			this.PageAlimentareNormale.Name = "PageAlimentareNormale";
			this.PageAlimentareNormale.Padding = new System.Windows.Forms.Padding(3);
			this.PageAlimentareNormale.Size = new System.Drawing.Size(321, 294);
			this.PageAlimentareNormale.TabIndex = 0;
			this.PageAlimentareNormale.Text = "Semplice";
			this.PageAlimentareNormale.UseVisualStyleBackColor = true;
			// 
			// lbl_scadenza
			// 
			this.lbl_scadenza.AutoSize = true;
			this.lbl_scadenza.Location = new System.Drawing.Point(7, 27);
			this.lbl_scadenza.Name = "lbl_scadenza";
			this.lbl_scadenza.Size = new System.Drawing.Size(68, 16);
			this.lbl_scadenza.TabIndex = 30;
			this.lbl_scadenza.Text = "Scadenza";
			// 
			// date_scadenza
			// 
			this.date_scadenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.date_scadenza.Location = new System.Drawing.Point(10, 43);
			this.date_scadenza.Name = "date_scadenza";
			this.date_scadenza.Size = new System.Drawing.Size(210, 21);
			this.date_scadenza.TabIndex = 23;
			// 
			// btn_sendAlimentareSemplice
			// 
			this.btn_sendAlimentareSemplice.Location = new System.Drawing.Point(226, 30);
			this.btn_sendAlimentareSemplice.Name = "btn_sendAlimentareSemplice";
			this.btn_sendAlimentareSemplice.Size = new System.Drawing.Size(84, 217);
			this.btn_sendAlimentareSemplice.TabIndex = 22;
			this.btn_sendAlimentareSemplice.Text = "Invia";
			this.btn_sendAlimentareSemplice.UseVisualStyleBackColor = true;
			this.btn_sendAlimentareSemplice.Click += new System.EventHandler(this.SendAlimentareSemplice_Click);
			// 
			// PageAlimentareFresco
			// 
			this.PageAlimentareFresco.Controls.Add(this.txt_scadenzaFresco);
			this.PageAlimentareFresco.Controls.Add(this.lbl_scadenzaFresco);
			this.PageAlimentareFresco.Controls.Add(this.btn_sendAlimentareFresco);
			this.PageAlimentareFresco.Location = new System.Drawing.Point(4, 25);
			this.PageAlimentareFresco.Name = "PageAlimentareFresco";
			this.PageAlimentareFresco.Padding = new System.Windows.Forms.Padding(3);
			this.PageAlimentareFresco.Size = new System.Drawing.Size(321, 294);
			this.PageAlimentareFresco.TabIndex = 1;
			this.PageAlimentareFresco.Text = "Fresco";
			this.PageAlimentareFresco.UseVisualStyleBackColor = true;
			// 
			// txt_scadenzaFresco
			// 
			this.txt_scadenzaFresco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_scadenzaFresco.Location = new System.Drawing.Point(10, 197);
			this.txt_scadenzaFresco.Name = "txt_scadenzaFresco";
			this.txt_scadenzaFresco.Size = new System.Drawing.Size(187, 31);
			this.txt_scadenzaFresco.TabIndex = 31;
			// 
			// lbl_scadenzaFresco
			// 
			this.lbl_scadenzaFresco.AutoSize = true;
			this.lbl_scadenzaFresco.Location = new System.Drawing.Point(7, 178);
			this.lbl_scadenzaFresco.Name = "lbl_scadenzaFresco";
			this.lbl_scadenzaFresco.Size = new System.Drawing.Size(241, 16);
			this.lbl_scadenzaFresco.TabIndex = 30;
			this.lbl_scadenzaFresco.Text = "Numero giorni scadenza dopo apertura";
			// 
			// btn_sendAlimentareFresco
			// 
			this.btn_sendAlimentareFresco.Location = new System.Drawing.Point(226, 30);
			this.btn_sendAlimentareFresco.Name = "btn_sendAlimentareFresco";
			this.btn_sendAlimentareFresco.Size = new System.Drawing.Size(84, 217);
			this.btn_sendAlimentareFresco.TabIndex = 30;
			this.btn_sendAlimentareFresco.Text = "Invia";
			this.btn_sendAlimentareFresco.UseVisualStyleBackColor = true;
			// 
			// PageNonAlimentare
			// 
			this.PageNonAlimentare.Controls.Add(this.btn_riciclabile);
			this.PageNonAlimentare.Controls.Add(this.lbl_riciclabile);
			this.PageNonAlimentare.Controls.Add(this.txt_materiale);
			this.PageNonAlimentare.Controls.Add(this.lbl_materiale);
			this.PageNonAlimentare.Controls.Add(this.btn_sendNonAlimentare);
			this.PageNonAlimentare.Location = new System.Drawing.Point(4, 25);
			this.PageNonAlimentare.Name = "PageNonAlimentare";
			this.PageNonAlimentare.Padding = new System.Windows.Forms.Padding(3);
			this.PageNonAlimentare.Size = new System.Drawing.Size(347, 332);
			this.PageNonAlimentare.TabIndex = 1;
			this.PageNonAlimentare.Text = "NonAlimentare";
			this.PageNonAlimentare.UseVisualStyleBackColor = true;
			// 
			// btn_riciclabile
			// 
			this.btn_riciclabile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_riciclabile.Location = new System.Drawing.Point(104, 158);
			this.btn_riciclabile.Name = "btn_riciclabile";
			this.btn_riciclabile.Size = new System.Drawing.Size(52, 33);
			this.btn_riciclabile.TabIndex = 34;
			this.btn_riciclabile.Text = "Si";
			this.btn_riciclabile.UseVisualStyleBackColor = true;
			// 
			// lbl_riciclabile
			// 
			this.lbl_riciclabile.AutoSize = true;
			this.lbl_riciclabile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_riciclabile.Location = new System.Drawing.Point(16, 155);
			this.lbl_riciclabile.Name = "lbl_riciclabile";
			this.lbl_riciclabile.Size = new System.Drawing.Size(82, 36);
			this.lbl_riciclabile.TabIndex = 33;
			this.lbl_riciclabile.Text = "Riciclabile?\r\nNo";
			this.lbl_riciclabile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txt_materiale
			// 
			this.txt_materiale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_materiale.Location = new System.Drawing.Point(20, 73);
			this.txt_materiale.Name = "txt_materiale";
			this.txt_materiale.Size = new System.Drawing.Size(204, 31);
			this.txt_materiale.TabIndex = 32;
			// 
			// lbl_materiale
			// 
			this.lbl_materiale.AutoSize = true;
			this.lbl_materiale.Location = new System.Drawing.Point(17, 57);
			this.lbl_materiale.Name = "lbl_materiale";
			this.lbl_materiale.Size = new System.Drawing.Size(63, 16);
			this.lbl_materiale.TabIndex = 31;
			this.lbl_materiale.Text = "Materiale";
			// 
			// btn_sendNonAlimentare
			// 
			this.btn_sendNonAlimentare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btn_sendNonAlimentare.Location = new System.Drawing.Point(236, 57);
			this.btn_sendNonAlimentare.Name = "btn_sendNonAlimentare";
			this.btn_sendNonAlimentare.Size = new System.Drawing.Size(84, 217);
			this.btn_sendNonAlimentare.TabIndex = 30;
			this.btn_sendNonAlimentare.Text = "Invia";
			this.btn_sendNonAlimentare.UseVisualStyleBackColor = true;
			// 
			// GraphicTitle
			// 
			this.GraphicTitle.BackColor = System.Drawing.Color.Black;
			this.GraphicTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GraphicTitle.ForeColor = System.Drawing.Color.White;
			this.GraphicTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.GraphicTitle.Location = new System.Drawing.Point(596, 1);
			this.GraphicTitle.Name = "GraphicTitle";
			this.GraphicTitle.Size = new System.Drawing.Size(400, 40);
			this.GraphicTitle.TabIndex = 16;
			this.GraphicTitle.Text = "REGISTRATORE DI CASSA";
			this.GraphicTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.DimGray;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Location = new System.Drawing.Point(207, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 45);
			this.label1.TabIndex = 17;
			this.label1.Text = "Articolo";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_prezzo
			// 
			this.lbl_prezzo.AutoSize = true;
			this.lbl_prezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_prezzo.Location = new System.Drawing.Point(31, 221);
			this.lbl_prezzo.Name = "lbl_prezzo";
			this.lbl_prezzo.Size = new System.Drawing.Size(97, 16);
			this.lbl_prezzo.TabIndex = 21;
			this.lbl_prezzo.Text = "Prezzo Unitario";
			// 
			// lbl_descrizione
			// 
			this.lbl_descrizione.AutoSize = true;
			this.lbl_descrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_descrizione.Location = new System.Drawing.Point(31, 157);
			this.lbl_descrizione.Name = "lbl_descrizione";
			this.lbl_descrizione.Size = new System.Drawing.Size(78, 16);
			this.lbl_descrizione.TabIndex = 20;
			this.lbl_descrizione.Text = "Descrizione";
			// 
			// lbl_codice
			// 
			this.lbl_codice.AutoSize = true;
			this.lbl_codice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_codice.Location = new System.Drawing.Point(31, 98);
			this.lbl_codice.Name = "lbl_codice";
			this.lbl_codice.Size = new System.Drawing.Size(98, 16);
			this.lbl_codice.TabIndex = 19;
			this.lbl_codice.Text = "Codice Articolo";
			// 
			// txt_descrizione
			// 
			this.txt_descrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_descrizione.Location = new System.Drawing.Point(34, 173);
			this.txt_descrizione.Name = "txt_descrizione";
			this.txt_descrizione.Size = new System.Drawing.Size(204, 31);
			this.txt_descrizione.TabIndex = 18;
			// 
			// txt_codice
			// 
			this.txt_codice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_codice.Location = new System.Drawing.Point(34, 114);
			this.txt_codice.MaxLength = 20;
			this.txt_codice.Name = "txt_codice";
			this.txt_codice.Size = new System.Drawing.Size(204, 31);
			this.txt_codice.TabIndex = 25;
			// 
			// lbl_amount
			// 
			this.lbl_amount.AutoSize = true;
			this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_amount.Location = new System.Drawing.Point(31, 281);
			this.lbl_amount.Name = "lbl_amount";
			this.lbl_amount.Size = new System.Drawing.Size(56, 16);
			this.lbl_amount.TabIndex = 26;
			this.lbl_amount.Text = "Quantità";
			// 
			// txt_prezzo
			// 
			this.txt_prezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_prezzo.Location = new System.Drawing.Point(34, 237);
			this.txt_prezzo.Name = "txt_prezzo";
			this.txt_prezzo.Size = new System.Drawing.Size(204, 31);
			this.txt_prezzo.TabIndex = 28;
			// 
			// txt_amount
			// 
			this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_amount.Location = new System.Drawing.Point(34, 300);
			this.txt_amount.Name = "txt_amount";
			this.txt_amount.Size = new System.Drawing.Size(204, 31);
			this.txt_amount.TabIndex = 29;
			// 
			// Cassa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1710, 745);
			this.Controls.Add(this.txt_amount);
			this.Controls.Add(this.txt_prezzo);
			this.Controls.Add(this.lbl_amount);
			this.Controls.Add(this.txt_codice);
			this.Controls.Add(this.lbl_prezzo);
			this.Controls.Add(this.lbl_descrizione);
			this.Controls.Add(this.lbl_codice);
			this.Controls.Add(this.txt_descrizione);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.GraphicTitle);
			this.Controls.Add(this.Pagine);
			this.Name = "Cassa";
			this.Text = "Cassa";
			this.Pagine.ResumeLayout(false);
			this.PageAlimentare.ResumeLayout(false);
			this.SubPagine.ResumeLayout(false);
			this.PageAlimentareNormale.ResumeLayout(false);
			this.PageAlimentareNormale.PerformLayout();
			this.PageAlimentareFresco.ResumeLayout(false);
			this.PageAlimentareFresco.PerformLayout();
			this.PageNonAlimentare.ResumeLayout(false);
			this.PageNonAlimentare.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl Pagine;
		private System.Windows.Forms.TabPage PageAlimentare;
		private System.Windows.Forms.TabPage PageNonAlimentare;
		private System.Windows.Forms.TabControl SubPagine;
		private System.Windows.Forms.TabPage PageAlimentareNormale;
		private System.Windows.Forms.TabPage PageAlimentareFresco;
		private System.Windows.Forms.Label GraphicTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_sendAlimentareSemplice;
		private System.Windows.Forms.Label lbl_prezzo;
		private System.Windows.Forms.Label lbl_descrizione;
		private System.Windows.Forms.Label lbl_codice;
		private System.Windows.Forms.TextBox txt_descrizione;
		private System.Windows.Forms.TextBox txt_codice;
		private System.Windows.Forms.Label lbl_amount;
		private System.Windows.Forms.TextBox txt_prezzo;
		private System.Windows.Forms.TextBox txt_amount;
		private System.Windows.Forms.Button btn_sendAlimentareFresco;
		private System.Windows.Forms.Button btn_sendNonAlimentare;
		private System.Windows.Forms.DateTimePicker date_scadenza;
		private System.Windows.Forms.TextBox txt_scadenzaFresco;
		private System.Windows.Forms.Label lbl_scadenzaFresco;
		private System.Windows.Forms.Label lbl_scadenza;
		private System.Windows.Forms.Label lbl_riciclabile;
		private System.Windows.Forms.TextBox txt_materiale;
		private System.Windows.Forms.Label lbl_materiale;
		private System.Windows.Forms.Button btn_riciclabile;
	}
}
