using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MusicManager
{
    public partial class MainForm : Form
    {
        private BindingSource albumBindingSource = new BindingSource();
        private BindingSource tracksBindingSource = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConnectionDB connection = new ConnectionDB();

            //Connect the album list fetched from DB to the BindingSource
            albumBindingSource.DataSource = connection.getAlbums();

            //Connect the BindingSource to the DataGridView
            dgvAlbums.DataSource = albumBindingSource;
        }

        private void dgvAlbums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Convert the sender to a DataGridViewObject 
            DataGridView grid = sender as DataGridView;

            //Get the url value of the selected row
            int clickedRowIndex = grid.CurrentRow.Index;
            string url = grid.Rows[clickedRowIndex].Cells[3].Value.ToString();

            //Load the picture
            albumPicture.Load(url);


            //Find which album was clicked
            Album clickedAlbum = grid.CurrentRow.DataBoundItem as Album;

            //Get the list of tracks from that album and connect it to the corresponding BindingSource
            tracksBindingSource.DataSource = clickedAlbum.Tracks;

            //Connect the DataGridView and the binding source
            dgvTracks.DataSource = tracksBindingSource;
        }

        private const string EMBED_TEMPLATE =
            "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=11\">" +
            "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' frameborder='0' allowfullscreen></iframe>" +
            "</body></html>";

        private void dgvTracks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Convert the sender to a DataGridViewObject 
            DataGridView grid = sender as DataGridView;

            //Get the url value of the selected row
            int clickedRowIndex = grid.CurrentRow.Index;
            string url = grid.Rows[clickedRowIndex].Cells[2].Value.ToString();

            //webVideo.Url = new Uri(url);
            webVideo.DocumentText = string.Format(EMBED_TEMPLATE, url.Split('=')[1]);
        }
    }
}
