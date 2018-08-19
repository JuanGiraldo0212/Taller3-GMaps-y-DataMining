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

namespace WindowsFormsApplication4
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
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

            
            Informacion info = new Informacion();
            info.Show();
    }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelReportes rep = new PanelReportes();
            rep.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelAgregar agre = new PanelAgregar();
            agre.Show();
        }
    }
}
