
namespace YurtOtomasyonSistemi
{
    partial class frmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBolumler));
            this.pcAdd = new System.Windows.Forms.PictureBox();
            this.pcDelete = new System.Windows.Forms.PictureBox();
            this.pcEdit = new System.Windows.Forms.PictureBox();
            this.lblBolumID = new System.Windows.Forms.Label();
            this.txtBolumID = new System.Windows.Forms.TextBox();
            this.txtBolumAdi = new System.Windows.Forms.TextBox();
            this.lblBolumAd = new System.Windows.Forms.Label();
            this.dtgBolumler = new System.Windows.Forms.DataGridView();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonuDataSet = new YurtOtomasyonSistemi.YurtOtomasyonuDataSet();
            this.bolumlerTableAdapter = new YurtOtomasyonSistemi.YurtOtomasyonuDataSetTableAdapters.BolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBolumler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pcAdd
            // 
            this.pcAdd.Image = ((System.Drawing.Image)(resources.GetObject("pcAdd.Image")));
            this.pcAdd.Location = new System.Drawing.Point(409, 11);
            this.pcAdd.Name = "pcAdd";
            this.pcAdd.Size = new System.Drawing.Size(78, 61);
            this.pcAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcAdd.TabIndex = 0;
            this.pcAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.pcAdd, "Bölüm Ekle");
            this.pcAdd.Click += new System.EventHandler(this.pcAdd_Click);
            // 
            // pcDelete
            // 
            this.pcDelete.Image = ((System.Drawing.Image)(resources.GetObject("pcDelete.Image")));
            this.pcDelete.Location = new System.Drawing.Point(409, 78);
            this.pcDelete.Name = "pcDelete";
            this.pcDelete.Size = new System.Drawing.Size(78, 56);
            this.pcDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcDelete.TabIndex = 1;
            this.pcDelete.TabStop = false;
            this.toolTip1.SetToolTip(this.pcDelete, "Bölüm Sil");
            this.pcDelete.Click += new System.EventHandler(this.pcDelete_Click);
            // 
            // pcEdit
            // 
            this.pcEdit.Image = ((System.Drawing.Image)(resources.GetObject("pcEdit.Image")));
            this.pcEdit.Location = new System.Drawing.Point(409, 140);
            this.pcEdit.Name = "pcEdit";
            this.pcEdit.Size = new System.Drawing.Size(78, 64);
            this.pcEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcEdit.TabIndex = 2;
            this.pcEdit.TabStop = false;
            this.toolTip1.SetToolTip(this.pcEdit, "Bölüm Güncelle");
            this.pcEdit.Click += new System.EventHandler(this.pcEdit_Click);
            // 
            // lblBolumID
            // 
            this.lblBolumID.AutoSize = true;
            this.lblBolumID.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBolumID.Location = new System.Drawing.Point(39, 61);
            this.lblBolumID.Name = "lblBolumID";
            this.lblBolumID.Size = new System.Drawing.Size(104, 24);
            this.lblBolumID.TabIndex = 3;
            this.lblBolumID.Text = "Bölüm ID:";
            // 
            // txtBolumID
            // 
            this.txtBolumID.Enabled = false;
            this.txtBolumID.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumID.Location = new System.Drawing.Point(149, 58);
            this.txtBolumID.Name = "txtBolumID";
            this.txtBolumID.Size = new System.Drawing.Size(186, 30);
            this.txtBolumID.TabIndex = 4;
            // 
            // txtBolumAdi
            // 
            this.txtBolumAdi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBolumAdi.Location = new System.Drawing.Point(149, 107);
            this.txtBolumAdi.Name = "txtBolumAdi";
            this.txtBolumAdi.Size = new System.Drawing.Size(186, 30);
            this.txtBolumAdi.TabIndex = 6;
            // 
            // lblBolumAd
            // 
            this.lblBolumAd.AutoSize = true;
            this.lblBolumAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBolumAd.Location = new System.Drawing.Point(32, 113);
            this.lblBolumAd.Name = "lblBolumAd";
            this.lblBolumAd.Size = new System.Drawing.Size(111, 24);
            this.lblBolumAd.TabIndex = 5;
            this.lblBolumAd.Text = "Bölüm Adı:";
            // 
            // dtgBolumler
            // 
            this.dtgBolumler.AutoGenerateColumns = false;
            this.dtgBolumler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBolumler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dtgBolumler.DataSource = this.bolumlerBindingSource;
            this.dtgBolumler.Location = new System.Drawing.Point(12, 211);
            this.dtgBolumler.Name = "dtgBolumler";
            this.dtgBolumler.RowHeadersWidth = 51;
            this.dtgBolumler.RowTemplate.Height = 24;
            this.dtgBolumler.Size = new System.Drawing.Size(491, 295);
            this.dtgBolumler.TabIndex = 7;
            this.dtgBolumler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBolumler_CellClick);
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bolumidDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtOtomasyonuDataSet;
            // 
            // yurtOtomasyonuDataSet
            // 
            this.yurtOtomasyonuDataSet.DataSetName = "YurtOtomasyonuDataSet";
            this.yurtOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // frmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(513, 517);
            this.Controls.Add(this.dtgBolumler);
            this.Controls.Add(this.txtBolumAdi);
            this.Controls.Add(this.lblBolumAd);
            this.Controls.Add(this.txtBolumID);
            this.Controls.Add(this.lblBolumID);
            this.Controls.Add(this.pcEdit);
            this.Controls.Add(this.pcDelete);
            this.Controls.Add(this.pcAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBolumler";
            this.Text = "Bölüm Formu";
            this.Load += new System.EventHandler(this.frmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBolumler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcAdd;
        private System.Windows.Forms.PictureBox pcDelete;
        private System.Windows.Forms.PictureBox pcEdit;
        private System.Windows.Forms.Label lblBolumID;
        private System.Windows.Forms.TextBox txtBolumID;
        private System.Windows.Forms.TextBox txtBolumAdi;
        private System.Windows.Forms.Label lblBolumAd;
        private System.Windows.Forms.DataGridView dtgBolumler;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtOtomasyonuDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private YurtOtomasyonuDataSet yurtOtomasyonuDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}