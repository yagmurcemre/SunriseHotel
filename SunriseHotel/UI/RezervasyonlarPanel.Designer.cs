namespace SunriseHotel.UI
{
    partial class RezervasyonlarPanel
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervasyonlarPanel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnRezervasyonSil = new System.Windows.Forms.Button();
            this.btnRezervasyonGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRezervasyonEkle = new System.Windows.Forms.Button();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.nudKisiSayisi = new System.Windows.Forms.NumericUpDown();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbHizmetler = new System.Windows.Forms.ComboBox();
            this.cmbOdalar = new System.Windows.Forms.ComboBox();
            this.cmbMusteriler = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFaturaGoruntule = new System.Windows.Forms.Button();
            this.gbRezervasyon = new System.Windows.Forms.GroupBox();
            this.dgRezervasyonlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudKisiSayisi)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbRezervasyon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRezervasyonlar)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label7.Location = new System.Drawing.Point(16, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Toplam Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label5.Location = new System.Drawing.Point(336, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Çıkış Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(16, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giriş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(656, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hizmet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(336, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Oda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Müşteri";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(764, 3);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(150, 40);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnRezervasyonSil
            // 
            this.btnRezervasyonSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnRezervasyonSil.FlatAppearance.BorderSize = 0;
            this.btnRezervasyonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervasyonSil.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyonSil.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonSil.Location = new System.Drawing.Point(398, 3);
            this.btnRezervasyonSil.Name = "btnRezervasyonSil";
            this.btnRezervasyonSil.Size = new System.Drawing.Size(150, 40);
            this.btnRezervasyonSil.TabIndex = 2;
            this.btnRezervasyonSil.Text = "Sil";
            this.btnRezervasyonSil.UseVisualStyleBackColor = false;
            this.btnRezervasyonSil.Click += new System.EventHandler(this.btnRezervasyonSil_Click);
            // 
            // btnRezervasyonGuncelle
            // 
            this.btnRezervasyonGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnRezervasyonGuncelle.FlatAppearance.BorderSize = 0;
            this.btnRezervasyonGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervasyonGuncelle.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyonGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonGuncelle.Location = new System.Drawing.Point(219, 3);
            this.btnRezervasyonGuncelle.Name = "btnRezervasyonGuncelle";
            this.btnRezervasyonGuncelle.Size = new System.Drawing.Size(150, 40);
            this.btnRezervasyonGuncelle.TabIndex = 1;
            this.btnRezervasyonGuncelle.Text = "Güncelle";
            this.btnRezervasyonGuncelle.UseVisualStyleBackColor = false;
            this.btnRezervasyonGuncelle.Click += new System.EventHandler(this.btnRezervasyonGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(656, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kişi Sayısı";
            // 
            // btnRezervasyonEkle
            // 
            this.btnRezervasyonEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.btnRezervasyonEkle.FlatAppearance.BorderSize = 0;
            this.btnRezervasyonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervasyonEkle.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyonEkle.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonEkle.Location = new System.Drawing.Point(35, 3);
            this.btnRezervasyonEkle.Name = "btnRezervasyonEkle";
            this.btnRezervasyonEkle.Size = new System.Drawing.Size(150, 40);
            this.btnRezervasyonEkle.TabIndex = 0;
            this.btnRezervasyonEkle.Text = "Ekle";
            this.btnRezervasyonEkle.UseVisualStyleBackColor = false;
            this.btnRezervasyonEkle.Click += new System.EventHandler(this.btnRezervasyonEkle_Click);
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtToplamTutar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToplamTutar.Location = new System.Drawing.Point(21, 227);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(280, 32);
            this.txtToplamTutar.TabIndex = 6;
            // 
            // nudKisiSayisi
            // 
            this.nudKisiSayisi.Location = new System.Drawing.Point(660, 157);
            this.nudKisiSayisi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudKisiSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKisiSayisi.Name = "nudKisiSayisi";
            this.nudKisiSayisi.Size = new System.Drawing.Size(280, 32);
            this.nudKisiSayisi.TabIndex = 5;
            this.nudKisiSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.Location = new System.Drawing.Point(340, 157);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(280, 32);
            this.dtpCikisTarihi.TabIndex = 4;
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.Location = new System.Drawing.Point(21, 157);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(280, 32);
            this.dtpGirisTarihi.TabIndex = 3;
            // 
            // cmbHizmetler
            // 
            this.cmbHizmetler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHizmetler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHizmetler.FormattingEnabled = true;
            this.cmbHizmetler.Location = new System.Drawing.Point(661, 86);
            this.cmbHizmetler.Name = "cmbHizmetler";
            this.cmbHizmetler.Size = new System.Drawing.Size(280, 33);
            this.cmbHizmetler.TabIndex = 2;
            // 
            // cmbOdalar
            // 
            this.cmbOdalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOdalar.FormattingEnabled = true;
            this.cmbOdalar.Location = new System.Drawing.Point(341, 86);
            this.cmbOdalar.Name = "cmbOdalar";
            this.cmbOdalar.Size = new System.Drawing.Size(280, 33);
            this.cmbOdalar.TabIndex = 1;
            // 
            // cmbMusteriler
            // 
            this.cmbMusteriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMusteriler.FormattingEnabled = true;
            this.cmbMusteriler.Location = new System.Drawing.Point(21, 86);
            this.cmbMusteriler.Name = "cmbMusteriler";
            this.cmbMusteriler.Size = new System.Drawing.Size(280, 33);
            this.cmbMusteriler.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btnFaturaGoruntule);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.btnRezervasyonSil);
            this.panel1.Controls.Add(this.btnRezervasyonGuncelle);
            this.panel1.Controls.Add(this.btnRezervasyonEkle);
            this.panel1.Location = new System.Drawing.Point(0, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 50);
            this.panel1.TabIndex = 10;
            // 
            // btnFaturaGoruntule
            // 
            this.btnFaturaGoruntule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnFaturaGoruntule.FlatAppearance.BorderSize = 0;
            this.btnFaturaGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturaGoruntule.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturaGoruntule.ForeColor = System.Drawing.Color.White;
            this.btnFaturaGoruntule.Location = new System.Drawing.Point(577, 3);
            this.btnFaturaGoruntule.Name = "btnFaturaGoruntule";
            this.btnFaturaGoruntule.Size = new System.Drawing.Size(150, 40);
            this.btnFaturaGoruntule.TabIndex = 4;
            this.btnFaturaGoruntule.Text = "Fatura Görüntüle";
            this.btnFaturaGoruntule.UseVisualStyleBackColor = false;
            this.btnFaturaGoruntule.Click += new System.EventHandler(this.btnFaturaGoruntule_Click);
            // 
            // gbRezervasyon
            // 
            this.gbRezervasyon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.gbRezervasyon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbRezervasyon.BackgroundImage")));
            this.gbRezervasyon.Controls.Add(this.panel1);
            this.gbRezervasyon.Controls.Add(this.label7);
            this.gbRezervasyon.Controls.Add(this.label6);
            this.gbRezervasyon.Controls.Add(this.label5);
            this.gbRezervasyon.Controls.Add(this.label4);
            this.gbRezervasyon.Controls.Add(this.label3);
            this.gbRezervasyon.Controls.Add(this.label2);
            this.gbRezervasyon.Controls.Add(this.label1);
            this.gbRezervasyon.Controls.Add(this.txtToplamTutar);
            this.gbRezervasyon.Controls.Add(this.nudKisiSayisi);
            this.gbRezervasyon.Controls.Add(this.dtpCikisTarihi);
            this.gbRezervasyon.Controls.Add(this.dtpGirisTarihi);
            this.gbRezervasyon.Controls.Add(this.cmbHizmetler);
            this.gbRezervasyon.Controls.Add(this.cmbOdalar);
            this.gbRezervasyon.Controls.Add(this.cmbMusteriler);
            this.gbRezervasyon.Location = new System.Drawing.Point(20, 264);
            this.gbRezervasyon.Name = "gbRezervasyon";
            this.gbRezervasyon.Size = new System.Drawing.Size(960, 333);
            this.gbRezervasyon.TabIndex = 9;
            this.gbRezervasyon.TabStop = false;
            this.gbRezervasyon.Text = "Rezervasyon Bilgileri";
            // 
            // dgRezervasyonlar
            // 
            this.dgRezervasyonlar.AllowUserToAddRows = false;
            this.dgRezervasyonlar.AllowUserToDeleteRows = false;
            this.dgRezervasyonlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRezervasyonlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgRezervasyonlar.BackgroundColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRezervasyonlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRezervasyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRezervasyonlar.Location = new System.Drawing.Point(20, 32);
            this.dgRezervasyonlar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgRezervasyonlar.MultiSelect = false;
            this.dgRezervasyonlar.Name = "dgRezervasyonlar";
            this.dgRezervasyonlar.ReadOnly = true;
            this.dgRezervasyonlar.RowHeadersWidth = 51;
            this.dgRezervasyonlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRezervasyonlar.Size = new System.Drawing.Size(960, 200);
            this.dgRezervasyonlar.TabIndex = 8;
            this.dgRezervasyonlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRezervasyonlar_CellClick);
            // 
            // RezervasyonlarPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.gbRezervasyon);
            this.Controls.Add(this.dgRezervasyonlar);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RezervasyonlarPanel";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.nudKisiSayisi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbRezervasyon.ResumeLayout(false);
            this.gbRezervasyon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRezervasyonlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnRezervasyonSil;
        private System.Windows.Forms.Button btnRezervasyonGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRezervasyonEkle;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.NumericUpDown nudKisiSayisi;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
        private System.Windows.Forms.ComboBox cmbHizmetler;
        private System.Windows.Forms.ComboBox cmbOdalar;
        private System.Windows.Forms.ComboBox cmbMusteriler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbRezervasyon;
        private System.Windows.Forms.DataGridView dgRezervasyonlar;
        private System.Windows.Forms.Button btnFaturaGoruntule;
    }
}
