
namespace YurtOtomasyonSistemi
{
    partial class frmOdemeler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdemeler));
            this.lblOgridOdeme = new System.Windows.Forms.Label();
            this.txtOgridOdeme = new System.Windows.Forms.TextBox();
            this.txtOgrOdenen = new System.Windows.Forms.TextBox();
            this.lblOgrOdeme = new System.Windows.Forms.Label();
            this.txtKalanBorc = new System.Windows.Forms.TextBox();
            this.lblKalanBorc = new System.Windows.Forms.Label();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.dtgOdeme = new System.Windows.Forms.DataGridView();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrKalanBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet2 = new YurtOtomasyonSistemi.YurtOtomasyonuDataSet2();
            this.borclarTableAdapter = new YurtOtomasyonSistemi.YurtOtomasyonuDataSet2TableAdapters.BorclarTableAdapter();
            this.txtOgrOdemeSoyad = new System.Windows.Forms.TextBox();
            this.lblOgrOdemeSoyad = new System.Windows.Forms.Label();
            this.txtOgrOdemeAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtOdenenAy = new System.Windows.Forms.TextBox();
            this.lblOdenenAy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOdeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOgridOdeme
            // 
            this.lblOgridOdeme.AutoSize = true;
            this.lblOgridOdeme.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgridOdeme.Location = new System.Drawing.Point(152, 36);
            this.lblOgridOdeme.Name = "lblOgridOdeme";
            this.lblOgridOdeme.Size = new System.Drawing.Size(114, 24);
            this.lblOgridOdeme.TabIndex = 0;
            this.lblOgridOdeme.Text = "Öğrenci ID:";
            // 
            // txtOgridOdeme
            // 
            this.txtOgridOdeme.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgridOdeme.Location = new System.Drawing.Point(284, 36);
            this.txtOgridOdeme.Name = "txtOgridOdeme";
            this.txtOgridOdeme.Size = new System.Drawing.Size(179, 30);
            this.txtOgridOdeme.TabIndex = 1;
            // 
            // txtOgrOdenen
            // 
            this.txtOgrOdenen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrOdenen.Location = new System.Drawing.Point(284, 148);
            this.txtOgrOdenen.Name = "txtOgrOdenen";
            this.txtOgrOdenen.Size = new System.Drawing.Size(179, 30);
            this.txtOgrOdenen.TabIndex = 3;
            // 
            // lblOgrOdeme
            // 
            this.lblOgrOdeme.AutoSize = true;
            this.lblOgrOdeme.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrOdeme.Location = new System.Drawing.Point(180, 151);
            this.lblOgrOdeme.Name = "lblOgrOdeme";
            this.lblOgrOdeme.Size = new System.Drawing.Size(86, 24);
            this.lblOgrOdeme.TabIndex = 2;
            this.lblOgrOdeme.Text = "Ödenen:";
            // 
            // txtKalanBorc
            // 
            this.txtKalanBorc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKalanBorc.Location = new System.Drawing.Point(284, 184);
            this.txtKalanBorc.Name = "txtKalanBorc";
            this.txtKalanBorc.Size = new System.Drawing.Size(179, 30);
            this.txtKalanBorc.TabIndex = 5;
            // 
            // lblKalanBorc
            // 
            this.lblKalanBorc.AutoSize = true;
            this.lblKalanBorc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanBorc.Location = new System.Drawing.Point(152, 187);
            this.lblKalanBorc.Name = "lblKalanBorc";
            this.lblKalanBorc.Size = new System.Drawing.Size(114, 24);
            this.lblKalanBorc.TabIndex = 4;
            this.lblKalanBorc.Text = "Kalan Borç:";
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.BackColor = System.Drawing.Color.DarkGray;
            this.btnOdemeAl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeAl.Location = new System.Drawing.Point(315, 256);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(118, 49);
            this.btnOdemeAl.TabIndex = 6;
            this.btnOdemeAl.Text = "Ödeme Al";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // dtgOdeme
            // 
            this.dtgOdeme.AutoGenerateColumns = false;
            this.dtgOdeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOdeme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrKalanBorcDataGridViewTextBoxColumn});
            this.dtgOdeme.DataSource = this.borclarBindingSource;
            this.dtgOdeme.Location = new System.Drawing.Point(29, 322);
            this.dtgOdeme.Name = "dtgOdeme";
            this.dtgOdeme.RowHeadersWidth = 51;
            this.dtgOdeme.RowTemplate.Height = 24;
            this.dtgOdeme.Size = new System.Drawing.Size(554, 304);
            this.dtgOdeme.TabIndex = 7;
            this.dtgOdeme.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgOdeme_CellClick);
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            this.ogrAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            this.ogrSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrKalanBorcDataGridViewTextBoxColumn
            // 
            this.ogrKalanBorcDataGridViewTextBoxColumn.DataPropertyName = "OgrKalanBorc";
            this.ogrKalanBorcDataGridViewTextBoxColumn.HeaderText = "OgrKalanBorc";
            this.ogrKalanBorcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrKalanBorcDataGridViewTextBoxColumn.Name = "ogrKalanBorcDataGridViewTextBoxColumn";
            this.ogrKalanBorcDataGridViewTextBoxColumn.Width = 125;
            // 
            // borclarBindingSource
            // 
            this.borclarBindingSource.DataMember = "Borclar";
            this.borclarBindingSource.DataSource = this.yurtOtomasyonuDataSet2;
            // 
            // yurtOtomasyonuDataSet2
            // 
            this.yurtOtomasyonuDataSet2.DataSetName = "YurtOtomasyonuDataSet2";
            this.yurtOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borclarTableAdapter
            // 
            this.borclarTableAdapter.ClearBeforeFill = true;
            // 
            // txtOgrOdemeSoyad
            // 
            this.txtOgrOdemeSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrOdemeSoyad.Location = new System.Drawing.Point(284, 112);
            this.txtOgrOdemeSoyad.Name = "txtOgrOdemeSoyad";
            this.txtOgrOdemeSoyad.Size = new System.Drawing.Size(179, 30);
            this.txtOgrOdemeSoyad.TabIndex = 15;
            // 
            // lblOgrOdemeSoyad
            // 
            this.lblOgrOdemeSoyad.AutoSize = true;
            this.lblOgrOdemeSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrOdemeSoyad.Location = new System.Drawing.Point(197, 118);
            this.lblOgrOdemeSoyad.Name = "lblOgrOdemeSoyad";
            this.lblOgrOdemeSoyad.Size = new System.Drawing.Size(69, 24);
            this.lblOgrOdemeSoyad.TabIndex = 14;
            this.lblOgrOdemeSoyad.Text = "Soyad:";
            // 
            // txtOgrOdemeAd
            // 
            this.txtOgrOdemeAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrOdemeAd.Location = new System.Drawing.Point(284, 76);
            this.txtOgrOdemeAd.Name = "txtOgrOdemeAd";
            this.txtOgrOdemeAd.Size = new System.Drawing.Size(179, 30);
            this.txtOgrOdemeAd.TabIndex = 13;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(226, 76);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(40, 24);
            this.lblAd.TabIndex = 12;
            this.lblAd.Text = "Ad:";
            // 
            // txtOdenenAy
            // 
            this.txtOdenenAy.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdenenAy.Location = new System.Drawing.Point(284, 220);
            this.txtOdenenAy.Name = "txtOdenenAy";
            this.txtOdenenAy.Size = new System.Drawing.Size(179, 30);
            this.txtOdenenAy.TabIndex = 17;
            // 
            // lblOdenenAy
            // 
            this.lblOdenenAy.AutoSize = true;
            this.lblOdenenAy.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenenAy.Location = new System.Drawing.Point(152, 223);
            this.lblOdenenAy.Name = "lblOdenenAy";
            this.lblOdenenAy.Size = new System.Drawing.Size(114, 24);
            this.lblOdenenAy.TabIndex = 16;
            this.lblOdenenAy.Text = "Ödenen Ay:";
            // 
            // frmOdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(607, 638);
            this.Controls.Add(this.txtOdenenAy);
            this.Controls.Add(this.lblOdenenAy);
            this.Controls.Add(this.txtOgrOdemeSoyad);
            this.Controls.Add(this.lblOgrOdemeSoyad);
            this.Controls.Add(this.txtOgrOdemeAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.dtgOdeme);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.txtKalanBorc);
            this.Controls.Add(this.lblKalanBorc);
            this.Controls.Add(this.txtOgrOdenen);
            this.Controls.Add(this.lblOgrOdeme);
            this.Controls.Add(this.txtOgridOdeme);
            this.Controls.Add(this.lblOgridOdeme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOdemeler";
            this.Text = "Ödemeler";
            this.Load += new System.EventHandler(this.frmOdemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOdeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgridOdeme;
        private System.Windows.Forms.TextBox txtOgridOdeme;
        private System.Windows.Forms.TextBox txtOgrOdenen;
        private System.Windows.Forms.Label lblOgrOdeme;
        private System.Windows.Forms.TextBox txtKalanBorc;
        private System.Windows.Forms.Label lblKalanBorc;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.DataGridView dtgOdeme;
        private YurtOtomasyonuDataSet2 yurtOtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource borclarBindingSource;
        private YurtOtomasyonuDataSet2TableAdapters.BorclarTableAdapter borclarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrKalanBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtOgrOdemeSoyad;
        private System.Windows.Forms.Label lblOgrOdemeSoyad;
        private System.Windows.Forms.TextBox txtOgrOdemeAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtOdenenAy;
        private System.Windows.Forms.Label lblOdenenAy;
    }
}