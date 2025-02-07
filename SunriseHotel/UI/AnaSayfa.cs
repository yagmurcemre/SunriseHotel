using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunriseHotel.UI
{
    public partial class AnaSayfa : Form
    {

        public AnaSayfa()
        {
            InitializeComponent();
            Load += AnaSayfa_Load;
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnMusteri_Click_1(object sender, EventArgs e)
        {
            pnlUserControl.Controls.Clear();
            var musteriPanel = new MusterilerPanel();
            musteriPanel.Dock = DockStyle.Fill;
            pnlUserControl.Controls.Add(musteriPanel);
        }

        private void btnOda_Click_1(object sender, EventArgs e)
        {
            pnlUserControl.Controls.Clear();
            var odaPanel = new OdalarPanel();
            odaPanel.Dock = DockStyle.Fill;
            pnlUserControl.Controls.Add(odaPanel);
        }

        private void btnHizmet_Click_1(object sender, EventArgs e)
        {
            pnlUserControl.Controls.Clear();
            var hizmetPanel = new HizmetlerPanel();
            hizmetPanel.Dock = DockStyle.Fill;
            pnlUserControl.Controls.Add(hizmetPanel);
        }

        private void btnRezervasyon_Click_1(object sender, EventArgs e)
        {
            pnlUserControl.Controls.Clear();
            var rezervasyonPanel = new RezervasyonlarPanel();
            rezervasyonPanel.Dock = DockStyle.Fill;
            pnlUserControl.Controls.Add(rezervasyonPanel);
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

