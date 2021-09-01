using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace YurtOtomasyonSistemi
{
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void frmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet8.Personeller' table. You can move, or remove it, as needed.
            this.personellerTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Personeller);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personeller(PersonelAdSoyad,PersonelDepartman) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", txtGorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Eklendi.");
            this.personellerTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Personeller);

        }

        private void dtgPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBoxlara aktarma işlemi
            int secilen;
            secilen =dtgPersonel.SelectedCells[0].RowIndex;
            string ad, gorev, id;
            id = dtgPersonel.Rows[secilen].Cells[0].Value.ToString();
            ad = dtgPersonel.Rows[secilen].Cells[1].Value.ToString();
            gorev = dtgPersonel.Rows[secilen].Cells[2].Value.ToString();

            txtPersonelAd.Text = ad;
            txtGorev.Text = gorev;
            txtPersonelid.Text = id;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Personeller where Personelid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtPersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Silindi!");
            this.personellerTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Personeller);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Personeller set PersonelAdSoyad=@p1, PersonelDepartman=@p2 where Personelid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", txtGorev.Text);
            komut.Parameters.AddWithValue("@p3", txtPersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme İşlemi Gerçekleşti.");
            this.personellerTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Personeller);

        }
    }
}
