
namespace YurtOtomasyonSistemi
{
    partial class frmGelirIstatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGelirIstatistik));
            this.lblKasadakiPara = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.cmbAy = new System.Windows.Forms.ComboBox();
            this.lblAy = new System.Windows.Forms.Label();
            this.lblSeçilenAyPara = new System.Windows.Forms.Label();
            this.lblSecilenAy = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKasadakiPara
            // 
            this.lblKasadakiPara.AutoSize = true;
            this.lblKasadakiPara.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasadakiPara.Location = new System.Drawing.Point(24, 90);
            this.lblKasadakiPara.Name = "lblKasadakiPara";
            this.lblKasadakiPara.Size = new System.Drawing.Size(142, 24);
            this.lblKasadakiPara.TabIndex = 0;
            this.lblKasadakiPara.Text = "Kasadaki Para:";
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPara.Location = new System.Drawing.Point(172, 90);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(22, 24);
            this.lblPara.TabIndex = 1;
            this.lblPara.Text = "0";
            // 
            // cmbAy
            // 
            this.cmbAy.FormattingEnabled = true;
            this.cmbAy.Location = new System.Drawing.Point(176, 41);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Size = new System.Drawing.Size(148, 24);
            this.cmbAy.TabIndex = 2;
            this.cmbAy.SelectedIndexChanged += new System.EventHandler(this.cmbAy_SelectedIndexChanged);
            // 
            // lblAy
            // 
            this.lblAy.AutoSize = true;
            this.lblAy.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAy.Location = new System.Drawing.Point(74, 41);
            this.lblAy.Name = "lblAy";
            this.lblAy.Size = new System.Drawing.Size(92, 24);
            this.lblAy.TabIndex = 3;
            this.lblAy.Text = "Ay Seçin:";
            // 
            // lblSeçilenAyPara
            // 
            this.lblSeçilenAyPara.AutoSize = true;
            this.lblSeçilenAyPara.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeçilenAyPara.Location = new System.Drawing.Point(172, 127);
            this.lblSeçilenAyPara.Name = "lblSeçilenAyPara";
            this.lblSeçilenAyPara.Size = new System.Drawing.Size(22, 24);
            this.lblSeçilenAyPara.TabIndex = 5;
            this.lblSeçilenAyPara.Text = "0";
            // 
            // lblSecilenAy
            // 
            this.lblSecilenAy.AutoSize = true;
            this.lblSecilenAy.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecilenAy.Location = new System.Drawing.Point(58, 127);
            this.lblSecilenAy.Name = "lblSecilenAy";
            this.lblSecilenAy.Size = new System.Drawing.Size(108, 24);
            this.lblSecilenAy.TabIndex = 4;
            this.lblSecilenAy.Text = "Seçilen Ay:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(28, 174);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Aylık";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(666, 265);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // frmGelirIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(727, 467);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblSeçilenAyPara);
            this.Controls.Add(this.lblSecilenAy);
            this.Controls.Add(this.lblAy);
            this.Controls.Add(this.cmbAy);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.lblKasadakiPara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGelirIstatistik";
            this.Text = "Gelir İstatistik";
            this.Load += new System.EventHandler(this.frmGelirIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKasadakiPara;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.ComboBox cmbAy;
        private System.Windows.Forms.Label lblAy;
        private System.Windows.Forms.Label lblSeçilenAyPara;
        private System.Windows.Forms.Label lblSecilenAy;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}