namespace SunriseHotel.UI
{
    partial class OdalarPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdalarPanel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnOdaSil = new System.Windows.Forms.Button();
            this.btnOdaGuncelle = new System.Windows.Forms.Button();
            this.btnOdaEkle = new System.Windows.Forms.Button();
            this.gbOdalar = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOdaFiyat = new System.Windows.Forms.TextBox();
            this.txtOdaTuru = new System.Windows.Forms.TextBox();
            this.txtOdaNumara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgOdalar = new System.Windows.Forms.DataGridView();
            this.OdaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gbOdalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOdalar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.btnOdaSil);
            this.panel1.Controls.Add(this.btnOdaGuncelle);
            this.panel1.Controls.Add(this.btnOdaEkle);
            this.panel1.Location = new System.Drawing.Point(0, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 44);
            this.panel1.TabIndex = 10;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(739, 4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(150, 40);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnOdaSil
            // 
            this.btnOdaSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnOdaSil.FlatAppearance.BorderSize = 0;
            this.btnOdaSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaSil.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaSil.ForeColor = System.Drawing.Color.White;
            this.btnOdaSil.Location = new System.Drawing.Point(508, 4);
            this.btnOdaSil.Name = "btnOdaSil";
            this.btnOdaSil.Size = new System.Drawing.Size(150, 40);
            this.btnOdaSil.TabIndex = 2;
            this.btnOdaSil.Text = "Sil";
            this.btnOdaSil.UseVisualStyleBackColor = false;
            this.btnOdaSil.Click += new System.EventHandler(this.btnOdaSil_Click);
            // 
            // btnOdaGuncelle
            // 
            this.btnOdaGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnOdaGuncelle.FlatAppearance.BorderSize = 0;
            this.btnOdaGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaGuncelle.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnOdaGuncelle.Location = new System.Drawing.Point(277, 4);
            this.btnOdaGuncelle.Name = "btnOdaGuncelle";
            this.btnOdaGuncelle.Size = new System.Drawing.Size(150, 40);
            this.btnOdaGuncelle.TabIndex = 1;
            this.btnOdaGuncelle.Text = "Güncelle";
            this.btnOdaGuncelle.UseVisualStyleBackColor = false;
            this.btnOdaGuncelle.Click += new System.EventHandler(this.btnOdaGuncelle_Click);
            // 
            // btnOdaEkle
            // 
            this.btnOdaEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.btnOdaEkle.FlatAppearance.BorderSize = 0;
            this.btnOdaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaEkle.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaEkle.ForeColor = System.Drawing.Color.White;
            this.btnOdaEkle.Location = new System.Drawing.Point(50, 3);
            this.btnOdaEkle.Name = "btnOdaEkle";
            this.btnOdaEkle.Size = new System.Drawing.Size(150, 40);
            this.btnOdaEkle.TabIndex = 0;
            this.btnOdaEkle.Text = "Ekle";
            this.btnOdaEkle.UseVisualStyleBackColor = false;
            this.btnOdaEkle.Click += new System.EventHandler(this.btnOdaEkle_Click);
            // 
            // gbOdalar
            // 
            this.gbOdalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.gbOdalar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbOdalar.BackgroundImage")));
            this.gbOdalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbOdalar.Controls.Add(this.panel1);
            this.gbOdalar.Controls.Add(this.label3);
            this.gbOdalar.Controls.Add(this.txtOdaFiyat);
            this.gbOdalar.Controls.Add(this.txtOdaTuru);
            this.gbOdalar.Controls.Add(this.txtOdaNumara);
            this.gbOdalar.Controls.Add(this.label2);
            this.gbOdalar.Controls.Add(this.label1);
            this.gbOdalar.Location = new System.Drawing.Point(20, 240);
            this.gbOdalar.Name = "gbOdalar";
            this.gbOdalar.Size = new System.Drawing.Size(960, 330);
            this.gbOdalar.TabIndex = 9;
            this.gbOdalar.TabStop = false;
            this.gbOdalar.Text = "Oda Bilgileri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(655, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Oda Fiyatı";
            // 
            // txtOdaFiyat
            // 
            this.txtOdaFiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOdaFiyat.Location = new System.Drawing.Point(661, 86);
            this.txtOdaFiyat.Name = "txtOdaFiyat";
            this.txtOdaFiyat.Size = new System.Drawing.Size(280, 27);
            this.txtOdaFiyat.TabIndex = 15;
            // 
            // txtOdaTuru
            // 
            this.txtOdaTuru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOdaTuru.Location = new System.Drawing.Point(341, 86);
            this.txtOdaTuru.Name = "txtOdaTuru";
            this.txtOdaTuru.Size = new System.Drawing.Size(280, 27);
            this.txtOdaTuru.TabIndex = 14;
            // 
            // txtOdaNumara
            // 
            this.txtOdaNumara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOdaNumara.Location = new System.Drawing.Point(21, 86);
            this.txtOdaNumara.Name = "txtOdaNumara";
            this.txtOdaNumara.Size = new System.Drawing.Size(280, 27);
            this.txtOdaNumara.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(335, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Oda Türü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Oda Numarası";
            // 
            // dgOdalar
            // 
            this.dgOdalar.AllowUserToAddRows = false;
            this.dgOdalar.AllowUserToDeleteRows = false;
            this.dgOdalar.BackgroundColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOdalar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOdalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOdalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OdaID,
            this.OdaNo,
            this.OdaTuru,
            this.OdaFiyati});
            this.dgOdalar.Location = new System.Drawing.Point(20, 20);
            this.dgOdalar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgOdalar.MultiSelect = false;
            this.dgOdalar.Name = "dgOdalar";
            this.dgOdalar.ReadOnly = true;
            this.dgOdalar.RowHeadersWidth = 51;
            this.dgOdalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOdalar.Size = new System.Drawing.Size(960, 200);
            this.dgOdalar.TabIndex = 8;
            this.dgOdalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOdalar_CellClick);
            // 
            // OdaID
            // 
            this.OdaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OdaID.HeaderText = "Oda ID";
            this.OdaID.MinimumWidth = 6;
            this.OdaID.Name = "OdaID";
            this.OdaID.ReadOnly = true;
            // 
            // OdaNo
            // 
            this.OdaNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OdaNo.HeaderText = "Oda Numarası";
            this.OdaNo.MinimumWidth = 6;
            this.OdaNo.Name = "OdaNo";
            this.OdaNo.ReadOnly = true;
            // 
            // OdaTuru
            // 
            this.OdaTuru.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OdaTuru.HeaderText = "Oda Türü";
            this.OdaTuru.MinimumWidth = 6;
            this.OdaTuru.Name = "OdaTuru";
            this.OdaTuru.ReadOnly = true;
            // 
            // OdaFiyati
            // 
            this.OdaFiyati.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OdaFiyati.HeaderText = "Fiyat";
            this.OdaFiyati.MinimumWidth = 6;
            this.OdaFiyati.Name = "OdaFiyati";
            this.OdaFiyati.ReadOnly = true;
            // 
            // OdalarPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.gbOdalar);
            this.Controls.Add(this.dgOdalar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OdalarPanel";
            this.Size = new System.Drawing.Size(1000, 600);
            this.panel1.ResumeLayout(false);
            this.gbOdalar.ResumeLayout(false);
            this.gbOdalar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOdalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnOdaSil;
        private System.Windows.Forms.Button btnOdaGuncelle;
        private System.Windows.Forms.Button btnOdaEkle;
        private System.Windows.Forms.GroupBox gbOdalar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOdaFiyat;
        private System.Windows.Forms.TextBox txtOdaTuru;
        private System.Windows.Forms.TextBox txtOdaNumara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgOdalar;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaFiyati;
    }
}
