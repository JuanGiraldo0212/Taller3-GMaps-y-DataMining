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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            "Clasificacion",
            "Consultas Articulos"});
			this.cbxReporte.Location = new System.Drawing.Point(495, 670);
			this.cbxReporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbxReporte.Name = "cbxReporte";
			this.cbxReporte.Size = new System.Drawing.Size(219, 28);
			this.cbxReporte.TabIndex = 1;
			// 
			// btnReporte
			// 
			this.btnReporte.Location = new System.Drawing.Point(807, 651);
			this.btnReporte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnReporte.Name = "btnReporte";
			this.btnReporte.Size = new System.Drawing.Size(220, 65);
			this.btnReporte.TabIndex = 2;
			this.btnReporte.Text = "Reporte";
			this.btnReporte.UseVisualStyleBackColor = true;
			this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
			// 
			// chart1
			// 
			this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(12, 13);
			this.chart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Ciudad";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Region";
			series3.ChartArea = "ChartArea1";
			series3.Legend = "Legend1";
			series3.Name = "Area investigacion";
			series4.ChartArea = "ChartArea1";
			series4.Legend = "Legend1";
			series4.Name = "Clasificacion";
			series5.ChartArea = "ChartArea1";
			series5.Legend = "Legend1";
			series5.Name = "Consultas Articulos";
			this.chart1.Series.Add(series1);
			this.chart1.Series.Add(series2);
			this.chart1.Series.Add(series3);
			this.chart1.Series.Add(series4);
			this.chart1.Series.Add(series5);
			this.chart1.Size = new System.Drawing.Size(1059, 600);
			this.chart1.TabIndex = 3;
			this.chart1.Text = "chart1";
			this.chart1.Click += new System.EventHandler(this.chart1_Click);
			// 
			// PanelReportes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1083, 760);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.btnReporte);
			this.Controls.Add(this.cbxReporte);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "PanelReportes";
			this.Text = "PanelReportes";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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