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
			this.PageNonAlimentare = new System.Windows.Forms.TabPage();
			this.SubPagine = new System.Windows.Forms.TabControl();
			this.PageAlimentareNormale = new System.Windows.Forms.TabPage();
			this.PageAlimentareFresco = new System.Windows.Forms.TabPage();
			this.GraphicTitle = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_send = new System.Windows.Forms.Button();
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
			this.SuspendLayout();
			// 
			// Pagine
			// 
			this.Pagine.Controls.Add(this.PageAlimentare);
			this.Pagine.Controls.Add(this.PageNonAlimentare);
			this.Pagine.Location = new System.Drawing.Point(10, 374);
			this.Pagine.Name = "Pagine";
			this.Pagine.SelectedIndex = 0;
			this.Pagine.Size = new System.Drawing.Size(740, 361);
			this.Pagine.TabIndex = 0;
			// 
			// PageAlimentare
			// 
			this.PageAlimentare.Controls.Add(this.SubPagine);
			this.PageAlimentare.Location = new System.Drawing.Point(4, 22);
			this.PageAlimentare.Name = "PageAlimentare";
			this.PageAlimentare.Padding = new System.Windows.Forms.Padding(3);
			this.PageAlimentare.Size = new System.Drawing.Size(732, 335);
			this.PageAlimentare.TabIndex = 0;
			this.PageAlimentare.Text = "Alimentare";
			this.PageAlimentare.UseVisualStyleBackColor = true;
			// 
			// PageNonAlimentare
			// 
			this.PageNonAlimentare.Location = new System.Drawing.Point(4, 22);
			this.PageNonAlimentare.Name = "PageNonAlimentare";
			this.PageNonAlimentare.Padding = new System.Windows.Forms.Padding(3);
			this.PageNonAlimentare.Size = new System.Drawing.Size(732, 335);
			this.PageNonAlimentare.TabIndex = 1;
			this.PageNonAlimentare.Text = "NonAlimentare";
			this.PageNonAlimentare.UseVisualStyleBackColor = true;
			// 
			// SubPagine
			// 
			this.SubPagine.Controls.Add(this.PageAlimentareNormale);
			this.SubPagine.Controls.Add(this.PageAlimentareFresco);
			this.SubPagine.Location = new System.Drawing.Point(6, 6);
			this.SubPagine.Name = "SubPagine";
			this.SubPagine.SelectedIndex = 0;
			this.SubPagine.Size = new System.Drawing.Size(720, 323);
			this.SubPagine.TabIndex = 0;
			// 
			// PageAlimentareNormale
			// 
			this.PageAlimentareNormale.Location = new System.Drawing.Point(4, 22);
			this.PageAlimentareNormale.Name = "PageAlimentareNormale";
			this.PageAlimentareNormale.Padding = new System.Windows.Forms.Padding(3);
			this.PageAlimentareNormale.Size = new System.Drawing.Size(712, 297);
			this.PageAlimentareNormale.TabIndex = 0;
			this.PageAlimentareNormale.Text = "Semplice";
			this.PageAlimentareNormale.UseVisualStyleBackColor = true;
			// 
			// PageAlimentareFresco
			// 
			this.PageAlimentareFresco.Location = new System.Drawing.Point(4, 22);
			this.PageAlimentareFresco.Name = "PageAlimentareFresco";
			this.PageAlimentareFresco.Padding = new System.Windows.Forms.Padding(3);
			this.PageAlimentareFresco.Size = new System.Drawing.Size(712, 297);
			this.PageAlimentareFresco.TabIndex = 1;
			this.PageAlimentareFresco.Text = "Fresco";
			this.PageAlimentareFresco.UseVisualStyleBackColor = true;
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
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Location = new System.Drawing.Point(207, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 40);
			this.label1.TabIndex = 17;
			this.label1.Text = "Articolo";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_send
			// 
			this.btn_send.Location = new System.Drawing.Point(266, 114);
			this.btn_send.Name = "btn_send";
			this.btn_send.Size = new System.Drawing.Size(84, 217);
			this.btn_send.TabIndex = 22;
			this.btn_send.Text = "Invia";
			this.btn_send.UseVisualStyleBackColor = true;
			// 
			// lbl_prezzo
			// 
			this.lbl_prezzo.AutoSize = true;
			this.lbl_prezzo.Location = new System.Drawing.Point(31, 221);
			this.lbl_prezzo.Name = "lbl_prezzo";
			this.lbl_prezzo.Size = new System.Drawing.Size(78, 13);
			this.lbl_prezzo.TabIndex = 21;
			this.lbl_prezzo.Text = "Prezzo Unitario";
			// 
			// lbl_descrizione
			// 
			this.lbl_descrizione.AutoSize = true;
			this.lbl_descrizione.Location = new System.Drawing.Point(31, 157);
			this.lbl_descrizione.Name = "lbl_descrizione";
			this.lbl_descrizione.Size = new System.Drawing.Size(62, 13);
			this.lbl_descrizione.TabIndex = 20;
			this.lbl_descrizione.Text = "Descrizione";
			// 
			// lbl_codice
			// 
			this.lbl_codice.AutoSize = true;
			this.lbl_codice.Location = new System.Drawing.Point(31, 98);
			this.lbl_codice.Name = "lbl_codice";
			this.lbl_codice.Size = new System.Drawing.Size(78, 13);
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
			this.lbl_amount.Location = new System.Drawing.Point(31, 281);
			this.lbl_amount.Name = "lbl_amount";
			this.lbl_amount.Size = new System.Drawing.Size(47, 13);
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
			this.Controls.Add(this.btn_send);
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
		private System.Windows.Forms.Button btn_send;
		private System.Windows.Forms.Label lbl_prezzo;
		private System.Windows.Forms.Label lbl_descrizione;
		private System.Windows.Forms.Label lbl_codice;
		private System.Windows.Forms.TextBox txt_descrizione;
		private System.Windows.Forms.TextBox txt_codice;
		private System.Windows.Forms.Label lbl_amount;
		private System.Windows.Forms.TextBox txt_prezzo;
		private System.Windows.Forms.TextBox txt_amount;
	}
}

