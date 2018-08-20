using System;
using System.Collections;
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
    public partial class Informacion : Form
    {

        private UserControl1 control1;

        public Informacion(UserControl1 actual)
        {
            InitializeComponent();
            control1 = actual;
        }
        public string txtNombreChange
        {
            get
            {
                return txtNombre.Text;
            }
            set
            {
                txtNombre.Text = value;
            }
        }

        public string txtArticulosChange
        {
            get
            {
                return txtArticulos.Text;
            }
            set
            {
                txtArticulos.Text = value;
            }
        }

        public string txtRegionChange
        {
            get
            {
                return txtRegion.Text;
            }
            set
            {
                txtRegion.Text = value;
            }
        }
        public string txtCiudadChange
        {
            get
            {
                return txtCiudad.Text;
            }
            set
            {
                txtCiudad.Text = value;
            }
        }
        public string txtAreaInvestigacionChange
        {
            get
            {
                return txtAreaInvestigacion.Text;
            }
            set
            {
                txtAreaInvestigacion.Text = value;
            }
        }
        
        public string txtClasificacionChange
        {
            get
            {
                return txtClasificacion.Text;
            }
            set
            {
                txtClasificacion.Text = value;
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtArticulos.Enabled = true;
            txtRegion.Enabled = true;
            txtClasificacion.Enabled = true;
            txtAreaInvestigacion.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled =false;
            txtArticulos.Enabled = false;
            txtRegion.Enabled = false;
            txtClasificacion.Enabled = false;
            txtCiudad.Enabled = false;
            txtAreaInvestigacion.Enabled = false;

            ArrayList gruposInv = control1.PrincipalCamb.gruposInvestigacion;
            IEnumerable<GruposInvestigacion> consulta = from GruposInvestigacion s in gruposInv where s.nombre.Equals(txtNombre) select s;
            foreach (var s in consulta)
            {
                s.nombre = txtNombre.Text;
                s.region = txtRegion.Text;
                s.clasificacion = txtClasificacion.Text;
                s.areaInvestigacion = txtAreaInvestigacion.Text;
                s.articulos = txtArticulos.Text;
            }

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArticulos_TextChanged(object sender, EventArgs e)
        {

        }

        private void Informacion_Load(object sender, EventArgs e)
        {
            
        }
    }
}
