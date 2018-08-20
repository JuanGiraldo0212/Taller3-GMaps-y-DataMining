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
using System.Windows.Forms.DataVisualization.Charting;

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
			String[] series = { "Ciudad", "Region", "Areas investigación", "Clasificacion" };
			chart1.Series.Clear();
			chart1.Series.Add(series[0]);
			chart1.Series.Add(series[1]);
			chart1.Series.Add(series[2]);
			chart1.Series.Add(series[3]);
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
			else if (tipo.Equals("Consultas Articulos"))
			{
				chart1.Series.Clear();
				ArrayList grupos = principal.getGrupos();
				string articulos = "";
				foreach (GruposInvestigacion c in grupos)
				{
					foreach (string a in c.articulos)
					{
						articulos += a + " ";
					}
				}
				var articulosD = articulos.Trim().Split(' ').Distinct().OrderBy(x => x);
				int[] cantidades = new int[articulosD.Count()];
				for (int i = 0; i < articulosD.Count(); i++)
				{
					foreach (GruposInvestigacion g in grupos)
					{
						cantidades[i] += g.articulos.Count(x => x.Equals(articulosD.ElementAt(i)));
					}
				}
				for (int i = 0; i < articulosD.Count(); i++)
				{
					Series serie = chart1.Series.Add(articulosD.ElementAt(i));
					serie.Label = cantidades[i] + "";
					serie.Points.Add(cantidades[i]);
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
