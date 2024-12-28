namespace okansariogluegitimotomasyonu
{
    partial class KutuphaneYonetim
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtISBN = new TextBox();
            txtKitapAdi = new TextBox();
            txtKitapDurumu = new ComboBox();
            txtYazar = new TextBox();
            txtKitapOduncTC = new TextBox();
            kitapEkle = new Button();
            kitapDuzenle = new Button();
            KitapSil = new Button();
            KitapAra = new Button();
            txtKitapOduncTarih = new TextBox();
            txtKitapiadeTarih = new TextBox();
            kutuphaneListe = new ListView();
            kitaplisteISBN = new ColumnHeader();
            kitaplisteKitapAd = new ColumnHeader();
            kitaplisteYazar = new ColumnHeader();
            kitaplisteKitapDurum = new ColumnHeader();
            kitaplisteKitapOduncTC = new ColumnHeader();
            kitaplisteOduncTarih = new ColumnHeader();
            kitaplisteiadeTarih = new ColumnHeader();
            label14 = new Label();
            label15 = new Label();
            FF = new Label();
            pictureBox1 = new PictureBox();
            anliktarih = new Label();
            anasayfaAnlikSaatTarih = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 14;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 5, 1);
            tableLayoutPanel1.Controls.Add(label3, 5, 3);
            tableLayoutPanel1.Controls.Add(label4, 5, 5);
            tableLayoutPanel1.Controls.Add(label5, 9, 1);
            tableLayoutPanel1.Controls.Add(label6, 9, 3);
            tableLayoutPanel1.Controls.Add(label7, 9, 5);
            tableLayoutPanel1.Controls.Add(txtISBN, 3, 1);
            tableLayoutPanel1.Controls.Add(txtKitapAdi, 7, 1);
            tableLayoutPanel1.Controls.Add(txtKitapDurumu, 7, 5);
            tableLayoutPanel1.Controls.Add(txtYazar, 7, 3);
            tableLayoutPanel1.Controls.Add(txtKitapOduncTC, 11, 1);
            tableLayoutPanel1.Controls.Add(kitapEkle, 5, 7);
            tableLayoutPanel1.Controls.Add(kitapDuzenle, 7, 7);
            tableLayoutPanel1.Controls.Add(KitapSil, 9, 7);
            tableLayoutPanel1.Controls.Add(KitapAra, 3, 3);
            tableLayoutPanel1.Controls.Add(txtKitapOduncTarih, 11, 3);
            tableLayoutPanel1.Controls.Add(txtKitapiadeTarih, 11, 5);
            tableLayoutPanel1.Location = new Point(1, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.Size = new Size(988, 121);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F);
            label1.Location = new Point(11, 8);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "ISBN :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(267, 8);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "Kitap Adı :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F);
            label3.Location = new Point(267, 36);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 2;
            label3.Text = "Yazar :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F);
            label4.Location = new Point(267, 64);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 3;
            label4.Text = "Kitap Durumu :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F);
            label5.Location = new Point(523, 8);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 4;
            label5.Text = "Ödünç Alan TC  :";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F);
            label6.Location = new Point(523, 36);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 5;
            label6.Text = "Ödünç Tarihi :";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F);
            label7.Location = new Point(523, 64);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 6;
            label7.Text = "İade Tarihi :";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtISBN
            // 
            txtISBN.Dock = DockStyle.Fill;
            txtISBN.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtISBN.Location = new Point(139, 11);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(114, 20);
            txtISBN.TabIndex = 7;
            txtISBN.TextAlign = HorizontalAlignment.Center;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Dock = DockStyle.Fill;
            txtKitapAdi.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtKitapAdi.Location = new Point(395, 11);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(114, 20);
            txtKitapAdi.TabIndex = 8;
            // 
            // txtKitapDurumu
            // 
            txtKitapDurumu.Dock = DockStyle.Fill;
            txtKitapDurumu.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtKitapDurumu.FormattingEnabled = true;
            txtKitapDurumu.Items.AddRange(new object[] { "Mevcut", "Dolu", "Bakımda" });
            txtKitapDurumu.Location = new Point(395, 67);
            txtKitapDurumu.Name = "txtKitapDurumu";
            txtKitapDurumu.Size = new Size(114, 21);
            txtKitapDurumu.TabIndex = 13;
            // 
            // txtYazar
            // 
            txtYazar.Dock = DockStyle.Fill;
            txtYazar.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtYazar.Location = new Point(395, 39);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(114, 20);
            txtYazar.TabIndex = 9;
            txtYazar.TextAlign = HorizontalAlignment.Center;
            // 
            // txtKitapOduncTC
            // 
            txtKitapOduncTC.Dock = DockStyle.Fill;
            txtKitapOduncTC.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtKitapOduncTC.Location = new Point(651, 11);
            txtKitapOduncTC.Name = "txtKitapOduncTC";
            txtKitapOduncTC.Size = new Size(114, 20);
            txtKitapOduncTC.TabIndex = 12;
            txtKitapOduncTC.TextAlign = HorizontalAlignment.Center;
            // 
            // kitapEkle
            // 
            kitapEkle.Location = new Point(267, 93);
            kitapEkle.Name = "kitapEkle";
            kitapEkle.Size = new Size(104, 25);
            kitapEkle.TabIndex = 15;
            kitapEkle.Text = "Ekle";
            kitapEkle.UseVisualStyleBackColor = true;
            kitapEkle.Click += kitapEkle_Click;
            // 
            // kitapDuzenle
            // 
            kitapDuzenle.Location = new Point(395, 93);
            kitapDuzenle.Name = "kitapDuzenle";
            kitapDuzenle.Size = new Size(87, 25);
            kitapDuzenle.TabIndex = 16;
            kitapDuzenle.Text = "Düzenle";
            kitapDuzenle.UseVisualStyleBackColor = true;
            kitapDuzenle.Click += kitapDuzenle_Click;
            // 
            // KitapSil
            // 
            KitapSil.Location = new Point(523, 93);
            KitapSil.Name = "KitapSil";
            KitapSil.Size = new Size(91, 25);
            KitapSil.TabIndex = 17;
            KitapSil.Text = "Sil";
            KitapSil.UseVisualStyleBackColor = true;
            KitapSil.Click += KitapSil_Click;
            // 
            // KitapAra
            // 
            KitapAra.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            KitapAra.Location = new Point(139, 39);
            KitapAra.Name = "KitapAra";
            tableLayoutPanel1.SetRowSpan(KitapAra, 3);
            KitapAra.Size = new Size(114, 25);
            KitapAra.TabIndex = 14;
            KitapAra.Text = "Ara";
            KitapAra.UseVisualStyleBackColor = true;
            KitapAra.Click += KitapAra_Click;
            // 
            // txtKitapOduncTarih
            // 
            txtKitapOduncTarih.Dock = DockStyle.Fill;
            txtKitapOduncTarih.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtKitapOduncTarih.Location = new Point(651, 39);
            txtKitapOduncTarih.Name = "txtKitapOduncTarih";
            txtKitapOduncTarih.Size = new Size(114, 20);
            txtKitapOduncTarih.TabIndex = 19;
            // 
            // txtKitapiadeTarih
            // 
            txtKitapiadeTarih.Dock = DockStyle.Fill;
            txtKitapiadeTarih.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtKitapiadeTarih.Location = new Point(651, 67);
            txtKitapiadeTarih.Name = "txtKitapiadeTarih";
            txtKitapiadeTarih.Size = new Size(114, 20);
            txtKitapiadeTarih.TabIndex = 20;
            // 
            // kutuphaneListe
            // 
            kutuphaneListe.Columns.AddRange(new ColumnHeader[] { kitaplisteISBN, kitaplisteKitapAd, kitaplisteYazar, kitaplisteKitapDurum, kitaplisteKitapOduncTC, kitaplisteOduncTarih, kitaplisteiadeTarih });
            kutuphaneListe.Location = new Point(0, 170);
            kutuphaneListe.Name = "kutuphaneListe";
            kutuphaneListe.Size = new Size(988, 280);
            kutuphaneListe.TabIndex = 1;
            kutuphaneListe.UseCompatibleStateImageBehavior = false;
            kutuphaneListe.View = View.Details;
            kutuphaneListe.MouseClick += kutuphaneListe_MouseClick;
            // 
            // kitaplisteISBN
            // 
            kitaplisteISBN.Text = "ISBN";
            kitaplisteISBN.Width = 130;
            // 
            // kitaplisteKitapAd
            // 
            kitaplisteKitapAd.Text = "Kitap Ad";
            kitaplisteKitapAd.TextAlign = HorizontalAlignment.Center;
            kitaplisteKitapAd.Width = 140;
            // 
            // kitaplisteYazar
            // 
            kitaplisteYazar.Text = "Yazar";
            kitaplisteYazar.TextAlign = HorizontalAlignment.Center;
            kitaplisteYazar.Width = 140;
            // 
            // kitaplisteKitapDurum
            // 
            kitaplisteKitapDurum.Text = "Kitap Durum";
            kitaplisteKitapDurum.TextAlign = HorizontalAlignment.Center;
            kitaplisteKitapDurum.Width = 100;
            // 
            // kitaplisteKitapOduncTC
            // 
            kitaplisteKitapOduncTC.Text = "Ödünç Alan TC";
            kitaplisteKitapOduncTC.TextAlign = HorizontalAlignment.Center;
            kitaplisteKitapOduncTC.Width = 160;
            // 
            // kitaplisteOduncTarih
            // 
            kitaplisteOduncTarih.Text = "Ödünç Tarihi";
            kitaplisteOduncTarih.TextAlign = HorizontalAlignment.Center;
            kitaplisteOduncTarih.Width = 150;
            // 
            // kitaplisteiadeTarih
            // 
            kitaplisteiadeTarih.Text = "İade Tarihi";
            kitaplisteiadeTarih.TextAlign = HorizontalAlignment.Center;
            kitaplisteiadeTarih.Width = 150;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(101, 5);
            label14.Name = "label14";
            label14.Size = new Size(33, 19);
            label14.TabIndex = 32;
            label14.Text = "T.C";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.ForeColor = Color.White;
            label15.Location = new Point(73, 21);
            label15.Name = "label15";
            label15.Size = new Size(200, 19);
            label15.TabIndex = 34;
            label15.Text = "BEYKENT ÜNİVERSİTESİ";
            // 
            // FF
            // 
            FF.AutoSize = true;
            FF.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            FF.ForeColor = Color.White;
            FF.Location = new Point(140, 5);
            FF.Name = "FF";
            FF.Size = new Size(88, 19);
            FF.TabIndex = 33;
            FF.Text = "İSTANBUL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.beykentüniicon;
            pictureBox1.Location = new Point(22, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // anliktarih
            // 
            anliktarih.AutoSize = true;
            anliktarih.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            anliktarih.ForeColor = Color.White;
            anliktarih.Location = new Point(763, 9);
            anliktarih.Name = "anliktarih";
            anliktarih.Size = new Size(59, 19);
            anliktarih.TabIndex = 36;
            anliktarih.Text = "TARİH";
            anliktarih.MouseClick += anliktarih_MouseClick;
            // 
            // anasayfaAnlikSaatTarih
            // 
            anasayfaAnlikSaatTarih.Tick += anasayfaAnlikSaatTarih_Tick;
            // 
            // KutuphaneYonetim
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 40, 45);
            ClientSize = new Size(988, 450);
            Controls.Add(anliktarih);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(FF);
            Controls.Add(pictureBox1);
            Controls.Add(kutuphaneListe);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(1004, 489);
            MinimumSize = new Size(1004, 489);
            Name = "KutuphaneYonetim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KutuphaneYonetim";
            Load += KutuphaneYonetim_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label1;
        private Label label2;
        private Button KitapAra;
        private Button kitapEkle;
        private Button kitapDuzenle;
        private Button KitapSil;
        public ListView kutuphaneListe;
        public TextBox txtISBN;
        public TextBox txtKitapAdi;
        public TextBox txtYazar;
        public ComboBox txtKitapDurumu;
        public TextBox txtKitapOduncTC;
        private ColumnHeader kitaplisteISBN;
        private ColumnHeader kitaplisteKitapAd;
        private ColumnHeader kitaplisteYazar;
        private ColumnHeader kitaplisteKitapDurum;
        private ColumnHeader kitaplisteKitapOduncTC;
        private ColumnHeader kitaplisteOduncTarih;
        private ColumnHeader kitaplisteiadeTarih;
        private TextBox txtKitapOduncTarih;
        private TextBox txtKitapiadeTarih;
        private Label label14;
        private Label label15;
        private Label FF;
        private PictureBox pictureBox1;
        private Label anliktarih;
        private System.Windows.Forms.Timer anasayfaAnlikSaatTarih;
    }
}