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
    public partial class PanelReportes : Form
    {
        private UserControl1 principal;

        public PanelReportes(UserControl1 actual)
        {
            InitializeComponent();
            principal = actual;
        }

        public void reporte(string tipo) {

            if (tipo.Equals("Ciudad")) {
                
                ArrayList grupos = principal.getGrupos();
                List<String> ciudades = new List<string>();
                foreach (GruposInvestigacion c in grupos) {
                    ciudades.Add(c.ciudad);
                }
                var ciudadesD = ciudades.Distinct();
                foreach (var c in ciudadesD) {
                    var consulta = from GruposInvestigacion s in grupos
                                   where s.ciudad == c
                                   select s;
                    this.chart1.Series["Ciudad"].Points.AddXY(c, consulta.Count());
                }

            }
            else if (tipo.Equals("Region")) {
                ArrayList grupos = principal.getGrupos();
                List<String> regiones = new List<string>();
                foreach (GruposInvestigacion c in grupos)
                {
                    regiones.Add(c.region);
                }
                var regionesD = regiones.Distinct();
                foreach (var c in regionesD)
                {
                    var consulta = from GruposInvestigacion s in grupos
                                   where s.region == c
                                   select s;
                    this.chart1.Series["Region"].Points.AddXY(c, consulta.Count());
                }
            }
            else if (tipo.Equals("Area Inv"))
            {
                ArrayList grupos = principal.getGrupos();
                List<String> areas = new List<string>();
                foreach (GruposInvestigacion c in grupos)
                {
                    areas.Add(c.areaInvestigacion);
                }
                var areasD = areas.Distinct();
                foreach (var c in areasD)
                {
                    var consulta = from GruposInvestigacion s in grupos
                                   where s.areaInvestigacion == c
                                   select s;
                    this.chart1.Series["Areas investigacion"].Points.AddXY(c, consulta.Count());
                }
            }
            else if (tipo.Equals("Clasificacion"))
            {
                ArrayList grupos = principal.getGrupos();
                List<String> clasificacion = new List<string>();
                foreach (GruposInvestigacion c in grupos)
                {
                    clasificacion.Add(c.clasificacion);
                }
                var clasificacionD = clasificacion.Distinct();
                foreach (var c in clasificacionD)
                {
                    var consulta = from GruposInvestigacion s in grupos
                                   where s.clasificacion == c
                                   select s;
                    this.chart1.Series["Clasificacion"].Points.AddXY(c, consulta.Count());
                }
            }

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            reporte(cbxReporte.Text);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void PanelReportes_Load(object sender, EventArgs e)
        {

        }
    }
}
