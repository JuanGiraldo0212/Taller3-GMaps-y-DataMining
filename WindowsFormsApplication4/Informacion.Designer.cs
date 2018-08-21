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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtArticulos = new System.Windows.Forms.TextBox();
            this.txtClasificacion = new System.Windows.Forms.TextBox();
            this.txtAreaInvestigacion = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblArticulis = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblAreaInvestigacion = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(63, 440);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(89, 40);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtArticulos
            // 
            this.txtArticulos.Enabled = false;
            this.txtArticulos.Location = new System.Drawing.Point(186, 303);
            this.txtArticulos.Multiline = true;
            this.txtArticulos.Name = "txtArticulos";
            this.txtArticulos.Size = new System.Drawing.Size(200, 106);
            this.txtArticulos.TabIndex = 25;
            this.txtArticulos.TextChanged += new System.EventHandler(this.txtArticulos_TextChanged);
            // 
            // txtClasificacion
            // 
            this.txtClasificacion.Enabled = false;
            this.txtClasificacion.Location = new System.Drawing.Point(186, 247);
            this.txtClasificacion.Name = "txtClasificacion";
            this.txtClasificacion.Size = new System.Drawing.Size(200, 20);
            this.txtClasificacion.TabIndex = 24;
            // 
            // txtAreaInvestigacion
            // 
            this.txtAreaInvestigacion.Enabled = false;
            this.txtAreaInvestigacion.Location = new System.Drawing.Point(186, 194);
            this.txtAreaInvestigacion.Name = "txtAreaInvestigacion";
            this.txtAreaInvestigacion.Size = new System.Drawing.Size(200, 20);
            this.txtAreaInvestigacion.TabIndex = 23;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Enabled = false;
            this.txtCiudad.Location = new System.Drawing.Point(186, 142);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(200, 20);
            this.txtCiudad.TabIndex = 22;
            // 
            // txtRegion
            // 
            this.txtRegion.Enabled = false;
            this.txtRegion.Location = new System.Drawing.Point(186, 90);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(200, 20);
            this.txtRegion.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(186, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 20;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblArticulis
            // 
            this.lblArticulis.AutoSize = true;
            this.lblArticulis.Location = new System.Drawing.Point(40, 306);
            this.lblArticulis.Name = "lblArticulis";
            this.lblArticulis.Size = new System.Drawing.Size(50, 13);
            this.lblArticulis.TabIndex = 19;
            this.lblArticulis.Text = "Articulos:";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Location = new System.Drawing.Point(40, 250);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(69, 13);
            this.lblClasificacion.TabIndex = 18;
            this.lblClasificacion.Text = "Clasificación:";
            // 
            // lblAreaInvestigacion
            // 
            this.lblAreaInvestigacion.AutoSize = true;
            this.lblAreaInvestigacion.Location = new System.Drawing.Point(40, 197);
            this.lblAreaInvestigacion.Name = "lblAreaInvestigacion";
            this.lblAreaInvestigacion.Size = new System.Drawing.Size(112, 13);
            this.lblAreaInvestigacion.TabIndex = 17;
            this.lblAreaInvestigacion.Text = "Area de investigación:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(40, 145);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 16;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(40, 93);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(44, 13);
            this.lblRegion.TabIndex = 15;
            this.lblRegion.Text = "Region:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(40, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(265, 440);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 40);
            this.btnAceptar.TabIndex = 27;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 509);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnActualizar);
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
            this.Name = "Informacion";
            this.Text = "Informacion";
            this.Load += new System.EventHandler(this.Informacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtArticulos;
        private System.Windows.Forms.TextBox txtClasificacion;
        private System.Windows.Forms.TextBox txtAreaInvestigacion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblArticulis;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblAreaInvestigacion;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAceptar;
    }
}