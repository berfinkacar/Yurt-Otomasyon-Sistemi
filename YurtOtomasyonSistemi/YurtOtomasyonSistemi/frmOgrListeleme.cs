using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtomasyonSistemi
{
    public partial class frmOgrListeleme : Form
    {
        public frmOgrListeleme()
        {
            InitializeComponent();
        }

        private void frmOgrListeleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet4.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter1.Fill(this.yurtOtomasyonuDataSet4.Ogrenci);
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet3.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonuDataSet3.Ogrenci);

        }
        int secilen;
        private void dtgOgrListeleme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dtgOgrListeleme.SelectedCells[0].RowIndex;
            frmOgrDuzenleme fr = new frmOgrDuzenleme();
            fr.id = dtgOgrListeleme.Rows[secilen].Cells[0].Value.ToString();
            fr.ad = dtgOgrListeleme.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad = dtgOgrListeleme.Rows[secilen].Cells[2].Value.ToString();
            fr.TC= dtgOgrListeleme.Rows[secilen].Cells[3].Value.ToString();
            fr.telefon = dtgOgrListeleme.Rows[secilen].Cells[4].Value.ToString();
            fr.dogum = dtgOgrListeleme.Rows[secilen].Cells[5].Value.ToString();
            fr.bolum = dtgOgrListeleme.Rows[secilen].Cells[6].Value.ToString();
            fr.mail = dtgOgrListeleme.Rows[secilen].Cells[7].Value.ToString();
            fr.odaNo = dtgOgrListeleme.Rows[secilen].Cells[8].Value.ToString();
            fr.veliAd = dtgOgrListeleme.Rows[secilen].Cells[9].Value.ToString();
            fr.veliTlf= dtgOgrListeleme.Rows[secilen].Cells[10].Value.ToString();
            fr.adres = dtgOgrListeleme.Rows[secilen].Cells[11].Value.ToString();
            fr.Show();
        }
    }
}
