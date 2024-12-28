namespace okansariogluegitimotomasyonu
{
    partial class AnasayfaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnSinavYonetim = new Button();
            sinifSecim = new Button();
            DevamsizlikTakip = new Button();
            DersProgrami = new Button();
            btnOgrenciKayit = new Button();
            btnOgretmenKayit = new Button();
            btnKutuphaneYonetim = new Button();
            panel1 = new Panel();
            anliktarih = new Label();
            anliksaat = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            FF = new Label();
            kayitislemleripanel = new Panel();
            kayitislemButon = new Button();
            dersislemleripanel = new Panel();
            dersislemButon = new Button();
            digerislemlerpanel = new Panel();
            digerislemButon = new Button();
            kayitislemZamanlayici = new System.Windows.Forms.Timer(components);
            digerislemZamanlayici = new System.Windows.Forms.Timer(components);
            dersislemZamanlayici = new System.Windows.Forms.Timer(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            anasayfaAnlikSaatTarih = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            kayitislemleripanel.SuspendLayout();
            dersislemleripanel.SuspendLayout();
            digerislemlerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSinavYonetim
            // 
            btnSinavYonetim.BackColor = Color.White;
            btnSinavYonetim.Font = new Font("Arial Narrow", 11.25F);
            btnSinavYonetim.ForeColor = Color.Black;
            btnSinavYonetim.Location = new Point(3, 246);
            btnSinavYonetim.Name = "btnSinavYonetim";
            btnSinavYonetim.Size = new Size(142, 43);
            btnSinavYonetim.TabIndex = 3;
            btnSinavYonetim.Text = "Sınav Yönetim";
            btnSinavYonetim.UseVisualStyleBackColor = false;
            btnSinavYonetim.Click += btnSinavYonetim_Click;
            // 
            // sinifSecim
            // 
            sinifSecim.BackColor = Color.White;
            sinifSecim.Font = new Font("Arial Narrow", 11.25F);
            sinifSecim.ForeColor = Color.Black;
            sinifSecim.Location = new Point(3, 99);
            sinifSecim.Name = "sinifSecim";
            sinifSecim.Size = new Size(142, 43);
            sinifSecim.TabIndex = 6;
            sinifSecim.Text = "Sınıf Seçim";
            sinifSecim.UseVisualStyleBackColor = false;
            sinifSecim.Click += sinifSecim_Click;
            // 
            // DevamsizlikTakip
            // 
            DevamsizlikTakip.BackColor = Color.White;
            DevamsizlikTakip.Font = new Font("Arial Narrow", 11.25F);
            DevamsizlikTakip.ForeColor = Color.Black;
            DevamsizlikTakip.Location = new Point(3, 197);
            DevamsizlikTakip.Name = "DevamsizlikTakip";
            DevamsizlikTakip.Size = new Size(142, 43);
            DevamsizlikTakip.TabIndex = 4;
            DevamsizlikTakip.Text = "Devamsızlık Takip";
            DevamsizlikTakip.UseVisualStyleBackColor = false;
            DevamsizlikTakip.Click += DevamsizlikTakip_Click;
            // 
            // DersProgrami
            // 
            DersProgrami.BackColor = Color.White;
            DersProgrami.Font = new Font("Arial Narrow", 11.25F);
            DersProgrami.ForeColor = Color.Black;
            DersProgrami.Location = new Point(3, 148);
            DersProgrami.Name = "DersProgrami";
            DersProgrami.Size = new Size(142, 43);
            DersProgrami.TabIndex = 2;
            DersProgrami.Text = "Ders Programı";
            DersProgrami.UseVisualStyleBackColor = false;
            DersProgrami.Click += DersProgrami_Click;
            // 
            // btnOgrenciKayit
            // 
            btnOgrenciKayit.BackColor = Color.White;
            btnOgrenciKayit.Font = new Font("Arial Narrow", 11.25F);
            btnOgrenciKayit.ForeColor = Color.Black;
            btnOgrenciKayit.Location = new Point(2, 99);
            btnOgrenciKayit.Name = "btnOgrenciKayit";
            btnOgrenciKayit.Size = new Size(144, 43);
            btnOgrenciKayit.TabIndex = 0;
            btnOgrenciKayit.Text = "Öğrenci Kayıt";
            btnOgrenciKayit.UseVisualStyleBackColor = false;
            btnOgrenciKayit.Click += btnOgrenciKayit_Click_1;
            // 
            // btnOgretmenKayit
            // 
            btnOgretmenKayit.BackColor = Color.White;
            btnOgretmenKayit.Font = new Font("Arial Narrow", 11.25F);
            btnOgretmenKayit.ForeColor = Color.Black;
            btnOgretmenKayit.Location = new Point(2, 148);
            btnOgretmenKayit.Name = "btnOgretmenKayit";
            btnOgretmenKayit.Size = new Size(144, 43);
            btnOgretmenKayit.TabIndex = 1;
            btnOgretmenKayit.Text = "Öğretmen Kayıt";
            btnOgretmenKayit.UseVisualStyleBackColor = false;
            btnOgretmenKayit.Click += btnOgretmenKayit_Click;
            // 
            // btnKutuphaneYonetim
            // 
            btnKutuphaneYonetim.BackColor = Color.White;
            btnKutuphaneYonetim.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKutuphaneYonetim.ForeColor = Color.Black;
            btnKutuphaneYonetim.Location = new Point(3, 99);
            btnKutuphaneYonetim.Name = "btnKutuphaneYonetim";
            btnKutuphaneYonetim.Size = new Size(141, 43);
            btnKutuphaneYonetim.TabIndex = 5;
            btnKutuphaneYonetim.Text = "Kütüphane Yönetim";
            btnKutuphaneYonetim.UseVisualStyleBackColor = false;
            btnKutuphaneYonetim.Click += btnKutuphaneYonetim_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 40, 45);
            panel1.Controls.Add(anliktarih);
            panel1.Controls.Add(anliksaat);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(FF);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(209, 422);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 422);
            panel1.TabIndex = 7;
            // 
            // anliktarih
            // 
            anliktarih.AutoSize = true;
            anliktarih.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            anliktarih.ForeColor = Color.White;
            anliktarih.Location = new Point(12, 363);
            anliktarih.Name = "anliktarih";
            anliktarih.Size = new Size(59, 19);
            anliktarih.TabIndex = 14;
            anliktarih.Text = "TARİH";
            // 
            // anliksaat
            // 
            anliksaat.AutoSize = true;
            anliksaat.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            anliksaat.ForeColor = Color.White;
            anliksaat.Location = new Point(68, 394);
            anliksaat.Name = "anliksaat";
            anliksaat.Size = new Size(49, 19);
            anliksaat.TabIndex = 13;
            anliksaat.Text = "SAAT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 154);
            label3.Name = "label3";
            label3.Size = new Size(255, 20);
            label3.TabIndex = 3;
            label3.Text = "-----------------------------------------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(33, 203);
            label4.Name = "label4";
            label4.Size = new Size(149, 22);
            label4.TabIndex = 4;
            label4.Text = "HOŞ GELDİNİZ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(84, 95);
            label1.Name = "label1";
            label1.Size = new Size(33, 19);
            label1.TabIndex = 0;
            label1.Text = "T.C";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 135);
            label2.Name = "label2";
            label2.Size = new Size(200, 19);
            label2.TabIndex = 2;
            label2.Text = "BEYKENT ÜNİVERSİTESİ";
            // 
            // FF
            // 
            FF.AutoSize = true;
            FF.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            FF.ForeColor = Color.White;
            FF.Location = new Point(58, 114);
            FF.Name = "FF";
            FF.Size = new Size(88, 19);
            FF.TabIndex = 1;
            FF.Text = "İSTANBUL";
            // 
            // kayitislemleripanel
            // 
            kayitislemleripanel.BackColor = Color.FromArgb(35, 40, 45);
            kayitislemleripanel.BorderStyle = BorderStyle.FixedSingle;
            kayitislemleripanel.Controls.Add(btnOgrenciKayit);
            kayitislemleripanel.Controls.Add(btnOgretmenKayit);
            kayitislemleripanel.Controls.Add(kayitislemButon);
            kayitislemleripanel.Location = new Point(225, 44);
            kayitislemleripanel.MaximumSize = new Size(148, 209);
            kayitislemleripanel.MinimumSize = new Size(148, 47);
            kayitislemleripanel.Name = "kayitislemleripanel";
            kayitislemleripanel.Size = new Size(148, 47);
            kayitislemleripanel.TabIndex = 8;
            // 
            // kayitislemButon
            // 
            kayitislemButon.Font = new Font("Microsoft Sans Serif", 10.25F);
            kayitislemButon.Location = new Point(2, 3);
            kayitislemButon.Name = "kayitislemButon";
            kayitislemButon.Size = new Size(144, 40);
            kayitislemButon.TabIndex = 11;
            kayitislemButon.Text = "Kayıt İşlemleri";
            kayitislemButon.UseVisualStyleBackColor = true;
            kayitislemButon.Click += kayitislemButon_Click;
            // 
            // dersislemleripanel
            // 
            dersislemleripanel.BackColor = Color.FromArgb(35, 40, 45);
            dersislemleripanel.BorderStyle = BorderStyle.FixedSingle;
            dersislemleripanel.Controls.Add(dersislemButon);
            dersislemleripanel.Controls.Add(DevamsizlikTakip);
            dersislemleripanel.Controls.Add(sinifSecim);
            dersislemleripanel.Controls.Add(DersProgrami);
            dersislemleripanel.Controls.Add(btnSinavYonetim);
            dersislemleripanel.Location = new Point(419, 44);
            dersislemleripanel.MaximumSize = new Size(148, 308);
            dersislemleripanel.MinimumSize = new Size(148, 47);
            dersislemleripanel.Name = "dersislemleripanel";
            dersislemleripanel.Size = new Size(148, 47);
            dersislemleripanel.TabIndex = 9;
            // 
            // dersislemButon
            // 
            dersislemButon.Font = new Font("Microsoft Sans Serif", 10.25F);
            dersislemButon.Location = new Point(3, 3);
            dersislemButon.Name = "dersislemButon";
            dersislemButon.Size = new Size(142, 40);
            dersislemButon.TabIndex = 13;
            dersislemButon.Text = "Sınıf İşlemleri";
            dersislemButon.UseVisualStyleBackColor = true;
            dersislemButon.Click += dersislemButon_Click;
            // 
            // digerislemlerpanel
            // 
            digerislemlerpanel.BackColor = Color.FromArgb(35, 40, 45);
            digerislemlerpanel.BorderStyle = BorderStyle.FixedSingle;
            digerislemlerpanel.Controls.Add(btnKutuphaneYonetim);
            digerislemlerpanel.Controls.Add(digerislemButon);
            digerislemlerpanel.Location = new Point(609, 44);
            digerislemlerpanel.MaximumSize = new Size(148, 160);
            digerislemlerpanel.MinimumSize = new Size(148, 47);
            digerislemlerpanel.Name = "digerislemlerpanel";
            digerislemlerpanel.Size = new Size(148, 47);
            digerislemlerpanel.TabIndex = 10;
            // 
            // digerislemButon
            // 
            digerislemButon.Font = new Font("Microsoft Sans Serif", 10.25F);
            digerislemButon.Location = new Point(4, 3);
            digerislemButon.Name = "digerislemButon";
            digerislemButon.Size = new Size(141, 40);
            digerislemButon.TabIndex = 12;
            digerislemButon.Text = "Diğer İşlemler";
            digerislemButon.UseVisualStyleBackColor = true;
            digerislemButon.Click += digerislemButon_Click;
            // 
            // kayitislemZamanlayici
            // 
            kayitislemZamanlayici.Interval = 10;
            kayitislemZamanlayici.Tick += kayitislemZamanlayici_Tick_1;
            // 
            // digerislemZamanlayici
            // 
            digerislemZamanlayici.Interval = 10;
            digerislemZamanlayici.Tick += digerislemZamanlayici_Tick;
            // 
            // dersislemZamanlayici
            // 
            dersislemZamanlayici.Interval = 15;
            dersislemZamanlayici.Tick += dersislemZamanlayici_Tick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // anasayfaAnlikSaatTarih
            // 
            anasayfaAnlikSaatTarih.Tick += anasayfaAnlikSaatTarih_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.beykentüniicon;
            pictureBox1.Location = new Point(48, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // AnasayfaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(787, 422);
            Controls.Add(digerislemlerpanel);
            Controls.Add(dersislemleripanel);
            Controls.Add(kayitislemleripanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(803, 461);
            MinimumSize = new Size(803, 461);
            Name = "AnasayfaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += AnasayfaForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            kayitislemleripanel.ResumeLayout(false);
            dersislemleripanel.ResumeLayout(false);
            digerislemlerpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnOgrenciKayit;
        private Button btnOgretmenKayit;
        private Button DersProgrami;
        private Button btnKutuphaneYonetim;
        private Button btnSinavYonetim;
        private Button DevamsizlikTakip;
        private Button sinifSecim;
        private Panel panel1;
        private Panel kayitislemleripanel;
        private Panel dersislemleripanel;
        private Panel digerislemlerpanel;
        private Label FF;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private System.Windows.Forms.Timer kayitislemZamanlayici;
        private Button kayitislemButon;
        private Button digerislemButon;
        private Button dersislemButon;
        private System.Windows.Forms.Timer digerislemZamanlayici;
        private System.Windows.Forms.Timer dersislemZamanlayici;
        private ContextMenuStrip contextMenuStrip1;
        private Label anliksaat;
        private System.Windows.Forms.Timer anasayfaAnlikSaatTarih;
        private Label anliktarih;
        private PictureBox pictureBox1;
    }
}
