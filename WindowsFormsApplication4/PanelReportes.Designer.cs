namespace WindowsFormsApplication4
{
    partial class PanelReportes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbxReporte = new System.Windows.Forms.ComboBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxReporte
            // 
            this.cbxReporte.FormattingEnabled = true;
            this.cbxReporte.Items.AddRange(new object[] {
            "Ciudad",
            "Region",
            "Area invetigacion",
            "Clasificacion"});
            this.cbxReporte.Location = new System.Drawing.Point(53, 230);
            this.cbxReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxReporte.Name = "cbxReporte";
            this.cbxReporte.Size = new System.Drawing.Size(195, 24);
            this.cbxReporte.TabIndex = 1;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(53, 283);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(196, 52);
            this.btnReporte.TabIndex = 2;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(281, 88);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Ciudad";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Region";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Area investigacion";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Clasificacion";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(651, 437);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // PanelReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 608);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.cbxReporte);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PanelReportes";
            this.Text = "PanelReportes";
            this.Load += new System.EventHandler(this.PanelReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxReporte;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}