using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodenHorse.TestHarness
{
    public partial class SpotifyTest : Form
    {
        public SpotifyTest()
        {
            InitializeComponent();
        }

        private void btnSpotify_Click(object sender, EventArgs e)
        {
            IPlaylist spotify = new RdioService();
        }
    }
}
