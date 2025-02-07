using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SunriseHotel.BUSINESS;
using SunriseHotel.DAL;
using SunriseHotel.ENTITIES;
using System.Linq;

namespace SunriseHotel.UI
{
    public partial class RezervasyonlarPanel : UserControl
    {
        private readonly RezervasyonManager _rezervasyonManager;
        private readonly MusteriDal _musteriDal;
        private readonly OdaDal _odaDal;
        private readonly HizmetDal _hizmetDal;
        public RezervasyonlarPanel()
        {
            InitializeComponent();
            _rezervasyonManager = new RezervasyonManager();
            _musteriDal = new MusteriDal();
            _odaDal = new OdaDal();
            _hizmetDal = new HizmetDal();
            VerileriYukle();
            RezervasyonlariListele();
        }

        private void VerileriYukle()
        {
            cmbMusteriler.DataSource = _musteriDal.MusteriListele();
            cmbMusteriler.DisplayMember = "MusteriAdSoyad";
            cmbMusteriler.ValueMember = "MusteriID";

            
            cmbOdalar.DataSource = _odaDal.OdaListele();
            cmbOdalar.DisplayMember = "OdaNo";
            cmbOdalar.ValueMember = "OdaID";

           
            cmbHizmetler.DataSource = _hizmetDal.HizmetListele();
            cmbHizmetler.DisplayMember = "HizmetAd";
            cmbHizmetler.ValueMember = "HizmetID";
        }

