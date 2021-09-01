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
    public partial class frmYoneticiIslemleri : Form
    {
        public frmYoneticiIslemleri()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet6.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Admin);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Admin(YoneticiAd,YoneticiSifre) values (@p1,@p2)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yönetici Eklendi.");
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Admin);

        }

        private void dtgYoneticiIslemleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBoxlara aktarma işlemi
            int secilen;
            secilen = dtgYoneticiIslemleri.SelectedCells[0].RowIndex;
            string ad, sifre, id;
            id = dtgYoneticiIslemleri.Rows[secilen].Cells[0].Value.ToString();
            ad = dtgYoneticiIslemleri.Rows[secilen].Cells[1].Value.ToString();
            sifre = dtgYoneticiIslemleri.Rows[secilen].Cells[2].Value.ToString();

            txtKullaniciAd.Text = ad;
            txtSifre.Text = sifre;
            txtYoneticiId.Text = id;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Admin where Yoneticiid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtYoneticiId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme İşlemi Gerçekleşti!");
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Admin);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Admin set YoneticiAd=@p1, YoneticiSifre=@p2 where Yoneticiid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.Parameters.AddWithValue("@p3", txtYoneticiId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Güncelleme İşlemi Gerçekleşti.");
            this.adminTableAdapter.Fill(this.yurtOtomasyonuDataSet6.Admin);

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSifre_Click(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKullaniciAd_Click(object sender, EventArgs e)
        {

        }

        private void txtYoneticiId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblYoneticiid_Click(object sender, EventArgs e)
        {

        }
    }
}
