namespace SunriseHotel.UI
{
    partial class MusterilerPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusterilerPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.dgMusteriler = new System.Windows.Forms.DataGridView();
            this.MusteriID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TcKimlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriTelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbMusteri = new System.Windows.Forms.GroupBox();
            this.txtTcKimlik = new System.Windows.Forms.TextBox();
            this.txtMusteriTel = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMusteriler)).BeginInit();
            this.gbMusteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.btnMusteriSil);
            this.panel1.Controls.Add(this.btnMusteriGuncelle);
            this.panel1.Controls.Add(this.btnMusteriEkle);
            this.panel1.Location = new System.Drawing.Point(0, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 50);
            this.panel1.TabIndex = 13;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.Linen;
            this.btnTemizle.Location = new System.Drawing.Point(736, 3);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(150, 40);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnMusteriSil.FlatAppearance.BorderSize = 0;
            this.btnMusteriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriSil.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriSil.ForeColor = System.Drawing.Color.Linen;
            this.btnMusteriSil.Location = new System.Drawing.Point(508, 3);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(150, 40);
            this.btnMusteriSil.TabIndex = 2;
            this.btnMusteriSil.Text = "Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = false;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnMusteriGuncelle.FlatAppearance.BorderSize = 0;
            this.btnMusteriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriGuncelle.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriGuncelle.ForeColor = System.Drawing.Color.Linen;
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(265, 3);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(150, 40);
            this.btnMusteriGuncelle.TabIndex = 1;
            this.btnMusteriGuncelle.Text = "Güncelle";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = false;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.btnMusteriEkle.FlatAppearance.BorderSize = 0;
            this.btnMusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriEkle.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.ForeColor = System.Drawing.Color.Linen;
            this.btnMusteriEkle.Location = new System.Drawing.Point(42, 3);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(150, 40);
            this.btnMusteriEkle.TabIndex = 0;
            this.btnMusteriEkle.Text = "Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // dgMusteriler
            // 
            this.dgMusteriler.AllowUserToAddRows = false;
            this.dgMusteriler.AllowUserToDeleteRows = false;
            this.dgMusteriler.BackgroundColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMusteriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MusteriID,
            this.MusteriAd,
            this.MusteriSoyad,
            this.TcKimlik,
            this.MusteriTelNo});
            this.dgMusteriler.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgMusteriler.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgMusteriler.Location = new System.Drawing.Point(20, 21);
            this.dgMusteriler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgMusteriler.MultiSelect = false;
            this.dgMusteriler.Name = "dgMusteriler";
            this.dgMusteriler.ReadOnly = true;
            this.dgMusteriler.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgMusteriler.RowHeadersWidth = 51;
            this.dgMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMusteriler.Size = new System.Drawing.Size(960, 200);
            this.dgMusteriler.TabIndex = 11;
            this.dgMusteriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMusteriler_CellClick);
            // 
            // MusteriID
            // 
            this.MusteriID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MusteriID.HeaderText = "Müşteri ID";
            this.MusteriID.MinimumWidth = 6;
            this.MusteriID.Name = "MusteriID";
            this.MusteriID.ReadOnly = true;
            // 
            // MusteriAd
            // 
            this.MusteriAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MusteriAd.HeaderText = "Müşteri Adı";
            this.MusteriAd.MinimumWidth = 6;
            this.MusteriAd.Name = "MusteriAd";
            this.MusteriAd.ReadOnly = true;
            // 
            // MusteriSoyad
            // 
            this.MusteriSoyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MusteriSoyad.HeaderText = "Müşteri Soyadı";
            this.MusteriSoyad.MinimumWidth = 6;
            this.MusteriSoyad.Name = "MusteriSoyad";
            this.MusteriSoyad.ReadOnly = true;
            // 
            // TcKimlik
            // 
            this.TcKimlik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TcKimlik.HeaderText = "TC Kimlik";
            this.TcKimlik.MinimumWidth = 6;
            this.TcKimlik.Name = "TcKimlik";
            this.TcKimlik.ReadOnly = true;
            // 
            // MusteriTelNo
            // 
            this.MusteriTelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MusteriTelNo.HeaderText = "Telefon Numarası";
            this.MusteriTelNo.MinimumWidth = 6;
            this.MusteriTelNo.Name = "MusteriTelNo";
            this.MusteriTelNo.ReadOnly = true;
            // 
            // gbMusteri
            // 
            this.gbMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.gbMusteri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbMusteri.BackgroundImage")));
            this.gbMusteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbMusteri.Controls.Add(this.panel1);
            this.gbMusteri.Controls.Add(this.txtTcKimlik);
            this.gbMusteri.Controls.Add(this.txtMusteriTel);
            this.gbMusteri.Controls.Add(this.txtMusteriSoyad);
            this.gbMusteri.Controls.Add(this.txtMusteriAd);
            this.gbMusteri.Controls.Add(this.label4);
            this.gbMusteri.Controls.Add(this.label3);
            this.gbMusteri.Controls.Add(this.label2);
            this.gbMusteri.Controls.Add(this.label1);
            this.gbMusteri.Location = new System.Drawing.Point(20, 356);
            this.gbMusteri.Name = "gbMusteri";
            this.gbMusteri.Size = new System.Drawing.Size(960, 280);
            this.gbMusteri.TabIndex = 12;
            this.gbMusteri.TabStop = false;
            this.gbMusteri.Text = "Müşteri Bilgileri";
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(20, 163);
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(280, 27);
            this.txtTcKimlik.TabIndex = 14;
            // 
            // txtMusteriTel
            // 
            this.txtMusteriTel.Location = new System.Drawing.Point(661, 86);
            this.txtMusteriTel.Name = "txtMusteriTel";
            this.txtMusteriTel.Size = new System.Drawing.Size(280, 27);
            this.txtMusteriTel.TabIndex = 13;
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(341, 86);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(280, 27);
            this.txtMusteriSoyad.TabIndex = 12;
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(20, 86);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(280, 27);
            this.txtMusteriAd.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(16, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "TC Kimlik No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(655, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(336, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ad";
            // 
            // MusterilerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.dgMusteriler);
            this.Controls.Add(this.gbMusteri);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MusterilerPanel";
            this.Size = new System.Drawing.Size(1000, 658);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMusteriler)).EndInit();
            this.gbMusteri.ResumeLayout(false);
            this.gbMusteri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.DataGridView dgMusteriler;
        private System.Windows.Forms.GroupBox gbMusteri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.TextBox txtTcKimlik;
        private System.Windows.Forms.TextBox txtMusteriTel;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TcKimlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriTelNo;
    }
}
