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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblAreaInvestigacion = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblArticulis = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtAreaInvestigacion = new System.Windows.Forms.TextBox();
            this.txtClasificacion = new System.Windows.Forms.TextBox();
            this.txtArticulos = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(42, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(42, 103);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(44, 13);
            this.lblRegion.TabIndex = 2;
            this.lblRegion.Text = "Region:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(42, 155);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 3;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblAreaInvestigacion
            // 
            this.lblAreaInvestigacion.AutoSize = true;
            this.lblAreaInvestigacion.Location = new System.Drawing.Point(42, 207);
            this.lblAreaInvestigacion.Name = "lblAreaInvestigacion";
            this.lblAreaInvestigacion.Size = new System.Drawing.Size(112, 13);
            this.lblAreaInvestigacion.TabIndex = 4;
            this.lblAreaInvestigacion.Text = "Area de investigación:";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Location = new System.Drawing.Point(42, 260);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(69, 13);
            this.lblClasificacion.TabIndex = 5;
            this.lblClasificacion.Text = "Clasificación:";
            // 
            // lblArticulis
            // 
            this.lblArticulis.AutoSize = true;
            this.lblArticulis.Location = new System.Drawing.Point(42, 316);
            this.lblArticulis.Name = "lblArticulis";
            this.lblArticulis.Size = new System.Drawing.Size(50, 13);
            this.lblArticulis.TabIndex = 6;
            this.lblArticulis.Text = "Articulos:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(188, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(188, 100);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(200, 20);
            this.txtRegion.TabIndex = 8;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(188, 152);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(200, 20);
            this.txtCiudad.TabIndex = 9;
            // 
            // txtAreaInvestigacion
            // 
            this.txtAreaInvestigacion.Location = new System.Drawing.Point(188, 204);
            this.txtAreaInvestigacion.Name = "txtAreaInvestigacion";
            this.txtAreaInvestigacion.Size = new System.Drawing.Size(200, 20);
            this.txtAreaInvestigacion.TabIndex = 10;
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Location = new System.Drawing.Point(188, 257);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.Size = new System.Drawing.Size(200, 20);
            this.txtClasificacion.TabIndex = 11;
            // 
            // txtArticulos
            // 
            this.txtArticulos.Location = new System.Drawing.Point(188, 313);
            this.txtArticulos.Multiline = true;
            this.txtArticulos.Name = "txtArticulos";
            this.txtArticulos.Size = new System.Drawing.Size(200, 106);
            this.txtArticulos.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(188, 451);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 40);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // PanelAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 522);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtArticulos);
            this.Controls.Add(this.txtClasificacion);
            this.Controls.Add(this.txtAreaInvestigacion);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblArticulis);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.lblAreaInvestigacion);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblNombre);
            this.Name = "PanelAgregar";
            this.Text = "PanelAgregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblAreaInvestigacion;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblArticulis;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtAreaInvestigacion;
        private System.Windows.Forms.TextBox txtClasificacion;
        private System.Windows.Forms.TextBox txtArticulos;
        private System.Windows.Forms.Button btnAgregar;
    }
}