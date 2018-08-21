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
using System.IO;

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

            string nombreTemporal = "";

            ArrayList gruposInv = control1.PrincipalCamb.gruposInvestigacion;
            IEnumerable<GruposInvestigacion> consulta = from GruposInvestigacion s in gruposInv where s.nombre.Equals(txtNombre.Text) select s;
            foreach (var s in consulta)
            {
                nombreTemporal = s.nombre;
                s.nombre = txtNombre.Text;
                s.region = txtRegion.Text;
                s.clasificacion = txtClasificacion.Text;
                s.areaInvestigacion = txtAreaInvestigacion.Text;
				string[] articulos = txtArticulos.Text.Trim().Split(' ');
				s.articulos = articulos;
            }

            //Reconstruimos el archivo de texto
            string[] lineas = File.ReadAllLines(Principal.ruta);

            for(int i = 0; i < lineas.Length; i++)
            {
                string[] partes = lineas[i].Split(',');
                if (partes.Length > 7)
                {
                    if (partes[3].Equals(nombreTemporal))
                    {
                        //Pendientes los articulos
                        partes[3] = txtNombre.Text;
                        partes[8] = txtRegion.Text;
                        partes[11] = txtAreaInvestigacion.Text;
                        partes[13] = txtClasificacion.Text;
                        partes[2] = txtArticulos.Text;

                        lineas[i] = partes[3] + "," + partes[8] + "," + partes[5] + "," + partes[11] + "," + partes[13] + "," + partes[2];
                        break;
                    }
                    
                    
                }
                else
                {
                    if (partes[0].Equals(nombreTemporal))
                    {
                        //Pendientes los articulos
                        partes[0] = txtNombre.Text;
                        partes[1] = txtRegion.Text;
                        partes[3] = txtAreaInvestigacion.Text;
                        partes[4] = txtClasificacion.Text;
                        partes[5] = txtArticulos.Text;

                        lineas[i] = partes[0] + "," + partes[1] + "," + partes[2] + "," + partes[3] + "," + partes[4] + "," + partes[5];
                        break;
                    }
                    

                }
                

            }
            File.WriteAllLines(Principal.ruta, lineas);


            //Reconstruimos el arraylist de gruposdeInvestigacion
            control1.reconstruirArraylistGruposInvestigacion();


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
