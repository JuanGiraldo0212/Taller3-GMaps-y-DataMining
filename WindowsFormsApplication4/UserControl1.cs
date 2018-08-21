using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using System.Collections;

namespace WindowsFormsApplication4
{
    public partial class UserControl1 : UserControl
    {
        private Principal principal;
        private Informacion info;
        private PanelReportes rep;
        private PanelAgregar agre;

        public Principal PrincipalCamb
        {
            get
            {
                return principal;
            }
            set
            {
                principal = value;
            }
        }

        public UserControl1()
        {
            InitializeComponent();
            principal = new Principal();
            agre = new PanelAgregar(this);
            rep = new PanelReportes(this);
            info = new Informacion(this);
            
        }

        public ArrayList getGrupos() {
            return principal.getGrupos();
        }

        public void agregarGrupoInvestigacion(String[] datos, string[] articulos)
        {
            principal.escritura(datos, articulos);
        }

        private void gmap_Load(object sender, EventArgs e)
        {

        }

		private void UserControl1_Load(object sender, EventArgs e)
		{
			gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
			GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
			gmap.SetPositionByKeywords("Colombia");
			gmap.ShowCenter = false;
			GMapOverlay markers = new GMapOverlay("markers");
			ArrayList grupos = principal.gruposInvestigacion;
			foreach (GruposInvestigacion g in grupos)
			{
				GMapControl auxiliar = new GMapControl();
				auxiliar.SetPositionByKeywords(g.ciudad);
				Random r = new Random();
				double incremento = r.NextDouble();
				double lat = auxiliar.Position.Lat - 0.5 + (r.NextDouble() * 1.0);
				double lng = auxiliar.Position.Lng - 0.5 + (r.NextDouble() * 1.0);
				PointLatLng pos = new PointLatLng(lat, lng);

				GMapMarker marker = new GMarkerGoogle(pos,
				GMarkerGoogleType.orange_dot);
				marker.Tag = g.nombre;
				markers.Markers.Add(marker);
				gmap.Overlays.Add(markers);
			}

		}

		private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            ArrayList gruposInv = principal.gruposInvestigacion;
            IEnumerable<GruposInvestigacion> consulta = from GruposInvestigacion s in gruposInv where s.nombre.Equals(item.Tag) select s;
            foreach(var s in consulta)
            {
                info.txtNombreChange = s.nombre;
                info.txtRegionChange = s.region;
                info.txtCiudadChange = s.ciudad;
                info.txtClasificacionChange = s.clasificacion;
                info.txtAreaInvestigacionChange = s.areaInvestigacion;
				string articulos = "";
				foreach(string art in s.articulos)
				{
					articulos += art + " ";
				}
                info.txtArticulosChange = articulos;
                info.Show();
            }

            
        }

        public void reconstruirArraylistGruposInvestigacion()
        {
            principal.generarRegistros();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agre = new PanelAgregar(this);
            agre.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            rep = new PanelReportes(this);
            rep.Show();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            ArrayList gruposInv = principal.gruposInvestigacion;
            IEnumerable<GruposInvestigacion> consulta = from GruposInvestigacion s in gruposInv where s.nombre.Equals(txtBuscar.Text) select s;
            foreach (var s in consulta)
            {
                info.txtNombreChange = s.nombre;
                info.txtRegionChange = s.region;
                info.txtCiudadChange = s.ciudad;
                info.txtClasificacionChange = s.clasificacion;
                info.txtAreaInvestigacionChange = s.areaInvestigacion;
                string articulos = "";
                foreach (string art in s.articulos)
                {
                    articulos += art + " ";
                }
                info.txtArticulosChange = articulos;
                info.Show();
                txtBuscar.Text = "";
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
