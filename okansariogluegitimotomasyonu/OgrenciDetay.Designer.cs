namespace okansariogluegitimotomasyonu
{
    partial class OgrenciDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ogrencidtySinifBilgileri = new ListView();
            ogrencidtyDevamsizlik = new ColumnHeader();
            ogrencidtyDevamsizlikNeden = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            ogrencidtyKutuphaneBilgileriListe = new ListView();
            ogrencidtyKutuphaneISBN = new ColumnHeader();
            ogrencidtyKutuphaneKitapAdi = new ColumnHeader();
            ogrencidtyKutuphaneOduncAlimTarihi = new ColumnHeader();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            GenelNotOrtYonlendirme = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            ogrencidtyTC = new TextBox();
            ogrencidtyAd = new TextBox();
            ogrencidtySoyad = new TextBox();
            ogrencidtyDogumTarihi = new TextBox();
            ogrencidtyCinsiyet = new TextBox();
            ogrencidtyTelefon = new TextBox();
            ogrencidtyEposta = new TextBox();
            ogrencidtyAdres = new TextBox();
            label15 = new Label();
            txtogrencidtySinif = new TextBox();
            label16 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ogrencidtySinifBilgileri
            // 
            ogrencidtySinifBilgileri.Columns.AddRange(new ColumnHeader[] { ogrencidtyDevamsizlik, ogrencidtyDevamsizlikNeden });
            ogrencidtySinifBilgileri.Location = new Point(159, 204);
            ogrencidtySinifBilgileri.MaximumSize = new Size(389, 246);
            ogrencidtySinifBilgileri.MinimumSize = new Size(389, 246);
            ogrencidtySinifBilgileri.Name = "ogrencidtySinifBilgileri";
            ogrencidtySinifBilgileri.Size = new Size(389, 246);
            ogrencidtySinifBilgileri.TabIndex = 1;
            ogrencidtySinifBilgileri.UseCompatibleStateImageBehavior = false;
            ogrencidtySinifBilgileri.View = View.Details;
            // 
            // ogrencidtyDevamsizlik
            // 
            ogrencidtyDevamsizlik.Text = "Devamsızlık Tarihi";
            ogrencidtyDevamsizlik.TextAlign = HorizontalAlignment.Center;
            ogrencidtyDevamsizlik.Width = 150;
            // 
            // ogrencidtyDevamsizlikNeden
            // 
            ogrencidtyDevamsizlikNeden.Text = "Devamsızlık Nedeni";
            ogrencidtyDevamsizlikNeden.TextAlign = HorizontalAlignment.Center;
            ogrencidtyDevamsizlikNeden.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 15.25F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(439, 9);
            label1.Name = "label1";
            label1.Size = new Size(289, 25);
            label1.TabIndex = 2;
            label1.Text = "- ÖĞRENCİ KAYIT BİLGİLERİ -";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maiandra GD", 13.25F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(168, 175);
            label2.Name = "label2";
            label2.Size = new Size(239, 21);
            label2.TabIndex = 3;
            label2.Text = "- ÖĞRENCİ SINIF BİLGİLERİ -";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Maiandra GD", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(750, 312);
            label4.Name = "label4";
            label4.Size = new Size(256, 22);
            label4.TabIndex = 5;
            label4.Text = "- ÖĞRENCİ NOT BİLGİLERİ -";
            // 
            // ogrencidtyKutuphaneBilgileriListe
            // 
            ogrencidtyKutuphaneBilgileriListe.Columns.AddRange(new ColumnHeader[] { ogrencidtyKutuphaneISBN, ogrencidtyKutuphaneKitapAdi, ogrencidtyKutuphaneOduncAlimTarihi });
            ogrencidtyKutuphaneBilgileriListe.Location = new Point(625, 204);
            ogrencidtyKutuphaneBilgileriListe.MaximumSize = new Size(486, 86);
            ogrencidtyKutuphaneBilgileriListe.MinimumSize = new Size(486, 86);
            ogrencidtyKutuphaneBilgileriListe.Name = "ogrencidtyKutuphaneBilgileriListe";
            ogrencidtyKutuphaneBilgileriListe.Size = new Size(486, 86);
            ogrencidtyKutuphaneBilgileriListe.TabIndex = 6;
            ogrencidtyKutuphaneBilgileriListe.UseCompatibleStateImageBehavior = false;
            ogrencidtyKutuphaneBilgileriListe.View = View.Details;
            // 
            // ogrencidtyKutuphaneISBN
            // 
            ogrencidtyKutuphaneISBN.Text = "ISBN";
            ogrencidtyKutuphaneISBN.Width = 130;
            // 
            // ogrencidtyKutuphaneKitapAdi
            // 
            ogrencidtyKutuphaneKitapAdi.Text = "KIitap Ad";
            ogrencidtyKutuphaneKitapAdi.TextAlign = HorizontalAlignment.Center;
            ogrencidtyKutuphaneKitapAdi.Width = 130;
            // 
            // ogrencidtyKutuphaneOduncAlimTarihi
            // 
            ogrencidtyKutuphaneOduncAlimTarihi.Text = "Ödünç Alım Tarihi";
            ogrencidtyKutuphaneOduncAlimTarihi.TextAlign = HorizontalAlignment.Center;
            ogrencidtyKutuphaneOduncAlimTarihi.Width = 150;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label5.Location = new Point(780, 353);
            label5.Name = "label5";
            label5.Size = new Size(201, 20);
            label5.TabIndex = 8;
            label5.Text = "Genel Not Ortalaması/GNO";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(GenelNotOrtYonlendirme, 0, 0);
            tableLayoutPanel1.Location = new Point(808, 376);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(133, 35);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // GenelNotOrtYonlendirme
            // 
            GenelNotOrtYonlendirme.Dock = DockStyle.Fill;
            GenelNotOrtYonlendirme.Enabled = false;
            GenelNotOrtYonlendirme.Location = new Point(3, 3);
            GenelNotOrtYonlendirme.Name = "GenelNotOrtYonlendirme";
            GenelNotOrtYonlendirme.Size = new Size(127, 27);
            GenelNotOrtYonlendirme.TabIndex = 0;
            GenelNotOrtYonlendirme.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label7.Location = new Point(44, 54);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 12;
            label7.Text = "TC";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label8.Location = new Point(159, 54);
            label8.Name = "label8";
            label8.Size = new Size(28, 20);
            label8.TabIndex = 13;
            label8.Text = "Ad";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label9.Location = new Point(274, 54);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(50, 20);
            label9.TabIndex = 14;
            label9.Text = "Soyad";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label10.Location = new Point(382, 54);
            label10.Name = "label10";
            label10.Size = new Size(98, 20);
            label10.TabIndex = 15;
            label10.Text = "Doğum Tarihi";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline);
            label11.Location = new Point(526, 54);
            label11.Name = "label11";
            label11.Size = new Size(60, 20);
            label11.TabIndex = 16;
            label11.Text = "Cinsiyet";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline);
            label12.Location = new Point(638, 54);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 17;
            label12.Text = "Telefon";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label13.Location = new Point(767, 54);
            label13.Name = "label13";
            label13.Size = new Size(54, 20);
            label13.TabIndex = 18;
            label13.Text = "Eposta";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 162);
            label14.Location = new Point(1026, 54);
            label14.Name = "label14";
            label14.Size = new Size(47, 20);
            label14.TabIndex = 19;
            label14.Text = "Adres";
            // 
            // ogrencidtyTC
            // 
            ogrencidtyTC.Enabled = false;
            ogrencidtyTC.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            ogrencidtyTC.ForeColor = Color.Black;
            ogrencidtyTC.Location = new Point(0, 94);
            ogrencidtyTC.Name = "ogrencidtyTC";
            ogrencidtyTC.Size = new Size(120, 20);
            ogrencidtyTC.TabIndex = 20;
            ogrencidtyTC.TextAlign = HorizontalAlignment.Center;
            // 
            // ogrencidtyAd
            // 
            ogrencidtyAd.Enabled = false;
            ogrencidtyAd.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            ogrencidtyAd.ForeColor = Color.Black;
            ogrencidtyAd.Location = new Point(116, 94);
            ogrencidtyAd.Multiline = true;
            ogrencidtyAd.Name = "ogrencidtyAd";
            ogrencidtyAd.Size = new Size(121, 27);
            ogrencidtyAd.TabIndex = 21;
            ogrencidtyAd.TextAlign = HorizontalAlignment.Center;
            // 
            // ogrencidtySoyad
            // 
            ogrencidtySoyad.Enabled = false;
            ogrencidtySoyad.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            ogrencidtySoyad.ForeColor = Color.Black;
            ogrencidtySoyad.Location = new Point(243, 94);
            ogrencidtySoyad.Multiline = true;
            ogrencidtySoyad.Name = "ogrencidtySoyad";
            ogrencidtySoyad.Size = new Size(106, 27);
            ogrencidtySoyad.TabIndex = 22;
            ogrencidtySoyad.TextAlign = HorizontalAlignment.Center;
            // 
            // ogrencidtyDogumTarihi
            // 
            ogrencidtyDogumTarihi.Enabled = false;
            ogrencidtyDogumTarihi.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            ogrencidtyDogumTarihi.ForeColor = Color.Black;
            ogrencidtyDogumTarihi.Location = new Point(349, 94);
            ogrencidtyDogumTarihi.Multiline = true;
            ogrencidtyDogumTarihi.Name = "ogrencidtyDogumTarihi";
            ogrencidtyDogumTarihi.Size = new Size(163, 27);
            ogrencidtyDogumTarihi.TabIndex = 23;
            ogrencidtyDogumTarihi.TextAlign = HorizontalAlignment.Center;
            // 
            // ogrencidtyCinsiyet
            // 
            ogrencidtyCinsiyet.Enabled = false;
            ogrencidtyCinsiyet.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            ogrencidtyCinsiyet.ForeColor = Color.Black;
            ogrencidtyCinsiyet.Location = new Point(508, 94);
            ogrencidtyCinsiyet.Name = "ogrencidtyCinsiyet";
            ogrencidtyCinsiyet.Size = new Size(97, 20);
            ogrencidtyCinsiyet.TabIndex = 24;
            ogrencidtyCinsiyet.TextAlign = HorizontalAlignment.Center;
            // 
            // ogrencidtyTelefon
            // 
            ogrencidtyTelefon.Enabled = false;
            ogrencidtyTelefon.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            ogrencidtyTelefon.ForeColor = Color.Black;
            ogrencidtyTelefon.Location = new Point(604, 94);
            ogrencidtyTelefon.Name = "ogrencidtyTelefon";
            ogrencidtyTelefon.Size = new Size(124, 20);
            ogrencidtyTelefon.TabIndex = 25;
            ogrencidtyTelefon.TextAlign = HorizontalAlignment.Center;
            // 
            // ogrencidtyEposta
            // 
            ogrencidtyEposta.Enabled = false;
            ogrencidtyEposta.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            ogrencidtyEposta.ForeColor = Color.Black;
            ogrencidtyEposta.Location = new Point(725, 94);
            ogrencidtyEposta.Multiline = true;
            ogrencidtyEposta.Name = "ogrencidtyEposta";
            ogrencidtyEposta.Size = new Size(140, 69);
            ogrencidtyEposta.TabIndex = 26;
            ogrencidtyEposta.TextAlign = HorizontalAlignment.Center;
            // 
            // ogrencidtyAdres
            // 
            ogrencidtyAdres.Enabled = false;
            ogrencidtyAdres.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            ogrencidtyAdres.ForeColor = Color.Black;
            ogrencidtyAdres.Location = new Point(862, 94);
            ogrencidtyAdres.Multiline = true;
            ogrencidtyAdres.Name = "ogrencidtyAdres";
            ogrencidtyAdres.Size = new Size(373, 69);
            ogrencidtyAdres.TabIndex = 27;
            ogrencidtyAdres.TextAlign = HorizontalAlignment.Center;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13.25F, FontStyle.Underline);
            label15.Location = new Point(44, 204);
            label15.Name = "label15";
            label15.Size = new Size(46, 25);
            label15.TabIndex = 28;
            label15.Text = "Sınıf";
            // 
            // txtogrencidtySinif
            // 
            txtogrencidtySinif.Enabled = false;
            txtogrencidtySinif.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            txtogrencidtySinif.Location = new Point(44, 232);
            txtogrencidtySinif.Name = "txtogrencidtySinif";
            txtogrencidtySinif.Size = new Size(46, 20);
            txtogrencidtySinif.TabIndex = 29;
            txtogrencidtySinif.TextAlign = HorizontalAlignment.Center;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Maiandra GD", 13.25F);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(725, 175);
            label16.Name = "label16";
            label16.Size = new Size(302, 21);
            label16.TabIndex = 30;
            label16.Text = "-ÖĞRENCİ KÜTÜPHANE BİLGİLERİ -";
            // 
            // OgrenciDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 450);
            Controls.Add(label16);
            Controls.Add(txtogrencidtySinif);
            Controls.Add(label5);
            Controls.Add(label15);
            Controls.Add(ogrencidtyAdres);
            Controls.Add(ogrencidtyEposta);
            Controls.Add(ogrencidtyTelefon);
            Controls.Add(ogrencidtyCinsiyet);
            Controls.Add(ogrencidtyDogumTarihi);
            Controls.Add(ogrencidtySoyad);
            Controls.Add(ogrencidtyAd);
            Controls.Add(ogrencidtyTC);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(ogrencidtyKutuphaneBilgileriListe);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ogrencidtySinifBilgileri);
            MaximizeBox = false;
            MaximumSize = new Size(1250, 489);
            MinimumSize = new Size(1250, 489);
            Name = "OgrenciDetay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OgrenciDetay";
            Load += OgrenciDetay_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label4;
        private ColumnHeader ogrencidtyDersCrsmb;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        public ListView ogrencidtySinifBilgileri;
        public ListView ogrencidtyKutuphaneBilgileriListe;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        public TextBox ogrencidtyTC;
        public TextBox ogrencidtyAd;
        public TextBox ogrencidtySoyad;
        public TextBox ogrencidtyDogumTarihi;
        public TextBox ogrencidtyCinsiyet;
        public TextBox ogrencidtyTelefon;
        public TextBox ogrencidtyEposta;
        public TextBox ogrencidtyAdres;
        public ColumnHeader ogrencidtyDevamsizlik;
        private Label label15;
        public TextBox txtogrencidtySinif;
        public ColumnHeader ogrencidtyKutuphaneISBN;
        public ColumnHeader ogrencidtyKutuphaneKitapAdi;
        public ColumnHeader ogrencidtyKutuphaneOduncAlimTarihi;
        private Label label16;
        private TextBox GenelNotOrtYonlendirme;
        public ColumnHeader ogrencidtyDevamsizlikNeden;
    }
}