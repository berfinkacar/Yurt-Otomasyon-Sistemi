﻿using System;
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
    public partial class frmOdemeler : Form
    {
        public frmOdemeler()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void frmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonuDataSet2.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet2.Borclar);

        }

        private void dtgOdeme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id,ad,soyad, kalan;
            secilen = dtgOdeme.SelectedCells[0].RowIndex;
            id = dtgOdeme.Rows[secilen].Cells[0].Value.ToString();
            ad = dtgOdeme.Rows[secilen].Cells[1].Value.ToString();
            soyad = dtgOdeme.Rows[secilen].Cells[2].Value.ToString();
            kalan = dtgOdeme.Rows[secilen].Cells[3].Value.ToString();

            txtOgrOdemeAd.Text = ad;
            txtOgrOdemeSoyad.Text = soyad;
            txtKalanBorc.Text = kalan;
            txtOgridOdeme.Text= id;

        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            //Ödenen tutarı kalan tutardan düşme
            int odenen, kalan,yeniborc;
            odenen = Convert.ToUInt16(txtOgrOdenen.Text);
            kalan = Convert.ToUInt16(txtKalanBorc.Text);
            yeniborc = kalan - odenen;
            txtKalanBorc.Text = yeniborc.ToString();

            //Yeni Tutarı Veritabanına kaydetme
            SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@p1 where Ogrid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", txtOgridOdeme.Text);
            komut.Parameters.AddWithValue("@p1", txtKalanBorc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödendi!");
            this.borclarTableAdapter.Fill(this.yurtOtomasyonuDataSet2.Borclar);

            // Kasa Tablosuna Ekleme Yapma
            SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeAy,OdemeMiktar) values (@k1,@k2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", txtOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2", txtOgrOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
        
        }
    }
}
