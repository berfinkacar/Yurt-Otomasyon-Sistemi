
namespace YurtOtomasyonSistemi
{
    partial class frmOgrKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrKayit));
            this.lblOgrAd = new System.Windows.Forms.Label();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.lblOgrSoyad = new System.Windows.Forms.Label();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.lblOgrTC = new System.Windows.Forms.Label();
            this.lblTlfNo = new System.Windows.Forms.Label();
            this.mskTlfNo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskDogum = new System.Windows.Forms.MaskedTextBox();
            this.lblOgrBolum = new System.Windows.Forms.Label();
            this.cmbOgrBolum = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.cmbOdaNo = new System.Windows.Forms.ComboBox();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.txtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.lblVeliAdSoyad = new System.Windows.Forms.Label();
            this.lblVeliTlf = new System.Windows.Forms.Label();
            this.mskVeliTlf = new System.Windows.Forms.MaskedTextBox();
            this.lblVeliAdres = new System.Windows.Forms.Label();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOgrAd
            // 
            this.lblOgrAd.AutoSize = true;
            this.lblOgrAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrAd.Location = new System.Drawing.Point(83, 44);
            this.lblOgrAd.Name = "lblOgrAd";
            this.lblOgrAd.Size = new System.Drawing.Size(115, 24);
            this.lblOgrAd.TabIndex = 0;
            this.lblOgrAd.Text = "Öğrenci Ad:";
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.BackColor = System.Drawing.Color.White;
            this.txtOgrAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrAd.Location = new System.Drawing.Point(211, 41);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(240, 30);
            this.txtOgrAd.TabIndex = 1;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrSoyad.Location = new System.Drawing.Point(208, 77);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(240, 30);
            this.txtOgrSoyad.TabIndex = 3;
            // 
            // lblOgrSoyad
            // 
            this.lblOgrSoyad.AutoSize = true;
            this.lblOgrSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrSoyad.Location = new System.Drawing.Point(60, 83);
            this.lblOgrSoyad.Name = "lblOgrSoyad";
            this.lblOgrSoyad.Size = new System.Drawing.Size(144, 24);
            this.lblOgrSoyad.TabIndex = 2;
            this.lblOgrSoyad.Text = "Öğrenci Soyad:";
            // 
            // mskTC
            // 
            this.mskTC.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTC.Location = new System.Drawing.Point(208, 113);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(240, 30);
            this.mskTC.TabIndex = 4;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // lblOgrTC
            // 
            this.lblOgrTC.AutoSize = true;
            this.lblOgrTC.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrTC.Location = new System.Drawing.Point(83, 119);
            this.lblOgrTC.Name = "lblOgrTC";
            this.lblOgrTC.Size = new System.Drawing.Size(116, 24);
            this.lblOgrTC.TabIndex = 5;
            this.lblOgrTC.Text = "Öğrenci TC:";
            // 
            // lblTlfNo
            // 
            this.lblTlfNo.AutoSize = true;
            this.lblTlfNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTlfNo.Location = new System.Drawing.Point(109, 160);
            this.lblTlfNo.Name = "lblTlfNo";
            this.lblTlfNo.Size = new System.Drawing.Size(89, 24);
            this.lblTlfNo.TabIndex = 7;
            this.lblTlfNo.Text = "Telefon :";
            // 
            // mskTlfNo
            // 
            this.mskTlfNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTlfNo.Location = new System.Drawing.Point(208, 154);
            this.mskTlfNo.Mask = "(999) 000-0000";
            this.mskTlfNo.Name = "mskTlfNo";
            this.mskTlfNo.Size = new System.Drawing.Size(240, 30);
            this.mskTlfNo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Doğum Tarihi:";
            // 
            // mskDogum
            // 
            this.mskDogum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskDogum.Location = new System.Drawing.Point(208, 190);
            this.mskDogum.Mask = "00/00/0000";
            this.mskDogum.Name = "mskDogum";
            this.mskDogum.Size = new System.Drawing.Size(240, 30);
            this.mskDogum.TabIndex = 8;
            this.mskDogum.ValidatingType = typeof(System.DateTime);
            // 
            // lblOgrBolum
            // 
            this.lblOgrBolum.AutoSize = true;
            this.lblOgrBolum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrBolum.Location = new System.Drawing.Point(41, 234);
            this.lblOgrBolum.Name = "lblOgrBolum";
            this.lblOgrBolum.Size = new System.Drawing.Size(163, 24);
            this.lblOgrBolum.TabIndex = 10;
            this.lblOgrBolum.Text = "Öğrenci Bölümü:";
            // 
            // cmbOgrBolum
            // 
            this.cmbOgrBolum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOgrBolum.FormattingEnabled = true;
            this.cmbOgrBolum.Location = new System.Drawing.Point(208, 226);
            this.cmbOgrBolum.Name = "cmbOgrBolum";
            this.cmbOgrBolum.Size = new System.Drawing.Size(240, 32);
            this.cmbOgrBolum.TabIndex = 11;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(208, 264);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(240, 30);
            this.txtMail.TabIndex = 13;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.Location = new System.Drawing.Point(142, 270);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(57, 24);
            this.lblMail.TabIndex = 12;
            this.lblMail.Text = "Mail:";
            // 
            // cmbOdaNo
            // 
            this.cmbOdaNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdaNo.FormattingEnabled = true;
            this.cmbOdaNo.Location = new System.Drawing.Point(208, 300);
            this.cmbOdaNo.Name = "cmbOdaNo";
            this.cmbOdaNo.Size = new System.Drawing.Size(240, 32);
            this.cmbOdaNo.TabIndex = 15;
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaNo.Location = new System.Drawing.Point(115, 308);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(83, 24);
            this.lblOdaNo.TabIndex = 14;
            this.lblOdaNo.Text = "Oda No:";
            // 
            // txtVeliAdSoyad
            // 
            this.txtVeliAdSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVeliAdSoyad.Location = new System.Drawing.Point(208, 338);
            this.txtVeliAdSoyad.Name = "txtVeliAdSoyad";
            this.txtVeliAdSoyad.Size = new System.Drawing.Size(240, 30);
            this.txtVeliAdSoyad.TabIndex = 17;
            // 
            // lblVeliAdSoyad
            // 
            this.lblVeliAdSoyad.AutoSize = true;
            this.lblVeliAdSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeliAdSoyad.Location = new System.Drawing.Point(64, 344);
            this.lblVeliAdSoyad.Name = "lblVeliAdSoyad";
            this.lblVeliAdSoyad.Size = new System.Drawing.Size(138, 24);
            this.lblVeliAdSoyad.TabIndex = 16;
            this.lblVeliAdSoyad.Text = "Veli Ad Soyad:";
            // 
            // lblVeliTlf
            // 
            this.lblVeliTlf.AutoSize = true;
            this.lblVeliTlf.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeliTlf.Location = new System.Drawing.Point(69, 380);
            this.lblVeliTlf.Name = "lblVeliTlf";
            this.lblVeliTlf.Size = new System.Drawing.Size(129, 24);
            this.lblVeliTlf.TabIndex = 19;
            this.lblVeliTlf.Text = "Veli Telefon :";
            // 
            // mskVeliTlf
            // 
            this.mskVeliTlf.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskVeliTlf.Location = new System.Drawing.Point(208, 374);
            this.mskVeliTlf.Mask = "(999) 000-0000";
            this.mskVeliTlf.Name = "mskVeliTlf";
            this.mskVeliTlf.Size = new System.Drawing.Size(240, 30);
            this.mskVeliTlf.TabIndex = 18;
            // 
            // lblVeliAdres
            // 
            this.lblVeliAdres.AutoSize = true;
            this.lblVeliAdres.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeliAdres.Location = new System.Drawing.Point(132, 431);
            this.lblVeliAdres.Name = "lblVeliAdres";
            this.lblVeliAdres.Size = new System.Drawing.Size(67, 24);
            this.lblVeliAdres.TabIndex = 20;
            this.lblVeliAdres.Text = "Adres:";
            // 
            // rchAdres
            // 
            this.rchAdres.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchAdres.Location = new System.Drawing.Point(208, 416);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(240, 117);
            this.rchAdres.TabIndex = 21;
            this.rchAdres.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkGray;
            this.btnKaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(261, 539);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(142, 61);
            this.btnKaydet.TabIndex = 22;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 571);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // frmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(604, 637);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.rchAdres);
            this.Controls.Add(this.lblVeliAdres);
            this.Controls.Add(this.lblVeliTlf);
            this.Controls.Add(this.mskVeliTlf);
            this.Controls.Add(this.txtVeliAdSoyad);
            this.Controls.Add(this.lblVeliAdSoyad);
            this.Controls.Add(this.cmbOdaNo);
            this.Controls.Add(this.lblOdaNo);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.cmbOgrBolum);
            this.Controls.Add(this.lblOgrBolum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskDogum);
            this.Controls.Add(this.lblTlfNo);
            this.Controls.Add(this.mskTlfNo);
            this.Controls.Add(this.lblOgrTC);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.txtOgrSoyad);
            this.Controls.Add(this.lblOgrSoyad);
            this.Controls.Add(this.txtOgrAd);
            this.Controls.Add(this.lblOgrAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOgrKayit";
            this.Text = "Öğrenci Kayıt Formu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgrAd;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.Label lblOgrSoyad;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label lblOgrTC;
        private System.Windows.Forms.Label lblTlfNo;
        private System.Windows.Forms.MaskedTextBox mskTlfNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskDogum;
        private System.Windows.Forms.Label lblOgrBolum;
        private System.Windows.Forms.ComboBox cmbOgrBolum;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.ComboBox cmbOdaNo;
        private System.Windows.Forms.Label lblOdaNo;
        private System.Windows.Forms.TextBox txtVeliAdSoyad;
        private System.Windows.Forms.Label lblVeliAdSoyad;
        private System.Windows.Forms.Label lblVeliTlf;
        private System.Windows.Forms.MaskedTextBox mskVeliTlf;
        private System.Windows.Forms.Label lblVeliAdres;
        private System.Windows.Forms.RichTextBox rchAdres;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label2;
    }
}

