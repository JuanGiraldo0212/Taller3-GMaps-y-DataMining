namespace WindowsFormsApplication4
{
    partial class Informacion
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
            this.showInfo1 = new WindowsFormsApplication4.ShowInfo();
            this.SuspendLayout();
            // 
            // showInfo1
            // 
            this.showInfo1.Location = new System.Drawing.Point(0, -1);
            this.showInfo1.Name = "showInfo1";
            this.showInfo1.Size = new System.Drawing.Size(406, 555);
            this.showInfo1.TabIndex = 0;
            // 
            // Informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 556);
            this.Controls.Add(this.showInfo1);
            this.Name = "Informacion";
            this.Text = "Informacion";
            this.ResumeLayout(false);

        }

        #endregion

        private ShowInfo showInfo1;
    }
}