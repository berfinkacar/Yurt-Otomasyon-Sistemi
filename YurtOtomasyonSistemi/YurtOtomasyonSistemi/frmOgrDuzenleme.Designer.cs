
namespace YurtOtomasyonSistemi
{
    partial class frmOgrDuzenleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrDuzenleme));
            this.lblOgridDuzenId = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.rchAdresDuzen = new System.Windows.Forms.RichTextBox();
            this.lblVeliAdresDuzen = new System.Windows.Forms.Label();
            this.lblVeliTlfDuzen = new System.Windows.Forms.Label();
            this.mskVeliTlfDuzen = new System.Windows.Forms.MaskedTextBox();
            this.txtVeliAdSoyadDuzen = new System.Windows.Forms.TextBox();
            this.lblVeliAdSoyadDuzen = new System.Windows.Forms.Label();
            this.cmbOdaNoDuzen = new System.Windows.Forms.ComboBox();
            this.lblOdaNoDuzen = new System.Windows.Forms.Label();
            this.txtMailDuzen = new System.Windows.Forms.TextBox();
            this.lblMailDuzen = new System.Windows.Forms.Label();
            this.cmbOgrBolumDuzen = new System.Windows.Forms.ComboBox();
            this.lblOgrBolumDuzen = new System.Windows.Forms.Label();
            this.lblDogumDuzen = new System.Windows.Forms.Label();
            this.mskDogumDuzen = new System.Windows.Forms.MaskedTextBox();
            this.lblTlfNoDuzen = new System.Windows.Forms.Label();
            this.mskTlfNoDuzen = new System.Windows.Forms.MaskedTextBox();
            this.lblOgrTCDuzen = new System.Windows.Forms.Label();
            this.mskTCDuzen = new System.Windows.Forms.MaskedTextBox();
            this.txtOgrSoyadDuzen = new System.Windows.Forms.TextBox();
            this.lblOgrSoyadDuzen = new System.Windows.Forms.Label();
            this.txtOgrAdDüzen = new System.Windows.Forms.TextBox();
            this.lblOgrAdDuzen = new System.Windows.Forms.Label();
            this.txtOgridDuzenle = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOgridDuzenId
            // 
            this.lblOgridDuzenId.AutoSize = true;
            this.lblOgridDuzenId.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgridDuzenId.Location = new System.Drawing.Point(69, 39);
            this.lblOgridDuzenId.Name = "lblOgridDuzenId";
            this.lblOgridDuzenId.Size = new System.Drawing.Size(114, 24);
            this.lblOgridDuzenId.TabIndex = 0;
            this.lblOgridDuzenId.Text = "Öğrenci ID:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.DarkGray;
            this.btnGuncelle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(171, 582);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(142, 54);
            this.btnGuncelle.TabIndex = 45;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // rchAdresDuzen
            // 
            this.rchAdresDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchAdresDuzen.Location = new System.Drawing.Point(194, 456);
            this.rchAdresDuzen.Name = "rchAdresDuzen";
            this.rchAdresDuzen.Size = new System.Drawing.Size(240, 117);
            this.rchAdresDuzen.TabIndex = 44;
            this.rchAdresDuzen.Text = "";
            // 
            // lblVeliAdresDuzen
            // 
            this.lblVeliAdresDuzen.AutoSize = true;
            this.lblVeliAdresDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeliAdresDuzen.Location = new System.Drawing.Point(118, 471);
            this.lblVeliAdresDuzen.Name = "lblVeliAdresDuzen";
            this.lblVeliAdresDuzen.Size = new System.Drawing.Size(67, 24);
            this.lblVeliAdresDuzen.TabIndex = 43;
            this.lblVeliAdresDuzen.Text = "Adres:";
            // 
            // lblVeliTlfDuzen
            // 
            this.lblVeliTlfDuzen.AutoSize = true;
            this.lblVeliTlfDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeliTlfDuzen.Location = new System.Drawing.Point(55, 420);
            this.lblVeliTlfDuzen.Name = "lblVeliTlfDuzen";
            this.lblVeliTlfDuzen.Size = new System.Drawing.Size(129, 24);
            this.lblVeliTlfDuzen.TabIndex = 42;
            this.lblVeliTlfDuzen.Text = "Veli Telefon :";
            // 
            // mskVeliTlfDuzen
            // 
            this.mskVeliTlfDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskVeliTlfDuzen.Location = new System.Drawing.Point(194, 414);
            this.mskVeliTlfDuzen.Mask = "(999) 000-0000";
            this.mskVeliTlfDuzen.Name = "mskVeliTlfDuzen";
            this.mskVeliTlfDuzen.Size = new System.Drawing.Size(240, 30);
            this.mskVeliTlfDuzen.TabIndex = 41;
            // 
            // txtVeliAdSoyadDuzen
            // 
            this.txtVeliAdSoyadDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVeliAdSoyadDuzen.Location = new System.Drawing.Point(194, 378);
            this.txtVeliAdSoyadDuzen.Name = "txtVeliAdSoyadDuzen";
            this.txtVeliAdSoyadDuzen.Size = new System.Drawing.Size(240, 30);
            this.txtVeliAdSoyadDuzen.TabIndex = 40;
            // 
            // lblVeliAdSoyadDuzen
            // 
            this.lblVeliAdSoyadDuzen.AutoSize = true;
            this.lblVeliAdSoyadDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeliAdSoyadDuzen.Location = new System.Drawing.Point(50, 384);
            this.lblVeliAdSoyadDuzen.Name = "lblVeliAdSoyadDuzen";
            this.lblVeliAdSoyadDuzen.Size = new System.Drawing.Size(138, 24);
            this.lblVeliAdSoyadDuzen.TabIndex = 39;
            this.lblVeliAdSoyadDuzen.Text = "Veli Ad Soyad:";
            // 
            // cmbOdaNoDuzen
            // 
            this.cmbOdaNoDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdaNoDuzen.FormattingEnabled = true;
            this.cmbOdaNoDuzen.Location = new System.Drawing.Point(194, 340);
            this.cmbOdaNoDuzen.Name = "cmbOdaNoDuzen";
            this.cmbOdaNoDuzen.Size = new System.Drawing.Size(240, 32);
            this.cmbOdaNoDuzen.TabIndex = 38;
            // 
            // lblOdaNoDuzen
            // 
            this.lblOdaNoDuzen.AutoSize = true;
            this.lblOdaNoDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaNoDuzen.Location = new System.Drawing.Point(101, 348);
            this.lblOdaNoDuzen.Name = "lblOdaNoDuzen";
            this.lblOdaNoDuzen.Size = new System.Drawing.Size(83, 24);
            this.lblOdaNoDuzen.TabIndex = 37;
            this.lblOdaNoDuzen.Text = "Oda No:";
            // 
            // txtMailDuzen
            // 
            this.txtMailDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMailDuzen.Location = new System.Drawing.Point(194, 304);
            this.txtMailDuzen.Name = "txtMailDuzen";
            this.txtMailDuzen.Size = new System.Drawing.Size(240, 30);
            this.txtMailDuzen.TabIndex = 36;
            // 
            // lblMailDuzen
            // 
            this.lblMailDuzen.AutoSize = true;
            this.lblMailDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMailDuzen.Location = new System.Drawing.Point(128, 310);
            this.lblMailDuzen.Name = "lblMailDuzen";
            this.lblMailDuzen.Size = new System.Drawing.Size(57, 24);
            this.lblMailDuzen.TabIndex = 35;
            this.lblMailDuzen.Text = "Mail:";
            // 
            // cmbOgrBolumDuzen
            // 
            this.cmbOgrBolumDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOgrBolumDuzen.FormattingEnabled = true;
            this.cmbOgrBolumDuzen.Location = new System.Drawing.Point(194, 266);
            this.cmbOgrBolumDuzen.Name = "cmbOgrBolumDuzen";
            this.cmbOgrBolumDuzen.Size = new System.Drawing.Size(240, 32);
            this.cmbOgrBolumDuzen.TabIndex = 34;
            // 
            // lblOgrBolumDuzen
            // 
            this.lblOgrBolumDuzen.AutoSize = true;
            this.lblOgrBolumDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrBolumDuzen.Location = new System.Drawing.Point(27, 274);
            this.lblOgrBolumDuzen.Name = "lblOgrBolumDuzen";
            this.lblOgrBolumDuzen.Size = new System.Drawing.Size(163, 24);
            this.lblOgrBolumDuzen.TabIndex = 33;
            this.lblOgrBolumDuzen.Text = "Öğrenci Bölümü:";
            // 
            // lblDogumDuzen
            // 
            this.lblDogumDuzen.AutoSize = true;
            this.lblDogumDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumDuzen.Location = new System.Drawing.Point(44, 236);
            this.lblDogumDuzen.Name = "lblDogumDuzen";
            this.lblDogumDuzen.Size = new System.Drawing.Size(141, 24);
            this.lblDogumDuzen.TabIndex = 32;
            this.lblDogumDuzen.Text = "Doğum Tarihi:";
            // 
            // mskDogumDuzen
            // 
            this.mskDogumDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskDogumDuzen.Location = new System.Drawing.Point(194, 230);
            this.mskDogumDuzen.Mask = "00/00/0000";
            this.mskDogumDuzen.Name = "mskDogumDuzen";
            this.mskDogumDuzen.Size = new System.Drawing.Size(240, 30);
            this.mskDogumDuzen.TabIndex = 31;
            this.mskDogumDuzen.ValidatingType = typeof(System.DateTime);
            // 
            // lblTlfNoDuzen
            // 
            this.lblTlfNoDuzen.AutoSize = true;
            this.lblTlfNoDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTlfNoDuzen.Location = new System.Drawing.Point(95, 200);
            this.lblTlfNoDuzen.Name = "lblTlfNoDuzen";
            this.lblTlfNoDuzen.Size = new System.Drawing.Size(89, 24);
            this.lblTlfNoDuzen.TabIndex = 30;
            this.lblTlfNoDuzen.Text = "Telefon :";
            // 
            // mskTlfNoDuzen
            // 
            this.mskTlfNoDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTlfNoDuzen.Location = new System.Drawing.Point(194, 194);
            this.mskTlfNoDuzen.Mask = "(999) 000-0000";
            this.mskTlfNoDuzen.Name = "mskTlfNoDuzen";
            this.mskTlfNoDuzen.Size = new System.Drawing.Size(240, 30);
            this.mskTlfNoDuzen.TabIndex = 29;
            // 
            // lblOgrTCDuzen
            // 
            this.lblOgrTCDuzen.AutoSize = true;
            this.lblOgrTCDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrTCDuzen.Location = new System.Drawing.Point(69, 159);
            this.lblOgrTCDuzen.Name = "lblOgrTCDuzen";
            this.lblOgrTCDuzen.Size = new System.Drawing.Size(116, 24);
            this.lblOgrTCDuzen.TabIndex = 28;
            this.lblOgrTCDuzen.Text = "Öğrenci TC:";
            // 
            // mskTCDuzen
            // 
            this.mskTCDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTCDuzen.Location = new System.Drawing.Point(194, 153);
            this.mskTCDuzen.Mask = "00000000000";
            this.mskTCDuzen.Name = "mskTCDuzen";
            this.mskTCDuzen.Size = new System.Drawing.Size(240, 30);
            this.mskTCDuzen.TabIndex = 27;
            this.mskTCDuzen.ValidatingType = typeof(int);
            // 
            // txtOgrSoyadDuzen
            // 
            this.txtOgrSoyadDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrSoyadDuzen.Location = new System.Drawing.Point(194, 117);
            this.txtOgrSoyadDuzen.Name = "txtOgrSoyadDuzen";
            this.txtOgrSoyadDuzen.Size = new System.Drawing.Size(240, 30);
            this.txtOgrSoyadDuzen.TabIndex = 26;
            // 
            // lblOgrSoyadDuzen
            // 
            this.lblOgrSoyadDuzen.AutoSize = true;
            this.lblOgrSoyadDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrSoyadDuzen.Location = new System.Drawing.Point(46, 123);
            this.lblOgrSoyadDuzen.Name = "lblOgrSoyadDuzen";
            this.lblOgrSoyadDuzen.Size = new System.Drawing.Size(144, 24);
            this.lblOgrSoyadDuzen.TabIndex = 25;
            this.lblOgrSoyadDuzen.Text = "Öğrenci Soyad:";
            // 
            // txtOgrAdDüzen
            // 
            this.txtOgrAdDüzen.BackColor = System.Drawing.Color.White;
            this.txtOgrAdDüzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrAdDüzen.Location = new System.Drawing.Point(194, 78);
            this.txtOgrAdDüzen.Name = "txtOgrAdDüzen";
            this.txtOgrAdDüzen.Size = new System.Drawing.Size(240, 30);
            this.txtOgrAdDüzen.TabIndex = 24;
            // 
            // lblOgrAdDuzen
            // 
            this.lblOgrAdDuzen.AutoSize = true;
            this.lblOgrAdDuzen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrAdDuzen.Location = new System.Drawing.Point(69, 84);
            this.lblOgrAdDuzen.Name = "lblOgrAdDuzen";
            this.lblOgrAdDuzen.Size = new System.Drawing.Size(115, 24);
            this.lblOgrAdDuzen.TabIndex = 23;
            this.lblOgrAdDuzen.Text = "Öğrenci Ad:";
            // 
            // txtOgridDuzenle
            // 
            this.txtOgridDuzenle.BackColor = System.Drawing.Color.White;
            this.txtOgridDuzenle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgridDuzenle.Location = new System.Drawing.Point(194, 33);
            this.txtOgridDuzenle.Name = "txtOgridDuzenle";
            this.txtOgridDuzenle.Size = new System.Drawing.Size(240, 30);
            this.txtOgridDuzenle.TabIndex = 46;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkGray;
            this.btnSil.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(319, 582);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(142, 54);
            this.btnSil.TabIndex = 47;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmOgrDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(571, 648);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtOgridDuzenle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.rchAdresDuzen);
            this.Controls.Add(this.lblVeliAdresDuzen);
            this.Controls.Add(this.lblVeliTlfDuzen);
            this.Controls.Add(this.mskVeliTlfDuzen);
            this.Controls.Add(this.txtVeliAdSoyadDuzen);
            this.Controls.Add(this.lblVeliAdSoyadDuzen);
            this.Controls.Add(this.cmbOdaNoDuzen);
            this.Controls.Add(this.lblOdaNoDuzen);
            this.Controls.Add(this.txtMailDuzen);
            this.Controls.Add(this.lblMailDuzen);
            this.Controls.Add(this.cmbOgrBolumDuzen);
            this.Controls.Add(this.lblOgrBolumDuzen);
            this.Controls.Add(this.lblDogumDuzen);
            this.Controls.Add(this.mskDogumDuzen);
            this.Controls.Add(this.lblTlfNoDuzen);
            this.Controls.Add(this.mskTlfNoDuzen);
            this.Controls.Add(this.lblOgrTCDuzen);
            this.Controls.Add(this.mskTCDuzen);
            this.Controls.Add(this.txtOgrSoyadDuzen);
            this.Controls.Add(this.lblOgrSoyadDuzen);
            this.Controls.Add(this.txtOgrAdDüzen);
            this.Controls.Add(this.lblOgrAdDuzen);
            this.Controls.Add(this.lblOgridDuzenId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOgrDuzenleme";
            this.Text = "Öğrenci Düzenleme ";
            this.Load += new System.EventHandler(this.frmOgrDuzenleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgridDuzenId;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.RichTextBox rchAdresDuzen;
        private System.Windows.Forms.Label lblVeliAdresDuzen;
        private System.Windows.Forms.Label lblVeliTlfDuzen;
        private System.Windows.Forms.MaskedTextBox mskVeliTlfDuzen;
        private System.Windows.Forms.TextBox txtVeliAdSoyadDuzen;
        private System.Windows.Forms.Label lblVeliAdSoyadDuzen;
        private System.Windows.Forms.ComboBox cmbOdaNoDuzen;
        private System.Windows.Forms.Label lblOdaNoDuzen;
        private System.Windows.Forms.TextBox txtMailDuzen;
        private System.Windows.Forms.Label lblMailDuzen;
        private System.Windows.Forms.ComboBox cmbOgrBolumDuzen;
        private System.Windows.Forms.Label lblOgrBolumDuzen;
        private System.Windows.Forms.Label lblDogumDuzen;
        private System.Windows.Forms.MaskedTextBox mskDogumDuzen;
        private System.Windows.Forms.Label lblTlfNoDuzen;
        private System.Windows.Forms.MaskedTextBox mskTlfNoDuzen;
        private System.Windows.Forms.Label lblOgrTCDuzen;
        private System.Windows.Forms.MaskedTextBox mskTCDuzen;
        private System.Windows.Forms.TextBox txtOgrSoyadDuzen;
        private System.Windows.Forms.Label lblOgrSoyadDuzen;
        private System.Windows.Forms.TextBox txtOgrAdDüzen;
        private System.Windows.Forms.Label lblOgrAdDuzen;
        private System.Windows.Forms.TextBox txtOgridDuzenle;
        private System.Windows.Forms.Button btnSil;
    }
}