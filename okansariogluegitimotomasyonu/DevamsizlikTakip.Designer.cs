namespace okansariogluegitimotomasyonu
{
    partial class DevamsizlikTakip
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label3 = new Label();
            DevamsizlikEkle = new Button();
            DevamsizlikDuzenle = new Button();
            DevamsizlikSil = new Button();
            txtDevamsizlikTC = new ComboBox();
            DevamsizlikAra = new Button();
            txtDevamsizlikTarih = new DateTimePicker();
            txtDevamsizlikNeden = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtDevamsizlikAd = new TextBox();
            txtDevamsizlikSoyad = new TextBox();
            devamsizlikListe = new ListView();
            devamsizlikOgrenciTC = new ColumnHeader();
            devamsizlikAd = new ColumnHeader();
            devamsizlikSoyad = new ColumnHeader();
            devamsizlikTarih = new ColumnHeader();
            devamsizlikNeden = new ColumnHeader();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label5 = new Label();
            FF = new Label();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 99F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 17F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 93F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156F));
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 8, 1);
            tableLayoutPanel1.Controls.Add(DevamsizlikEkle, 5, 5);
            tableLayoutPanel1.Controls.Add(DevamsizlikDuzenle, 7, 5);
            tableLayoutPanel1.Controls.Add(DevamsizlikSil, 9, 5);
            tableLayoutPanel1.Controls.Add(txtDevamsizlikTC, 3, 1);
            tableLayoutPanel1.Controls.Add(DevamsizlikAra, 3, 5);
            tableLayoutPanel1.Controls.Add(txtDevamsizlikTarih, 11, 1);
            tableLayoutPanel1.Controls.Add(txtDevamsizlikNeden, 11, 3);
            tableLayoutPanel1.Controls.Add(label4, 8, 3);
            tableLayoutPanel1.Controls.Add(label6, 5, 1);
            tableLayoutPanel1.Controls.Add(label7, 5, 3);
            tableLayoutPanel1.Controls.Add(txtDevamsizlikAd, 7, 1);
            tableLayoutPanel1.Controls.Add(txtDevamsizlikSoyad, 7, 3);
            tableLayoutPanel1.Location = new Point(1, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 6F));
            tableLayoutPanel1.Size = new Size(903, 117);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Maiandra GD", 8.25F);
            label1.Location = new Point(11, 6);
            label1.Name = "label1";
            label1.Size = new Size(114, 30);
            label1.TabIndex = 0;
            label1.Text = "TC :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label3, 3);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Maiandra GD", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(489, 6);
            label3.Name = "label3";
            label3.Size = new Size(118, 30);
            label3.TabIndex = 2;
            label3.Text = "Devamsızlık Tarihi :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DevamsizlikEkle
            // 
            DevamsizlikEkle.Dock = DockStyle.Fill;
            DevamsizlikEkle.Font = new Font("Maiandra GD", 10.25F);
            DevamsizlikEkle.Location = new Point(267, 81);
            DevamsizlikEkle.Name = "DevamsizlikEkle";
            tableLayoutPanel1.SetRowSpan(DevamsizlikEkle, 2);
            DevamsizlikEkle.Size = new Size(94, 33);
            DevamsizlikEkle.TabIndex = 8;
            DevamsizlikEkle.Text = "Ekle";
            DevamsizlikEkle.UseVisualStyleBackColor = true;
            DevamsizlikEkle.Click += DevamsizlikEkle_Click;
            // 
            // DevamsizlikDuzenle
            // 
            DevamsizlikDuzenle.Dock = DockStyle.Fill;
            DevamsizlikDuzenle.Font = new Font("Maiandra GD", 10.25F);
            DevamsizlikDuzenle.Location = new Point(375, 81);
            DevamsizlikDuzenle.Name = "DevamsizlikDuzenle";
            tableLayoutPanel1.SetRowSpan(DevamsizlikDuzenle, 2);
            DevamsizlikDuzenle.Size = new Size(108, 33);
            DevamsizlikDuzenle.TabIndex = 9;
            DevamsizlikDuzenle.Text = "Düzenle";
            DevamsizlikDuzenle.UseVisualStyleBackColor = true;
            DevamsizlikDuzenle.Click += DevamsizlikDuzenle_Click;
            // 
            // DevamsizlikSil
            // 
            DevamsizlikSil.Dock = DockStyle.Fill;
            DevamsizlikSil.Font = new Font("Maiandra GD", 10.25F);
            DevamsizlikSil.Location = new Point(497, 81);
            DevamsizlikSil.Name = "DevamsizlikSil";
            tableLayoutPanel1.SetRowSpan(DevamsizlikSil, 2);
            DevamsizlikSil.Size = new Size(93, 33);
            DevamsizlikSil.TabIndex = 10;
            DevamsizlikSil.Text = "Sil";
            DevamsizlikSil.UseVisualStyleBackColor = true;
            DevamsizlikSil.Click += DevamsizlikSil_Click;
            // 
            // txtDevamsizlikTC
            // 
            txtDevamsizlikTC.Dock = DockStyle.Fill;
            txtDevamsizlikTC.FormattingEnabled = true;
            txtDevamsizlikTC.Location = new Point(139, 9);
            txtDevamsizlikTC.Name = "txtDevamsizlikTC";
            txtDevamsizlikTC.Size = new Size(114, 28);
            txtDevamsizlikTC.TabIndex = 12;
            // 
            // DevamsizlikAra
            // 
            DevamsizlikAra.Dock = DockStyle.Fill;
            DevamsizlikAra.Font = new Font("Maiandra GD", 10.25F);
            DevamsizlikAra.Location = new Point(139, 81);
            DevamsizlikAra.Name = "DevamsizlikAra";
            tableLayoutPanel1.SetRowSpan(DevamsizlikAra, 2);
            DevamsizlikAra.Size = new Size(114, 33);
            DevamsizlikAra.TabIndex = 7;
            DevamsizlikAra.Text = "Ara";
            DevamsizlikAra.UseVisualStyleBackColor = true;
            DevamsizlikAra.Click += DevamsizlikAra_Click;
            // 
            // txtDevamsizlikTarih
            // 
            txtDevamsizlikTarih.CalendarFont = new Font("Microsoft Sans Serif", 8.25F);
            tableLayoutPanel1.SetColumnSpan(txtDevamsizlikTarih, 3);
            txtDevamsizlikTarih.Location = new Point(613, 9);
            txtDevamsizlikTarih.Name = "txtDevamsizlikTarih";
            txtDevamsizlikTarih.Size = new Size(216, 27);
            txtDevamsizlikTarih.TabIndex = 4;
            // 
            // txtDevamsizlikNeden
            // 
            tableLayoutPanel1.SetColumnSpan(txtDevamsizlikNeden, 3);
            txtDevamsizlikNeden.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtDevamsizlikNeden.Location = new Point(613, 45);
            txtDevamsizlikNeden.Multiline = true;
            txtDevamsizlikNeden.Name = "txtDevamsizlikNeden";
            txtDevamsizlikNeden.Size = new Size(216, 24);
            txtDevamsizlikNeden.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label4, 3);
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Maiandra GD", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(489, 42);
            label4.Name = "label4";
            label4.Size = new Size(118, 30);
            label4.TabIndex = 3;
            label4.Text = "Devamsızlık Nedeni :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Maiandra GD", 8.25F);
            label6.Location = new Point(267, 6);
            label6.Name = "label6";
            label6.Size = new Size(94, 30);
            label6.TabIndex = 13;
            label6.Text = "Ad :";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Maiandra GD", 8.25F);
            label7.Location = new Point(267, 42);
            label7.Name = "label7";
            label7.Size = new Size(94, 30);
            label7.TabIndex = 14;
            label7.Text = "Soyad :";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDevamsizlikAd
            // 
            txtDevamsizlikAd.Location = new Point(375, 9);
            txtDevamsizlikAd.Name = "txtDevamsizlikAd";
            txtDevamsizlikAd.Size = new Size(100, 27);
            txtDevamsizlikAd.TabIndex = 15;
            // 
            // txtDevamsizlikSoyad
            // 
            txtDevamsizlikSoyad.Location = new Point(375, 45);
            txtDevamsizlikSoyad.Name = "txtDevamsizlikSoyad";
            txtDevamsizlikSoyad.Size = new Size(108, 27);
            txtDevamsizlikSoyad.TabIndex = 16;
            // 
            // devamsizlikListe
            // 
            devamsizlikListe.Columns.AddRange(new ColumnHeader[] { devamsizlikOgrenciTC, devamsizlikAd, devamsizlikSoyad, devamsizlikTarih, devamsizlikNeden });
            devamsizlikListe.Dock = DockStyle.Bottom;
            devamsizlikListe.Location = new Point(0, 166);
            devamsizlikListe.Name = "devamsizlikListe";
            devamsizlikListe.Size = new Size(904, 284);
            devamsizlikListe.TabIndex = 1;
            devamsizlikListe.UseCompatibleStateImageBehavior = false;
            devamsizlikListe.View = View.Details;
            devamsizlikListe.MouseClick += devamsizlikListe_MouseClick;
            // 
            // devamsizlikOgrenciTC
            // 
            devamsizlikOgrenciTC.Text = "TC";
            devamsizlikOgrenciTC.Width = 140;
            // 
            // devamsizlikAd
            // 
            devamsizlikAd.Text = "Ad";
            devamsizlikAd.TextAlign = HorizontalAlignment.Center;
            devamsizlikAd.Width = 130;
            // 
            // devamsizlikSoyad
            // 
            devamsizlikSoyad.Text = "Soyad";
            devamsizlikSoyad.TextAlign = HorizontalAlignment.Center;
            devamsizlikSoyad.Width = 140;
            // 
            // devamsizlikTarih
            // 
            devamsizlikTarih.Text = "Tarih";
            devamsizlikTarih.TextAlign = HorizontalAlignment.Center;
            devamsizlikTarih.Width = 140;
            // 
            // devamsizlikNeden
            // 
            devamsizlikNeden.Text = "Devamsızlık Neden";
            devamsizlikNeden.TextAlign = HorizontalAlignment.Center;
            devamsizlikNeden.Width = 200;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.beykentüniicon;
            pictureBox1.Location = new Point(22, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(101, 5);
            label2.Name = "label2";
            label2.Size = new Size(33, 19);
            label2.TabIndex = 3;
            label2.Text = "T.C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(73, 21);
            label5.Name = "label5";
            label5.Size = new Size(200, 19);
            label5.TabIndex = 5;
            label5.Text = "BEYKENT ÜNİVERSİTESİ";
            // 
            // FF
            // 
            FF.AutoSize = true;
            FF.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            FF.ForeColor = Color.White;
            FF.Location = new Point(140, 5);
            FF.Name = "FF";
            FF.Size = new Size(88, 19);
            FF.TabIndex = 4;
            FF.Text = "İSTANBUL";
            // 
            // DevamsizlikTakip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 40, 45);
            ClientSize = new Size(904, 450);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(FF);
            Controls.Add(pictureBox1);
            Controls.Add(devamsizlikListe);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(845, 489);
            Name = "DevamsizlikTakip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DevamsizlikTakip";
            Load += DevamsizlikTakip_Load_1;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button DevamsizlikEkle;
        private Button DevamsizlikDuzenle;
        private Button DevamsizlikSil;
        private Button DevamsizlikAra;
        private ListView listView1;
        public DateTimePicker txtDevamsizlikTarih;
        public TextBox txtDevamsizlikNeden;
        public ListView devamsizlikListe;
        private ComboBox txtDevamsizlikTC;
        public ColumnHeader devamsizlikOgrenciTC;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label5;
        private Label FF;
        private Label label6;
        private Label label7;
        private TextBox txtDevamsizlikAd;
        private TextBox txtDevamsizlikSoyad;
        public ColumnHeader devamsizlikAd;
        public ColumnHeader devamsizlikSoyad;
        public ColumnHeader devamsizlikTarih;
        public ColumnHeader devamsizlikNeden;
    }
}