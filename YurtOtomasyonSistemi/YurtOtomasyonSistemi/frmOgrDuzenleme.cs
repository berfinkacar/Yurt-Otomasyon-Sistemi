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
    public partial class frmOgrDuzenleme : Form
    {
        public frmOgrDuzenleme()
        {
            InitializeComponent();
        }
        public string id,ad,soyad,TC,telefon,dogum,bolum;

        //Öğrenci Silme
        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from Ogrenci where Ogrid=@k1",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1", txtOgridDuzenle.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi.");
        }

        public string mail, odaNo, veliAd, veliTlf, adres;

        SqlBaglanti bgl = new SqlBaglanti();

        private void frmOgrDuzenleme_Load(object sender, EventArgs e)
        {
            txtOgridDuzenle.Text = id;
            txtOgrAdDüzen.Text = ad;
            txtOgrSoyadDuzen.Text = soyad;
            mskTCDuzen.Text = TC;
            mskTlfNoDuzen.Text = telefon;
            mskDogumDuzen.Text = dogum;
            cmbOgrBolumDuzen.Text = bolum;
            txtMailDuzen.Text = mail;
            cmbOdaNoDuzen.Text = odaNo;
            txtVeliAdSoyadDuzen.Text = veliAd;
            mskVeliTlfDuzen.Text = veliTlf;
            rchAdresDuzen.Text = adres;


        }

        private void btnKaydet_Click(object sender, EventArgs e)

        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2,OgrSoyad=@p3,OgrTC=@p4,OgrTelefon=@p5,OgrDogum=@p6,OgrBolum=@p7,OgrMail=@p8,OgrOdaNo=@p9,OgrVeliAdSoyad=@p10,OgrVeliTelefon=@p11,OgrVeliAdres=@p12 where Ogrid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtOgridDuzenle.Text);
                komut.Parameters.AddWithValue("@p2", txtOgrAdDüzen.Text);
                komut.Parameters.AddWithValue("@p3", txtOgrSoyadDuzen.Text);
                komut.Parameters.AddWithValue("@p4", mskTCDuzen.Text);
                komut.Parameters.AddWithValue("@p5", mskTlfNoDuzen.Text);
                komut.Parameters.AddWithValue("@p6", mskDogumDuzen.Text);
                komut.Parameters.AddWithValue("@p7", cmbOgrBolumDuzen.Text);
                komut.Parameters.AddWithValue("@p8", txtMailDuzen.Text);
                komut.Parameters.AddWithValue("@p9", cmbOdaNoDuzen.Text);
                komut.Parameters.AddWithValue("@p10", txtVeliAdSoyadDuzen.Text);
                komut.Parameters.AddWithValue("@p11", mskVeliTlfDuzen.Text);
                komut.Parameters.AddWithValue("@p12", rchAdresDuzen.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi.");

            }
            catch (Exception)
            {

                MessageBox.Show("Hata,Yeniden Deneyin!");
            }
            // Oda Aktif Öğrenci Sayısını Azaltma         (?)
            SqlCommand komutoda = new SqlCommand("update Oda set OdaAktif=OdaAktif - 1 where OdaNo=@oda", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda",cmbOdaNoDuzen.Text);            
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();


        }
    }
}
