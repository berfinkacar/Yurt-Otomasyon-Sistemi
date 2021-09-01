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
    public partial class frmOgrKayit : Form
    {
        public frmOgrKayit()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void Form1_Load(object sender, EventArgs e)

        {
            //Bölümleri Listeleme Komutları
            
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbOgrBolum.Items.Add(oku[0].ToString());
            }

            bgl.baglanti().Close();

            //Boş Odaları Listeleme Komutları

            
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Oda where OdaKapasite != OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

            ;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Öğrenci Bilgilerinin Kaydedilme Komutları
            try
            {

                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci(OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", txtOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", txtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", mskTC.Text);
                komutkaydet.Parameters.AddWithValue("@p4", mskTlfNo.Text);
                komutkaydet.Parameters.AddWithValue("@p5", mskDogum.Text);
                komutkaydet.Parameters.AddWithValue("@p6", cmbOgrBolum.Text);
                komutkaydet.Parameters.AddWithValue("@p7", txtMail.Text);
                komutkaydet.Parameters.AddWithValue("@p8", cmbOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@p9", txtVeliAdSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p10", mskVeliTlf.Text);
                komutkaydet.Parameters.AddWithValue("@p11", rchAdres.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Başarılı Bir Şekilde Kaydedildi.");

                //Öğrenci id labele çekme
                SqlCommand komut = new SqlCommand("select Ogrid from Ogrenci", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label2.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();



                //Öğrenci Borç Alanı Oluşturma
                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar (Ogrid,OgrAd,OgrSoyad) values (@b1,@b2,@b3)", bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label2.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", txtOgrAd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", txtOgrSoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt Başarısız!");

            }



            // Öğrenci Oda Kontenjanı Arttırma

            SqlCommand komutoda = new SqlCommand("update Oda set OdaAktif=OdaAktif+1 where OdaNo=@oda1",bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", cmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();

        }
    }
}//Data Source=DESKTOP-T4US8R7\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;Integrated Security=True
