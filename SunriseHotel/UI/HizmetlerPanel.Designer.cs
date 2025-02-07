namespace SunriseHotel.UI
{
    partial class HizmetlerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HizmetlerPanel));
            this.dgHizmetler = new System.Windows.Forms.DataGridView();
            this.HizmetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HizmetAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HizmetFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbHizmetler = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnHizmetSil = new System.Windows.Forms.Button();
            this.btnHizmetGuncelle = new System.Windows.Forms.Button();
            this.btnHizmetEkle = new System.Windows.Forms.Button();
            this.txtHizmetFiyat = new System.Windows.Forms.TextBox();
            this.txtHizmetAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgHizmetler)).BeginInit();
            this.gbHizmetler.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgHizmetler
            // 
            this.dgHizmetler.AllowUserToAddRows = false;
            this.dgHizmetler.AllowUserToDeleteRows = false;
            this.dgHizmetler.BackgroundColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHizmetler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgHizmetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHizmetler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HizmetID,
            this.HizmetAd,
            this.HizmetFiyat});
            this.dgHizmetler.Location = new System.Drawing.Point(20, 20);
            this.dgHizmetler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgHizmetler.MultiSelect = false;
            this.dgHizmetler.Name = "dgHizmetler";
            this.dgHizmetler.ReadOnly = true;
            this.dgHizmetler.RowHeadersWidth = 51;
            this.dgHizmetler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHizmetler.Size = new System.Drawing.Size(960, 200);
            this.dgHizmetler.TabIndex = 0;
            this.dgHizmetler.SelectionChanged += new System.EventHandler(this.dgHizmetler_SelectionChanged);
            // 
            // HizmetID
            // 
            this.HizmetID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HizmetID.HeaderText = "Hizmet ID";
            this.HizmetID.MinimumWidth = 6;
            this.HizmetID.Name = "HizmetID";
            this.HizmetID.ReadOnly = true;
            // 
            // HizmetAd
            // 
            this.HizmetAd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HizmetAd.HeaderText = "Hizmet Adı";
            this.HizmetAd.MinimumWidth = 6;
            this.HizmetAd.Name = "HizmetAd";
            this.HizmetAd.ReadOnly = true;
            // 
            // HizmetFiyat
            // 
            this.HizmetFiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HizmetFiyat.HeaderText = "Fiyat";
            this.HizmetFiyat.MinimumWidth = 6;
            this.HizmetFiyat.Name = "HizmetFiyat";
            this.HizmetFiyat.ReadOnly = true;
            // 
            // gbHizmetler
            // 
            this.gbHizmetler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.gbHizmetler.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbHizmetler.BackgroundImage")));
            this.gbHizmetler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbHizmetler.Controls.Add(this.panel1);
            this.gbHizmetler.Controls.Add(this.txtHizmetFiyat);
            this.gbHizmetler.Controls.Add(this.txtHizmetAd);
            this.gbHizmetler.Controls.Add(this.label2);
            this.gbHizmetler.Controls.Add(this.label1);
            this.gbHizmetler.Location = new System.Drawing.Point(3, 240);
            this.gbHizmetler.Name = "gbHizmetler";
            this.gbHizmetler.Size = new System.Drawing.Size(977, 336);
            this.gbHizmetler.TabIndex = 1;
            this.gbHizmetler.TabStop = false;
            this.gbHizmetler.Text = "Hizmet Bilgileri";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.btnHizmetSil);
            this.panel1.Controls.Add(this.btnHizmetGuncelle);
            this.panel1.Controls.Add(this.btnHizmetEkle);
            this.panel1.Location = new System.Drawing.Point(11, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 38);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Location = new System.Drawing.Point(698, 0);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(150, 40);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnHizmetSil
            // 
            this.btnHizmetSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnHizmetSil.FlatAppearance.BorderSize = 0;
            this.btnHizmetSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHizmetSil.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHizmetSil.ForeColor = System.Drawing.Color.Snow;
            this.btnHizmetSil.Location = new System.Drawing.Point(494, -2);
            this.btnHizmetSil.Name = "btnHizmetSil";
            this.btnHizmetSil.Size = new System.Drawing.Size(150, 40);
            this.btnHizmetSil.TabIndex = 2;
            this.btnHizmetSil.Text = "Sil";
            this.btnHizmetSil.UseVisualStyleBackColor = false;
            this.btnHizmetSil.Click += new System.EventHandler(this.btnHizmetSil_Click);
            // 
            // btnHizmetGuncelle
            // 
            this.btnHizmetGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnHizmetGuncelle.FlatAppearance.BorderSize = 0;
            this.btnHizmetGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHizmetGuncelle.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHizmetGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnHizmetGuncelle.Location = new System.Drawing.Point(278, 0);
            this.btnHizmetGuncelle.Name = "btnHizmetGuncelle";
            this.btnHizmetGuncelle.Size = new System.Drawing.Size(150, 40);
            this.btnHizmetGuncelle.TabIndex = 1;
            this.btnHizmetGuncelle.Text = "Güncelle";
            this.btnHizmetGuncelle.UseVisualStyleBackColor = false;
            this.btnHizmetGuncelle.Click += new System.EventHandler(this.btnHizmetGuncelle_Click);
            // 
            // btnHizmetEkle
            // 
            this.btnHizmetEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.btnHizmetEkle.FlatAppearance.BorderSize = 0;
            this.btnHizmetEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHizmetEkle.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHizmetEkle.ForeColor = System.Drawing.Color.Snow;
            this.btnHizmetEkle.Location = new System.Drawing.Point(77, -2);
            this.btnHizmetEkle.Name = "btnHizmetEkle";
            this.btnHizmetEkle.Size = new System.Drawing.Size(150, 40);
            this.btnHizmetEkle.TabIndex = 0;
            this.btnHizmetEkle.Text = "Ekle";
            this.btnHizmetEkle.UseVisualStyleBackColor = false;
            this.btnHizmetEkle.Click += new System.EventHandler(this.btnHizmetEkle_Click);
            // 
            // txtHizmetFiyat
            // 
            this.txtHizmetFiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHizmetFiyat.Location = new System.Drawing.Point(342, 101);
            this.txtHizmetFiyat.Name = "txtHizmetFiyat";
            this.txtHizmetFiyat.Size = new System.Drawing.Size(280, 32);
            this.txtHizmetFiyat.TabIndex = 14;
            // 
            // txtHizmetAd
            // 
            this.txtHizmetAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHizmetAd.Location = new System.Drawing.Point(17, 101);
            this.txtHizmetAd.Name = "txtHizmetAd";
            this.txtHizmetAd.Size = new System.Drawing.Size(280, 32);
            this.txtHizmetAd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(336, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hizmet Fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hizmet Adı";
            // 
            // HizmetlerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.gbHizmetler);
            this.Controls.Add(this.dgHizmetler);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(27, 31, 27, 31);
            this.Name = "HizmetlerPanel";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dgHizmetler)).EndInit();
            this.gbHizmetler.ResumeLayout(false);
            this.gbHizmetler.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHizmetler;
        private System.Windows.Forms.GroupBox gbHizmetler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnHizmetSil;
        private System.Windows.Forms.Button btnHizmetGuncelle;
        private System.Windows.Forms.Button btnHizmetEkle;
        private System.Windows.Forms.TextBox txtHizmetFiyat;
        private System.Windows.Forms.TextBox txtHizmetAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn HizmetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HizmetAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn HizmetFiyat;
    }
}
