namespace WindowsFormsApplication4
{
    partial class PanelAgregar
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
            this.agregar1 = new WindowsFormsApplication4.Agregar();
            this.SuspendLayout();
            // 
            // agregar1
            // 
            this.agregar1.Location = new System.Drawing.Point(-1, 2);
            this.agregar1.Name = "agregar1";
            this.agregar1.Size = new System.Drawing.Size(390, 539);
            this.agregar1.TabIndex = 0;
            // 
            // PanelAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 539);
            this.Controls.Add(this.agregar1);
            this.Name = "PanelAgregar";
            this.Text = "PanelAgregar";
            this.ResumeLayout(false);

        }

        #endregion

        private Agregar agregar1;
    }
}