using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SunriseHotel.BUSINESS;
using SunriseHotel.ENTITIES;

namespace SunriseHotel.UI
{
    public partial class MusterilerPanel : UserControl
    {
        private readonly MusteriManager _musteriManager;
        public MusterilerPanel()
        {
            InitializeComponent();
            _musteriManager = new MusteriManager();
            MusterileriListele();
        }

        private void MusterileriListele()
        {
            dgMusteriler.Rows.Clear();
            List<Musteri> musteriler = _musteriManager.MusteriListele();
            foreach (var musteri in musteriler)
            {
                dgMusteriler.Rows.Add(musteri.MusteriID, musteri.MusteriAd, musteri.MusteriSoyad, musteri.TcKimlik, musteri.MusteriTelNo);
            }
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var musteri = new Musteri
                {
                    MusteriAd = txtMusteriAd.Text,
                    MusteriSoyad = txtMusteriSoyad.Text,
                    TcKimlik = txtTcKimlik.Text,
                    MusteriTelNo = txtMusteriTel.Text
                };
                _musteriManager.MusteriEkle(musteri);
                MessageBox.Show("Müşteri başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                MusterileriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgMusteriler.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen güncellenecek müşteriyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int musteriID = Convert.ToInt32(dgMusteriler.SelectedRows[0].Cells["MusteriID"].Value);
                var musteri = new Musteri
                {
                    MusteriID = musteriID,
                    MusteriAd = txtMusteriAd.Text,
                    MusteriSoyad = txtMusteriSoyad.Text,
                    TcKimlik = txtTcKimlik.Text,
                    MusteriTelNo = txtMusteriTel.Text
                };

                _musteriManager.MusteriGuncelle(musteri);
                MessageBox.Show("Müşteri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Temizle();
                MusterileriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgMusteriler.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silinecek müşteriyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int musteriID = Convert.ToInt32(dgMusteriler.SelectedRows[0].Cells["MusteriID"].Value);
                var musteri = new Musteri { MusteriID = musteriID };

                _musteriManager.MusteriSil(musteri);
                MessageBox.Show("Müşteri başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Temizle();
                MusterileriListele();
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
            txtMusteriAd.Clear();
            txtMusteriSoyad.Clear();
            txtTcKimlik.Clear();
            txtMusteriTel.Clear();
            dgMusteriler.ClearSelection();
        }

        private void dgMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgMusteriler.SelectedRows.Count > 0)
            {
                txtMusteriAd.Text = dgMusteriler.SelectedRows[0].Cells["MusteriAd"].Value.ToString();
                txtMusteriSoyad.Text = dgMusteriler.SelectedRows[0].Cells["MusteriSoyad"].Value.ToString();
                txtTcKimlik.Text = dgMusteriler.SelectedRows[0].Cells["TcKimlik"].Value.ToString();
                txtMusteriTel.Text = dgMusteriler.SelectedRows[0].Cells["MusteriTelNo"].Value.ToString();
            }
        }
    }
}
