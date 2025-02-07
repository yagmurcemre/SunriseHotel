using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SunriseHotel.BUSINESS;
using SunriseHotel.ENTITIES;

namespace SunriseHotel.UI
{
    public partial class OdalarPanel : UserControl
    {
        private readonly OdaManager _odaManager;
        public OdalarPanel()
        {
            InitializeComponent();
            _odaManager = new OdaManager();
            OdalariListele();
        }

        private void OdalariListele()
        {
            dgOdalar.Rows.Clear();
            List<Oda> odalar = _odaManager.OdaListele();
            foreach (var oda in odalar)
            {
                dgOdalar.Rows.Add(oda.OdaID, oda.OdaNo, oda.OdaTuru, oda.OdaFiyati);
            }
        }

        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var oda = new Oda
                {
                    OdaNo = txtOdaNumara.Text,
                    OdaTuru = txtOdaTuru.Text,
                    OdaDurumu = "Boş", // Varsayılan olarak "Boş" durumu atanabilir.
                    OdaFiyati = decimal.Parse(txtOdaFiyat.Text)
                };
                _odaManager.OdaEkle(oda);
                MessageBox.Show("Oda başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                OdalariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdaGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgOdalar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen güncellenecek odayı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int odaID = Convert.ToInt32(dgOdalar.SelectedRows[0].Cells["OdaID"].Value);
                var oda = new Oda
                {
                    OdaID = odaID,
                    OdaNo = txtOdaNumara.Text,
                    OdaTuru = txtOdaTuru.Text,
                    OdaDurumu = dgOdalar.SelectedRows[0].Cells["OdaDurumu"].Value.ToString(), // Durumu değiştirilmesin.
                    OdaFiyati = decimal.Parse(txtOdaFiyat.Text)
                };
                _odaManager.OdaGuncelle(oda);
                MessageBox.Show("Oda başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                OdalariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdaSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgOdalar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silinecek odayı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                int odaID = Convert.ToInt32(dgOdalar.SelectedRows[0].Cells["OdaID"].Value);
                var oda = new Oda { OdaID = odaID };
                _odaManager.OdaSil(oda);
                MessageBox.Show("Oda başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                OdalariListele();
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
            txtOdaNumara.Clear();
            txtOdaTuru.Clear();
            txtOdaFiyat.Clear();
            dgOdalar.ClearSelection();
        }

        private void dgOdalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgOdalar.SelectedRows.Count > 0)
            {
                txtOdaNumara.Text = dgOdalar.SelectedRows[0].Cells["OdaNo"].Value.ToString();
                txtOdaTuru.Text = dgOdalar.SelectedRows[0].Cells["OdaTuru"].Value.ToString();
                txtOdaFiyat.Text = dgOdalar.SelectedRows[0].Cells["OdaFiyati"].Value.ToString();
            }
        }
    }
}
