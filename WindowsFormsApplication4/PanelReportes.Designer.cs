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
            this.reportes1 = new WindowsFormsApplication4.Reportes();
            this.SuspendLayout();
            // 
            // reportes1
            // 
            this.reportes1.Location = new System.Drawing.Point(-5, 2);
            this.reportes1.Name = "reportes1";
            this.reportes1.Size = new System.Drawing.Size(780, 521);
            this.reportes1.TabIndex = 0;
            // 
            // PanelReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 531);
            this.Controls.Add(this.reportes1);
            this.Name = "PanelReportes";
            this.Text = "PanelReportes";
            this.ResumeLayout(false);

        }

        #endregion

        private Reportes reportes1;
    }
}