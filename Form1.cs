using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace GMapMarkerMoveTest_v1
{
    public partial class Form1 : Form
    {
        GMapOverlay markersOverlay = new GMapOverlay("markers");

        bool isMarkerPicked = false;
        int markerID = 0;
        GMapMarker markerPicked;
        PointLatLng markerPrviousPosition = new PointLatLng(0, 0);

        public Form1()
        {
            InitializeComponent();

            gMapControl1.Overlays.Add(markersOverlay);

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.SetPositionByKeywords("Poland, Bialystok");
        }
        #region buttons
        private void button_addMarker_Click(object sender, EventArgs e)
        {
            PointLatLng markerPoint = gMapControl1.Position;

            GMarkerGoogle marker = new GMarkerGoogle(markerPoint,  GMarkerGoogleType.green);
            markersOverlay.Markers.Add(marker);
        }

        private void buttonRemoveAllMarkers_Click(object sender, EventArgs e)
        {
            markersOverlay.Markers.Clear();
        }

        #endregion

        private void gMapControl1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMarkerPicked == true && e.Button == MouseButtons.Left)
            {
                isMarkerPicked = false;
            }
        }

        private void gMapControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && markerID != -1)
            {
                isMarkerPicked = true;
                markerPrviousPosition = markerPicked.Position;
            }
        }

        private void gMapControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMarkerPicked == true)
            {
                var lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
                var lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
                markerPicked.Position = new PointLatLng(lat, lng);

                label_globalPosition.Text = new PointLatLng(lat, lng).ToString();
            }
        }

        private void gMapControl1_OnMarkerEnter(GMapMarker item)
        {
            markerID = item.GetHashCode();
            markerPicked = item;
        }

        private void gMapControl1_OnMarkerLeave(GMapMarker item)
        {
            markerID = -1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_markerID.Text = markerID.ToString();
            label_previousPosition.Text = markerPrviousPosition.ToString();
        }

    }
}
