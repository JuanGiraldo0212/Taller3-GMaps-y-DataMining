﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
	public partial class PanelAgregar : Form
	{

		private UserControl1 principal;

		public PanelAgregar(UserControl1 actual)
		{
			InitializeComponent();
			principal = actual;

		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			string[] articulos = txtArticulos.Text.Trim().Split(' ');
			String[] datos = { txtNombre.Text, txtRegion.Text, txtCiudad.Text, txtAreaInvestigacion.Text, txtClasificacion.Text};
            principal.agregarGrupoInvestigacion(datos, articulos);
        }

        private void PanelAgregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

		private void PanelAgregar_Load(object sender, EventArgs e)
		{

		}
	}
}
