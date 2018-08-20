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

        public void agregarGrupoInvestigacion(String[] datos)
        {
            principal.escritura(datos);
        }

        private void gmap_Load(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.SetPositionByKeywords("Bogota, Colombia");
            gmap.ShowCenter = false;
            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(
                new PointLatLng(48.8617774, 2.349272),
                GMarkerGoogleType.orange_dot);
            marker.Tag="Bogota";
            markers.Markers.Add(marker);
            gmap.Overlays.Add(markers);
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
                info.txtArticulosChange = s.articulos;
                info.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rep.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            agre.Show();
        }
    }
}
