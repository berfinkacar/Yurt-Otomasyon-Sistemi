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
    public partial class frmGiderGuncelleme : Form
    {
        public frmGiderGuncelleme()
        {
            InitializeComponent();
        }
        public string id,elektrik, su, dogalGaz, gida, diger, internet, personel;

        SqlBaglanti bgl = new SqlBaglanti();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Giderler set Elektrik=@p1,Su=@p2,Dogalgaz=@p3,internet=@p4,Gıda=@p5,Personel=@p6,Diger=@p7 where Odemeid=@p8", bgl.baglanti());
                komut.Parameters.AddWithValue("@p8", txtGideridGuncel.Text);
                komut.Parameters.AddWithValue("@p1", txtElektrikGuncel.Text);
                komut.Parameters.AddWithValue("@p2", txtSuGuncel.Text);
                komut.Parameters.AddWithValue("@p3", txtDogalGazGuncel.Text);
                komut.Parameters.AddWithValue("@p4", txtInternetGuncel.Text);
                komut.Parameters.AddWithValue("@p5", txtGidaGuncel.Text);
                komut.Parameters.AddWithValue("@p6", txtPersonelGuncel.Text);
                komut.Parameters.AddWithValue("@p7", txtDigerGuncel.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Yapıldı.");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata,Güncelleme Başarısız!");
            }

        }

        private void frmGiderGuncelleme_Load(object sender, EventArgs e)
        {
            txtGideridGuncel.Text = id;
            txtElektrikGuncel.Text = elektrik;
            txtSuGuncel.Text = su;
            txtDogalGazGuncel.Text = dogalGaz;
            txtGidaGuncel.Text = gida;
            txtDigerGuncel.Text = diger;
            txtInternetGuncel.Text = internet;
            txtPersonelGuncel.Text = personel;
            txtDogalGazGuncel.Text = dogalGaz;
            txtDigerGuncel.Text = diger;
        }
    }
}
