﻿namespace Cassa
{
	partial class Cassa
	{
		private System.ComponentModel.IContainer components = null;

		/// <summary> Pulire le risorse in uso. </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.btn_riciclabile = new System.Windows.Forms.Button();
			this.btn_sendAlimentareFresco = new System.Windows.Forms.Button();
			this.btn_sendAlimentareSemplice = new System.Windows.Forms.Button();
			this.btn_sendNonAlimentare = new System.Windows.Forms.Button();
			this.date_scadenza = new System.Windows.Forms.DateTimePicker();
			this.GraphicTitle = new System.Windows.Forms.Label();
			this.lbl_articolo = new System.Windows.Forms.Label();
			this.lbl_amount = new System.Windows.Forms.Label();
			this.lbl_codice = new System.Windows.Forms.Label();
			this.lbl_descrizione = new System.Windows.Forms.Label();
			this.lbl_materiale = new System.Windows.Forms.Label();
			this.lbl_prezzo = new System.Windows.Forms.Label();
			this.lbl_riciclabile = new System.Windows.Forms.Label();
			this.lbl_scadenza = new System.Windows.Forms.Label();
			this.lbl_scadenzaFresco = new System.Windows.Forms.Label();
			this.PageAlimentare = new System.Windows.Forms.TabPage();
			this.SubPagine = new System.Windows.Forms.TabControl();
			this.PageAlimentareNormale = new System.Windows.Forms.TabPage();
			this.view_alimentareSemplice = new System.Windows.Forms.ListView();
			this.head_index_alimentareSemplice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_code_alimentareSemplice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_descrizione_alimentareSemplice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_price_alimentareSemplice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_amount_alimentareSemplice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_data_alimentareSemplice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PageAlimentareFresco = new System.Windows.Forms.TabPage();
			this.view_alimentareFresco = new System.Windows.Forms.ListView();
			this.head_index_alimentareFresco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_code_alimentareFresco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_descrizione_alimentareFresco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_price_alimentareFresco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_amount_alimentareFresco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_data_alimentareFresco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_scadenzaFresco_alimentareFresco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txt_scadenzaFresco = new System.Windows.Forms.TextBox();
			this.PageNonAlimentare = new System.Windows.Forms.TabPage();
			this.view_nonAlimentare = new System.Windows.Forms.ListView();
			this.head_index_nonAlimentare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_code_nonAlimentare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_descrizione_nonAlimentare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_price_nonAlimentare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_amount_nonAlimentare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_materiale_nonAlimentare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_riciclabile_nonAlimentare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txt_materiale = new System.Windows.Forms.TextBox();
			this.Pagine = new System.Windows.Forms.TabControl();
			this.txt_amount = new System.Windows.Forms.TextBox();
			this.txt_codice = new System.Windows.Forms.TextBox();
			this.txt_descrizione = new System.Windows.Forms.TextBox();
			this.txt_prezzo = new System.Windows.Forms.TextBox();
			this.view_articolo = new System.Windows.Forms.ListView();
			this.head_index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_descrizione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_prezzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.head_extra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btn_faster = new System.Windows.Forms.Button();
			this.PageAlimentare.SuspendLayout();
			this.SubPagine.SuspendLayout();
			this.PageAlimentareNormale.SuspendLayout();
			this.PageAlimentareFresco.SuspendLayout();
			this.PageNonAlimentare.SuspendLayout();
			this.Pagine.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_riciclabile
			// 
			this.btn_riciclabile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_riciclabile.Location = new System.Drawing.Point(104, 158);
			this.btn_riciclabile.Name = "btn_riciclabile";
			this.btn_riciclabile.Size = new System.Drawing.Size(52, 33);
			this.btn_riciclabile.TabIndex = 7;
			this.btn_riciclabile.Text = "Si";
			this.btn_riciclabile.UseVisualStyleBackColor = true;
			this.btn_riciclabile.Click += new System.EventHandler(this.Riciclabile_Click);
			// 
			// btn_sendAlimentareFresco
			// 
			this.btn_sendAlimentareFresco.Location = new System.Drawing.Point(226, 30);
			this.btn_sendAlimentareFresco.Name = "btn_sendAlimentareFresco";
			this.btn_sendAlimentareFresco.Size = new System.Drawing.Size(84, 217);
			this.btn_sendAlimentareFresco.TabIndex = 8;
			this.btn_sendAlimentareFresco.Text = "Invia";
			this.btn_sendAlimentareFresco.UseVisualStyleBackColor = true;
			this.btn_sendAlimentareFresco.Click += new System.EventHandler(this.SendAlimentareFresco_Click);
			// 
			// btn_sendAlimentareSemplice
			// 
			this.btn_sendAlimentareSemplice.Location = new System.Drawing.Point(226, 30);
			this.btn_sendAlimentareSemplice.Name = "btn_sendAlimentareSemplice";
			this.btn_sendAlimentareSemplice.Size = new System.Drawing.Size(84, 217);
			this.btn_sendAlimentareSemplice.TabIndex = 8;
			this.btn_sendAlimentareSemplice.Text = "Invia";
			this.btn_sendAlimentareSemplice.UseVisualStyleBackColor = true;
			this.btn_sendAlimentareSemplice.Click += new System.EventHandler(this.SendAlimentareSemplice_Click);
			// 
			// btn_sendNonAlimentare
			// 
			this.btn_sendNonAlimentare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btn_sendNonAlimentare.Location = new System.Drawing.Point(236, 57);
			this.btn_sendNonAlimentare.Name = "btn_sendNonAlimentare";
			this.btn_sendNonAlimentare.Size = new System.Drawing.Size(84, 217);
			this.btn_sendNonAlimentare.TabIndex = 8;
			this.btn_sendNonAlimentare.Text = "Invia";
			this.btn_sendNonAlimentare.UseVisualStyleBackColor = true;
			this.btn_sendNonAlimentare.Click += new System.EventHandler(this.SendNonAlimentare_Click);
			// 
			// date_scadenza
			// 
			this.date_scadenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.date_scadenza.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.date_scadenza.Location = new System.Drawing.Point(10, 43);
			this.date_scadenza.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
			this.date_scadenza.MinDate = new System.DateTime(2023, 12, 8, 0, 0, 0, 0);
			this.date_scadenza.Name = "date_scadenza";
			this.date_scadenza.Size = new System.Drawing.Size(210, 21);
			this.date_scadenza.TabIndex = 6;
			this.date_scadenza.Value = new System.DateTime(2023, 12, 8, 0, 0, 0, 0);
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
			this.GraphicTitle.TabIndex = 10;
			this.GraphicTitle.Text = "REGISTRATORE DI CASSA";
			this.GraphicTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_articolo
			// 
			this.lbl_articolo.BackColor = System.Drawing.Color.DimGray;
			this.lbl_articolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_articolo.ForeColor = System.Drawing.Color.White;
			this.lbl_articolo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lbl_articolo.Location = new System.Drawing.Point(205, 9);
			this.lbl_articolo.Name = "lbl_articolo";
			this.lbl_articolo.Size = new System.Drawing.Size(142, 45);
			this.lbl_articolo.TabIndex = 10;
			this.lbl_articolo.Text = "Articolo";
			this.lbl_articolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_amount
			// 
			this.lbl_amount.AutoSize = true;
			this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_amount.Location = new System.Drawing.Point(301, 123);
			this.lbl_amount.Name = "lbl_amount";
			this.lbl_amount.Size = new System.Drawing.Size(56, 16);
			this.lbl_amount.TabIndex = 10;
			this.lbl_amount.Text = "Quantità";
			// 
			// lbl_codice
			// 
			this.lbl_codice.AutoSize = true;
			this.lbl_codice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_codice.Location = new System.Drawing.Point(34, 63);
			this.lbl_codice.Name = "lbl_codice";
			this.lbl_codice.Size = new System.Drawing.Size(98, 16);
			this.lbl_codice.TabIndex = 10;
			this.lbl_codice.Text = "Codice Articolo";
			// 
			// lbl_descrizione
			// 
			this.lbl_descrizione.AutoSize = true;
			this.lbl_descrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_descrizione.Location = new System.Drawing.Point(34, 122);
			this.lbl_descrizione.Name = "lbl_descrizione";
			this.lbl_descrizione.Size = new System.Drawing.Size(78, 16);
			this.lbl_descrizione.TabIndex = 10;
			this.lbl_descrizione.Text = "Descrizione";
			// 
			// lbl_materiale
			// 
			this.lbl_materiale.AutoSize = true;
			this.lbl_materiale.Location = new System.Drawing.Point(17, 57);
			this.lbl_materiale.Name = "lbl_materiale";
			this.lbl_materiale.Size = new System.Drawing.Size(63, 16);
			this.lbl_materiale.TabIndex = 10;
			this.lbl_materiale.Text = "Materiale";
			// 
			// lbl_prezzo
			// 
			this.lbl_prezzo.AutoSize = true;
			this.lbl_prezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_prezzo.Location = new System.Drawing.Point(301, 63);
			this.lbl_prezzo.Name = "lbl_prezzo";
			this.lbl_prezzo.Size = new System.Drawing.Size(97, 16);
			this.lbl_prezzo.TabIndex = 10;
			this.lbl_prezzo.Text = "Prezzo Unitario";
			// 
			// lbl_riciclabile
			// 
			this.lbl_riciclabile.AutoSize = true;
			this.lbl_riciclabile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_riciclabile.Location = new System.Drawing.Point(16, 155);
			this.lbl_riciclabile.Name = "lbl_riciclabile";
			this.lbl_riciclabile.Size = new System.Drawing.Size(82, 36);
			this.lbl_riciclabile.TabIndex = 10;
			this.lbl_riciclabile.Text = "Riciclabile?\r\nNo";
			this.lbl_riciclabile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbl_scadenza
			// 
			this.lbl_scadenza.AutoSize = true;
			this.lbl_scadenza.Location = new System.Drawing.Point(7, 27);
			this.lbl_scadenza.Name = "lbl_scadenza";
			this.lbl_scadenza.Size = new System.Drawing.Size(68, 16);
			this.lbl_scadenza.TabIndex = 10;
			this.lbl_scadenza.Text = "Scadenza";
			// 
			// lbl_scadenzaFresco
			// 
			this.lbl_scadenzaFresco.AutoSize = true;
			this.lbl_scadenzaFresco.Location = new System.Drawing.Point(7, 178);
			this.lbl_scadenzaFresco.Name = "lbl_scadenzaFresco";
			this.lbl_scadenzaFresco.Size = new System.Drawing.Size(241, 16);
			this.lbl_scadenzaFresco.TabIndex = 10;
			this.lbl_scadenzaFresco.Text = "Numero giorni scadenza dopo apertura";
			// 
			// PageAlimentare
			// 
			this.PageAlimentare.Controls.Add(this.SubPagine);
			this.PageAlimentare.Location = new System.Drawing.Point(4, 25);
			this.PageAlimentare.Name = "PageAlimentare";
			this.PageAlimentare.Padding = new System.Windows.Forms.Padding(3);
			this.PageAlimentare.Size = new System.Drawing.Size(1098, 658);
			this.PageAlimentare.TabIndex = 10;
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
			this.SubPagine.Size = new System.Drawing.Size(1086, 646);
			this.SubPagine.TabIndex = 5;
			this.SubPagine.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.SubPagine_Selecting);
			// 
			// PageAlimentareNormale
			// 
			this.PageAlimentareNormale.Controls.Add(this.view_alimentareSemplice);
			this.PageAlimentareNormale.Controls.Add(this.lbl_scadenza);
			this.PageAlimentareNormale.Controls.Add(this.date_scadenza);
			this.PageAlimentareNormale.Controls.Add(this.btn_sendAlimentareSemplice);
			this.PageAlimentareNormale.Location = new System.Drawing.Point(4, 25);
			this.PageAlimentareNormale.Name = "PageAlimentareNormale";
			this.PageAlimentareNormale.Padding = new System.Windows.Forms.Padding(3);
			this.PageAlimentareNormale.Size = new System.Drawing.Size(1078, 617);
			this.PageAlimentareNormale.TabIndex = 10;
			this.PageAlimentareNormale.Text = "Semplice";
			this.PageAlimentareNormale.UseVisualStyleBackColor = true;
			// 
			// view_alimentareSemplice
			// 
			this.view_alimentareSemplice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.head_index_alimentareSemplice,
            this.head_code_alimentareSemplice,
            this.head_descrizione_alimentareSemplice,
            this.head_price_alimentareSemplice,
            this.head_amount_alimentareSemplice,
            this.head_data_alimentareSemplice});
			this.view_alimentareSemplice.HideSelection = false;
			this.view_alimentareSemplice.Location = new System.Drawing.Point(329, 20);
			this.view_alimentareSemplice.Name = "view_alimentareSemplice";
			this.view_alimentareSemplice.Size = new System.Drawing.Size(733, 554);
			this.view_alimentareSemplice.TabIndex = 10;
			this.view_alimentareSemplice.UseCompatibleStateImageBehavior = false;
			this.view_alimentareSemplice.View = System.Windows.Forms.View.Details;
			// 
			// head_index_alimentareSemplice
			// 
			this.head_index_alimentareSemplice.Text = "Indice";
			this.head_index_alimentareSemplice.Width = 50;
			// 
			// head_code_alimentareSemplice
			// 
			this.head_code_alimentareSemplice.Text = "Codice";
			this.head_code_alimentareSemplice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// head_descrizione_alimentareSemplice
			// 
			this.head_descrizione_alimentareSemplice.Text = "Descrizione";
			this.head_descrizione_alimentareSemplice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.head_descrizione_alimentareSemplice.Width = 300;
			// 
			// head_price_alimentareSemplice
			// 
			this.head_price_alimentareSemplice.Text = "Prezzo Unitario";
			this.head_price_alimentareSemplice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.head_price_alimentareSemplice.Width = 110;
			// 
			// head_amount_alimentareSemplice
			// 
			this.head_amount_alimentareSemplice.Text = "Quantità";
			this.head_amount_alimentareSemplice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.head_amount_alimentareSemplice.Width = 70;
			// 
			// head_data_alimentareSemplice
			// 
			this.head_data_alimentareSemplice.Text = "Scadenza";
			this.head_data_alimentareSemplice.Width = 100;
			// 
			// PageAlimentareFresco
			// 
			this.PageAlimentareFresco.Controls.Add(this.view_alimentareFresco);
			this.PageAlimentareFresco.Controls.Add(this.txt_scadenzaFresco);
			this.PageAlimentareFresco.Controls.Add(this.lbl_scadenzaFresco);
			this.PageAlimentareFresco.Controls.Add(this.btn_sendAlimentareFresco);
			this.PageAlimentareFresco.Location = new System.Drawing.Point(4, 25);
			this.PageAlimentareFresco.Name = "PageAlimentareFresco";
			this.PageAlimentareFresco.Padding = new System.Windows.Forms.Padding(3);
			this.PageAlimentareFresco.Size = new System.Drawing.Size(1078, 617);
			this.PageAlimentareFresco.TabIndex = 10;
			this.PageAlimentareFresco.Text = "Fresco";
			this.PageAlimentareFresco.UseVisualStyleBackColor = true;
			// 
			// view_alimentareFresco
			// 
			this.view_alimentareFresco.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.head_index_alimentareFresco,
            this.head_code_alimentareFresco,
            this.head_descrizione_alimentareFresco,
            this.head_price_alimentareFresco,
            this.head_amount_alimentareFresco,
            this.head_data_alimentareFresco,
            this.head_scadenzaFresco_alimentareFresco});
			this.view_alimentareFresco.HideSelection = false;
			this.view_alimentareFresco.Location = new System.Drawing.Point(316, 21);
			this.view_alimentareFresco.Name = "view_alimentareFresco";
			this.view_alimentareFresco.Size = new System.Drawing.Size(743, 563);
			this.view_alimentareFresco.TabIndex = 10;
			this.view_alimentareFresco.UseCompatibleStateImageBehavior = false;
			this.view_alimentareFresco.View = System.Windows.Forms.View.Details;
			// 
			// head_index_alimentareFresco
			// 
			this.head_index_alimentareFresco.Text = "Indice";
			this.head_index_alimentareFresco.Width = 50;
			// 
			// head_code_alimentareFresco
			// 
			this.head_code_alimentareFresco.Text = "Codice";
			this.head_code_alimentareFresco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// head_descrizione_alimentareFresco
			// 
			this.head_descrizione_alimentareFresco.Text = "Descrizione";
			this.head_descrizione_alimentareFresco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.head_descrizione_alimentareFresco.Width = 196;
			// 
			// head_price_alimentareFresco
			// 
			this.head_price_alimentareFresco.Text = "Prezzo Unitario";
			this.head_price_alimentareFresco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.head_price_alimentareFresco.Width = 110;
			// 
			// head_amount_alimentareFresco
			// 
			this.head_amount_alimentareFresco.Text = "Quantità";
			this.head_amount_alimentareFresco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.head_amount_alimentareFresco.Width = 70;
			// 
			// head_data_alimentareFresco
			// 
			this.head_data_alimentareFresco.Text = "Scadenza";
			this.head_data_alimentareFresco.Width = 73;
			// 
			// head_scadenzaFresco_alimentareFresco
			// 
			this.head_scadenzaFresco_alimentareFresco.Text = "Scadenza dopo apertura";
			this.head_scadenzaFresco_alimentareFresco.Width = 166;
			// 
			// txt_scadenzaFresco
			// 
			this.txt_scadenzaFresco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_scadenzaFresco.Location = new System.Drawing.Point(10, 197);
			this.txt_scadenzaFresco.Name = "txt_scadenzaFresco";
			this.txt_scadenzaFresco.Size = new System.Drawing.Size(187, 31);
			this.txt_scadenzaFresco.TabIndex = 7;
			// 
			// PageNonAlimentare
			// 
			this.PageNonAlimentare.Controls.Add(this.view_nonAlimentare);
			this.PageNonAlimentare.Controls.Add(this.btn_riciclabile);
			this.PageNonAlimentare.Controls.Add(this.lbl_riciclabile);
			this.PageNonAlimentare.Controls.Add(this.txt_materiale);
			this.PageNonAlimentare.Controls.Add(this.lbl_materiale);
			this.PageNonAlimentare.Controls.Add(this.btn_sendNonAlimentare);
			this.PageNonAlimentare.Location = new System.Drawing.Point(4, 25);
			this.PageNonAlimentare.Name = "PageNonAlimentare";
			this.PageNonAlimentare.Padding = new System.Windows.Forms.Padding(3);
			this.PageNonAlimentare.Size = new System.Drawing.Size(1098, 658);
			this.PageNonAlimentare.TabIndex = 10;
			this.PageNonAlimentare.Text = "NonAlimentare";
			this.PageNonAlimentare.UseVisualStyleBackColor = true;
			// 
			// view_nonAlimentare
			// 
			this.view_nonAlimentare.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.head_index_nonAlimentare,
            this.head_code_nonAlimentare,
            this.head_descrizione_nonAlimentare,
            this.head_price_nonAlimentare,
            this.head_amount_nonAlimentare,
            this.head_materiale_nonAlimentare,
            this.head_riciclabile_nonAlimentare});
			this.view_nonAlimentare.HideSelection = false;
			this.view_nonAlimentare.Location = new System.Drawing.Point(337, 32);
			this.view_nonAlimentare.Name = "view_nonAlimentare";
			this.view_nonAlimentare.Size = new System.Drawing.Size(743, 563);
			this.view_nonAlimentare.TabIndex = 10;
			this.view_nonAlimentare.UseCompatibleStateImageBehavior = false;
			this.view_nonAlimentare.View = System.Windows.Forms.View.Details;
			// 
			// head_index_nonAlimentare
			// 
			this.head_index_nonAlimentare.Text = "Indice";
			this.head_index_nonAlimentare.Width = 50;
			// 
			// head_code_nonAlimentare
			// 
			this.head_code_nonAlimentare.Text = "Codice";
			this.head_code_nonAlimentare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// head_descrizione_nonAlimentare
			// 
			this.head_descrizione_nonAlimentare.Text = "Descrizione";
			this.head_descrizione_nonAlimentare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.head_descrizione_nonAlimentare.Width = 240;
			// 
			// head_price_nonAlimentare
			// 
			this.head_price_nonAlimentare.Text = "Prezzo Unitario";
			this.head_price_nonAlimentare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.head_price_nonAlimentare.Width = 110;
			// 
			// head_amount_nonAlimentare
			// 
			this.head_amount_nonAlimentare.Text = "Quantità";
			this.head_amount_nonAlimentare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.head_amount_nonAlimentare.Width = 70;
			// 
			// head_materiale_nonAlimentare
			// 
			this.head_materiale_nonAlimentare.Text = "Materiale";
			this.head_materiale_nonAlimentare.Width = 102;
			// 
			// head_riciclabile_nonAlimentare
			// 
			this.head_riciclabile_nonAlimentare.Text = "Riciclabile?";
			this.head_riciclabile_nonAlimentare.Width = 166;
			// 
			// txt_materiale
			// 
			this.txt_materiale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_materiale.Location = new System.Drawing.Point(20, 73);
			this.txt_materiale.Name = "txt_materiale";
			this.txt_materiale.Size = new System.Drawing.Size(204, 31);
			this.txt_materiale.TabIndex = 6;
			// 
			// Pagine
			// 
			this.Pagine.Controls.Add(this.PageAlimentare);
			this.Pagine.Controls.Add(this.PageNonAlimentare);
			this.Pagine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Pagine.Location = new System.Drawing.Point(592, 46);
			this.Pagine.Name = "Pagine";
			this.Pagine.SelectedIndex = 0;
			this.Pagine.Size = new System.Drawing.Size(1106, 687);
			this.Pagine.TabIndex = 4;
			// 
			// txt_amount
			// 
			this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_amount.Location = new System.Drawing.Point(304, 142);
			this.txt_amount.Name = "txt_amount";
			this.txt_amount.Size = new System.Drawing.Size(204, 31);
			this.txt_amount.TabIndex = 3;
			// 
			// txt_codice
			// 
			this.txt_codice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_codice.Location = new System.Drawing.Point(37, 79);
			this.txt_codice.MaxLength = 20;
			this.txt_codice.Name = "txt_codice";
			this.txt_codice.Size = new System.Drawing.Size(204, 31);
			this.txt_codice.TabIndex = 0;
			// 
			// txt_descrizione
			// 
			this.txt_descrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_descrizione.Location = new System.Drawing.Point(37, 138);
			this.txt_descrizione.Name = "txt_descrizione";
			this.txt_descrizione.Size = new System.Drawing.Size(204, 31);
			this.txt_descrizione.TabIndex = 1;
			// 
			// txt_prezzo
			// 
			this.txt_prezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_prezzo.Location = new System.Drawing.Point(304, 79);
			this.txt_prezzo.Name = "txt_prezzo";
			this.txt_prezzo.Size = new System.Drawing.Size(204, 31);
			this.txt_prezzo.TabIndex = 2;
			// 
			// view_articolo
			// 
			this.view_articolo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.head_index,
            this.head_code,
            this.head_descrizione,
            this.head_prezzo,
            this.head_amount,
            this.head_type,
            this.head_extra});
			this.view_articolo.HideSelection = false;
			this.view_articolo.Location = new System.Drawing.Point(12, 179);
			this.view_articolo.Name = "view_articolo";
			this.view_articolo.Size = new System.Drawing.Size(574, 554);
			this.view_articolo.TabIndex = 10;
			this.view_articolo.UseCompatibleStateImageBehavior = false;
			this.view_articolo.View = System.Windows.Forms.View.Details;
			// 
			// head_index
			// 
			this.head_index.Text = "Indice";
			this.head_index.Width = 41;
			// 
			// head_code
			// 
			this.head_code.Text = "Codice";
			this.head_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.head_code.Width = 50;
			// 
			// head_descrizione
			// 
			this.head_descrizione.Text = "Descrizione";
			this.head_descrizione.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.head_descrizione.Width = 70;
			// 
			// head_prezzo
			// 
			this.head_prezzo.Text = "Prezzo Unitario";
			this.head_prezzo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.head_prezzo.Width = 89;
			// 
			// head_amount
			// 
			this.head_amount.Text = "Quantità";
			this.head_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.head_amount.Width = 55;
			// 
			// head_type
			// 
			this.head_type.Text = "Tipo";
			this.head_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.head_type.Width = 83;
			// 
			// head_extra
			// 
			this.head_extra.Text = "Dettagli";
			this.head_extra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.head_extra.Width = 173;
			// 
			// btn_faster
			// 
			this.btn_faster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_faster.Location = new System.Drawing.Point(1448, 13);
			this.btn_faster.Name = "btn_faster";
			this.btn_faster.Size = new System.Drawing.Size(246, 41);
			this.btn_faster.TabIndex = 11;
			this.btn_faster.Text = "Riempi predefinito";
			this.btn_faster.UseVisualStyleBackColor = true;
			this.btn_faster.Click += new System.EventHandler(this.Faster_Click);
			// 
			// Cassa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1710, 745);
			this.Controls.Add(this.btn_faster);
			this.Controls.Add(this.view_articolo);
			this.Controls.Add(this.txt_amount);
			this.Controls.Add(this.txt_prezzo);
			this.Controls.Add(this.lbl_amount);
			this.Controls.Add(this.txt_codice);
			this.Controls.Add(this.lbl_prezzo);
			this.Controls.Add(this.lbl_descrizione);
			this.Controls.Add(this.lbl_codice);
			this.Controls.Add(this.txt_descrizione);
			this.Controls.Add(this.lbl_articolo);
			this.Controls.Add(this.GraphicTitle);
			this.Controls.Add(this.Pagine);
			this.Name = "Cassa";
			this.Text = "Cassa";
			this.PageAlimentare.ResumeLayout(false);
			this.SubPagine.ResumeLayout(false);
			this.PageAlimentareNormale.ResumeLayout(false);
			this.PageAlimentareNormale.PerformLayout();
			this.PageAlimentareFresco.ResumeLayout(false);
			this.PageAlimentareFresco.PerformLayout();
			this.PageNonAlimentare.ResumeLayout(false);
			this.PageNonAlimentare.PerformLayout();
			this.Pagine.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.Button btn_riciclabile;
		private System.Windows.Forms.Button btn_sendAlimentareFresco;
		private System.Windows.Forms.Button btn_sendAlimentareSemplice;
		private System.Windows.Forms.Button btn_sendNonAlimentare;
		private System.Windows.Forms.DateTimePicker date_scadenza;
		private System.Windows.Forms.Label GraphicTitle;
		private System.Windows.Forms.Label lbl_articolo;
		private System.Windows.Forms.Label lbl_amount;
		private System.Windows.Forms.Label lbl_codice;
		private System.Windows.Forms.Label lbl_descrizione;
		private System.Windows.Forms.Label lbl_materiale;
		private System.Windows.Forms.Label lbl_prezzo;
		private System.Windows.Forms.Label lbl_riciclabile;
		private System.Windows.Forms.Label lbl_scadenza;
		private System.Windows.Forms.Label lbl_scadenzaFresco;
		private System.Windows.Forms.TabControl Pagine;
		private System.Windows.Forms.TabControl SubPagine;
		private System.Windows.Forms.TabPage PageAlimentare;
		private System.Windows.Forms.TabPage PageAlimentareFresco;
		private System.Windows.Forms.TabPage PageAlimentareNormale;
		private System.Windows.Forms.TabPage PageNonAlimentare;
		private System.Windows.Forms.TextBox txt_amount;
		private System.Windows.Forms.TextBox txt_codice;
		private System.Windows.Forms.TextBox txt_descrizione;
		private System.Windows.Forms.TextBox txt_materiale;
		private System.Windows.Forms.TextBox txt_prezzo;
		private System.Windows.Forms.TextBox txt_scadenzaFresco;
		private System.Windows.Forms.ListView view_articolo;
		private System.Windows.Forms.ColumnHeader head_index;
		private System.Windows.Forms.ColumnHeader head_code;
		private System.Windows.Forms.ColumnHeader head_descrizione;
		private System.Windows.Forms.ColumnHeader head_prezzo;
		private System.Windows.Forms.ColumnHeader head_amount;
		private System.Windows.Forms.ColumnHeader head_extra;
		private System.Windows.Forms.ListView view_alimentareSemplice;
		private System.Windows.Forms.ColumnHeader head_index_alimentareSemplice;
		private System.Windows.Forms.ColumnHeader head_code_alimentareSemplice;
		private System.Windows.Forms.ColumnHeader head_descrizione_alimentareSemplice;
		private System.Windows.Forms.ColumnHeader head_price_alimentareSemplice;
		private System.Windows.Forms.ColumnHeader head_amount_alimentareSemplice;
		private System.Windows.Forms.ColumnHeader head_data_alimentareSemplice;
		private System.Windows.Forms.ListView view_alimentareFresco;
		private System.Windows.Forms.ColumnHeader head_index_alimentareFresco;
		private System.Windows.Forms.ColumnHeader head_code_alimentareFresco;
		private System.Windows.Forms.ColumnHeader head_descrizione_alimentareFresco;
		private System.Windows.Forms.ColumnHeader head_price_alimentareFresco;
		private System.Windows.Forms.ColumnHeader head_amount_alimentareFresco;
		private System.Windows.Forms.ColumnHeader head_data_alimentareFresco;
		private System.Windows.Forms.ColumnHeader head_scadenzaFresco_alimentareFresco;
		private System.Windows.Forms.ListView view_nonAlimentare;
		private System.Windows.Forms.ColumnHeader head_index_nonAlimentare;
		private System.Windows.Forms.ColumnHeader head_code_nonAlimentare;
		private System.Windows.Forms.ColumnHeader head_descrizione_nonAlimentare;
		private System.Windows.Forms.ColumnHeader head_price_nonAlimentare;
		private System.Windows.Forms.ColumnHeader head_amount_nonAlimentare;
		private System.Windows.Forms.ColumnHeader head_materiale_nonAlimentare;
		private System.Windows.Forms.ColumnHeader head_riciclabile_nonAlimentare;
		private System.Windows.Forms.ColumnHeader head_type;
		private System.Windows.Forms.Button btn_faster;
	}
}
