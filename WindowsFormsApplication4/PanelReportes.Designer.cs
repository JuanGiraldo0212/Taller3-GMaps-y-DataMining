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
            this.cbxReporte = new System.Windows.Forms.ComboBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cbxReporte
            // 
            this.cbxReporte.FormattingEnabled = true;
            this.cbxReporte.Location = new System.Drawing.Point(40, 187);
            this.cbxReporte.Name = "cbxReporte";
            this.cbxReporte.Size = new System.Drawing.Size(147, 21);
            this.cbxReporte.TabIndex = 1;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(40, 230);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(147, 42);
            this.btnReporte.TabIndex = 2;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(223, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 433);
            this.panel1.TabIndex = 3;
            // 
            // PanelReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.cbxReporte);
            this.Name = "PanelReportes";
            this.Text = "PanelReportes";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxReporte;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Panel panel1;
    }
}