using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SunriseHotel.BUSINESS;
using SunriseHotel.ENTITIES;

namespace SunriseHotel.UI
{
    public partial class HizmetlerPanel : UserControl
    {
        private readonly HizmetManager _hizmetManager;
        public HizmetlerPanel()
        {
            InitializeComponent();
            _hizmetManager = new HizmetManager();
            HizmetleriListele();
        }

        private void HizmetleriListele()
        {
            dgHizmetler.Rows.Clear();
            List<Hizmet> hizmetler = _hizmetManager.HizmetListele();
            foreach (var hizmet in hizmetler)
            {
                dgHizmetler.Rows.Add(hizmet.HizmetID, hizmet.HizmetAd, hizmet.HizmetFiyat);
            }
        }

        private void btnHizmetEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var hizmet = new Hizmet
                {
                    HizmetAd = txtHizmetAd.Text,
                    HizmetFiyat = decimal.Parse(txtHizmetFiyat.Text)
                };
                _hizmetManager.HizmetEkle(hizmet);
                MessageBox.Show("Hizmet başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                HizmetleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHizmetGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgHizmetler.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen güncellenecek hizmeti seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int hizmetID = Convert.ToInt32(dgHizmetler.SelectedRows[0].Cells["HizmetID"].Value);
                var hizmet = new Hizmet
                {
                    HizmetID = hizmetID,
                    HizmetAd = txtHizmetAd.Text,
                    HizmetFiyat = decimal.Parse(txtHizmetFiyat.Text)
                };
                _hizmetManager.HizmetGuncelle(hizmet);
                MessageBox.Show("Hizmet başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                HizmetleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHizmetSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgHizmetler.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silinecek hizmeti seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int hizmetID = Convert.ToInt32(dgHizmetler.SelectedRows[0].Cells["HizmetID"].Value);
                var hizmet = new Hizmet { HizmetID = hizmetID };
                _hizmetManager.HizmetSil(hizmet);
                MessageBox.Show("Hizmet başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                HizmetleriListele();
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
            txtHizmetAd.Clear();
            txtHizmetFiyat.Clear();
            dgHizmetler.ClearSelection();
        }

        private void dgHizmetler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgHizmetler.SelectedRows.Count > 0)
            {
                txtHizmetAd.Text = dgHizmetler.SelectedRows[0].Cells["HizmetAd"].Value.ToString();
                txtHizmetFiyat.Text = dgHizmetler.SelectedRows[0].Cells["HizmetFiyat"].Value.ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
