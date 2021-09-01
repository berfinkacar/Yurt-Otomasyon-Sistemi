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
    public partial class frmBolumler : Form
    {
        public frmBolumler()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void frmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet.Bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);

        }

        private void pcAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut1 = new SqlCommand("insert into Bolumler (BolumAd) values (@p1)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", txtBolumAdi.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm Başarıyla Eklenmiştir.");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);

            }

            catch
            {
                MessageBox.Show("Hata Oluştu Yeniden Deneyin!");

            }
        }

        private void pcDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where Bolumid=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtBolumID.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti.");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);

            }
            catch (Exception)
            {
                MessageBox.Show("Hata, İşlem Gerçekleşmedi!");

            }
        }
        int secilen;
        private void dtgBolumler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dtgBolumler.SelectedCells[0].RowIndex;
            id = dtgBolumler.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dtgBolumler.Rows[secilen].Cells[1].Value.ToString();

            txtBolumID.Text = id;
            txtBolumAdi.Text = bolumad;
            
        }

        private void pcEdit_Click(object sender, EventArgs e)
        {
            try
            {

                
                SqlCommand komut2 = new SqlCommand("update Bolumler Set BolumAd=@p1 where Bolumid=@p2",bgl.baglanti());
                komut2.Parameters.AddWithValue("@p2", txtBolumID.Text);
                komut2.Parameters.AddWithValue("@p1", txtBolumAdi.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Gerçekleşti.");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);



            }
            catch (Exception)
            {

                MessageBox.Show("Hata,Güncelleme Gerçekleşmedi!");
            }
        }
    }
}