        private void RezervasyonlariListele()
        {
            dgRezervasyonlar.Rows.Clear();
            dgRezervasyonlar.Columns.Clear();

            
            dgRezervasyonlar.Columns.Add("RezervasyonID", "Rezervasyon No");
            dgRezervasyonlar.Columns.Add("MusteriAdSoyad", "Müşteri Adı Soyadı");
            dgRezervasyonlar.Columns.Add("OdaNo", "Oda Numarası");
            dgRezervasyonlar.Columns.Add("HizmetAd", "Alınan Hizmet");
            dgRezervasyonlar.Columns.Add("BaslangicTarihi", "Giriş Tarihi");
            dgRezervasyonlar.Columns.Add("BitisTarihi", "Çıkış Tarihi");
            dgRezervasyonlar.Columns.Add("KisiSayisi", "Kişi Sayısı");
            dgRezervasyonlar.Columns.Add("SonFiyat", "Toplam Tutar");

            
            List<Rezervasyon> rezervasyonlar = _rezervasyonManager.RezervasyonListele();
            foreach (var rezervasyon in rezervasyonlar)
            {
                string musteriAdSoyad = _musteriDal.MusteriListele()
                    .FirstOrDefault(m => m.MusteriID == rezervasyon.MusteriID)?.MusteriAdSoyad;

                string odaNo = _odaDal.OdaListele()
                    .FirstOrDefault(o => o.OdaID == rezervasyon.OdaID)?.OdaNo;

                string hizmetAd = _hizmetDal.HizmetListele()
                    .FirstOrDefault(h => h.HizmetID == rezervasyon.HizmetID)?.HizmetAd;

                dgRezervasyonlar.Rows.Add(
                    rezervasyon.RezervasyonID,
                    musteriAdSoyad,
                    odaNo,
                    hizmetAd,
                    rezervasyon.BaslangicTarihi.ToShortDateString(),
                    rezervasyon.BitisTarihi.ToShortDateString(),
                    rezervasyon.KisiSayisi,
                    rezervasyon.SonFiyat.ToString("C2")
                );
            }

          
            dgRezervasyonlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgRezervasyonlar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnRezervasyonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var rezervasyon = new Rezervasyon
                {
                    MusteriID = Convert.ToInt32(cmbMusteriler.SelectedValue),
                    OdaID = Convert.ToInt32(cmbOdalar.SelectedValue),
                    HizmetID = Convert.ToInt32(cmbHizmetler.SelectedValue),
                    BaslangicTarihi = dtpGirisTarihi.Value,
                    BitisTarihi = dtpCikisTarihi.Value,
                    KisiSayisi = Convert.ToInt32(nudKisiSayisi.Value)
                };

                _rezervasyonManager.RezervasyonEkle(rezervasyon);
                MessageBox.Show("Rezervasyon başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                RezervasyonlariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRezervasyonGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgRezervasyonlar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen güncellenecek rezervasyonu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int rezervasyonID = Convert.ToInt32(dgRezervasyonlar.SelectedRows[0].Cells["RezervasyonID"].Value);
                var rezervasyon = new Rezervasyon
                {
                    RezervasyonID = rezervasyonID,
                    MusteriID = Convert.ToInt32(cmbMusteriler.SelectedValue),
                    OdaID = Convert.ToInt32(cmbOdalar.SelectedValue),
                    HizmetID = Convert.ToInt32(cmbHizmetler.SelectedValue),
                    BaslangicTarihi = dtpGirisTarihi.Value,
                    BitisTarihi = dtpCikisTarihi.Value,
                    KisiSayisi = Convert.ToInt32(nudKisiSayisi.Value)
                };

                _rezervasyonManager.RezervasyonGuncelle(rezervasyon);
                MessageBox.Show("Rezervasyon başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                RezervasyonlariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRezervasyonSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgRezervasyonlar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silinecek rezervasyonu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int rezervasyonID = Convert.ToInt32(dgRezervasyonlar.SelectedRows[0].Cells["RezervasyonID"].Value);
                var rezervasyon = new Rezervasyon { RezervasyonID = rezervasyonID };

                _rezervasyonManager.RezervasyonSil(rezervasyon);
                MessageBox.Show("Rezervasyon başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                RezervasyonlariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            cmbMusteriler.SelectedIndex = -1;
            cmbOdalar.SelectedIndex = -1;
            cmbHizmetler.SelectedIndex = -1;
            dtpGirisTarihi.Value = DateTime.Today;
            dtpCikisTarihi.Value = DateTime.Today.AddDays(1);
            nudKisiSayisi.Value = 1;
            txtToplamTutar.Clear();
            dgRezervasyonlar.ClearSelection();
        }

        private void dgRezervasyonlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgRezervasyonlar.SelectedRows.Count > 0)
            {
                int rezervasyonID = Convert.ToInt32(dgRezervasyonlar.SelectedRows[0].Cells["RezervasyonID"].Value);

                
                var rezervasyon = _rezervasyonManager.RezervasyonListele().FirstOrDefault(r => r.RezervasyonID == rezervasyonID);
                if (rezervasyon != null)
                {
                    cmbMusteriler.SelectedValue = rezervasyon.MusteriID;
                    cmbOdalar.SelectedValue = rezervasyon.OdaID;
                    cmbHizmetler.SelectedValue = rezervasyon.HizmetID;
                    dtpGirisTarihi.Value = rezervasyon.BaslangicTarihi;
                    dtpCikisTarihi.Value = rezervasyon.BitisTarihi;
                    nudKisiSayisi.Value = rezervasyon.KisiSayisi;
                    txtToplamTutar.Text = rezervasyon.SonFiyat.ToString("C2");
                }
            }
        }

        private void ToplamTutarHesapla()
        {
            try
            {
                int odaID = Convert.ToInt32(cmbOdalar.SelectedValue);
                int hizmetID = Convert.ToInt32(cmbHizmetler.SelectedValue);
                DateTime baslangic = dtpGirisTarihi.Value;
                DateTime bitis = dtpCikisTarihi.Value;
                int kisiSayisi = Convert.ToInt32(nudKisiSayisi.Value);

                
                decimal toplamTutar = _rezervasyonManager.SonTutarHesapla(odaID, hizmetID, baslangic, bitis, kisiSayisi);

                
                txtToplamTutar.Text = toplamTutar.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Toplam tutar hesaplanırken bir hata oluştu: " + ex.Message);
                txtToplamTutar.Clear();
            }
        }


        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            if (dtpCikisTarihi.Value <= dtpGirisTarihi.Value)
            {
                MessageBox.Show("Çıkış tarihi giriş tarihinden sonra olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpCikisTarihi.Value = dtpGirisTarihi.Value.AddDays(1);
            }
            ToplamTutarHesapla();
        }

        private void dtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            if (dtpGirisTarihi.Value < DateTime.Today)
            {
                MessageBox.Show("Geçmiş tarihli rezervasyon yapılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpGirisTarihi.Value = DateTime.Today;
            }
            ToplamTutarHesapla();
        }

        private void btnFaturaGoruntule_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgRezervasyonlar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen bir rezervasyon seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int rezervasyonID = Convert.ToInt32(dgRezervasyonlar.SelectedRows[0].Cells["RezervasyonID"].Value);
                string fatura = _rezervasyonManager.FaturaGoruntule(rezervasyonID);


                MessageBox.Show(fatura, "Fatura Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
