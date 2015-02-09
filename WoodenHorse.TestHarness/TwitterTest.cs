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
    public partial class TwitterTest : Form
    {
        public TwitterTest()
        {
            InitializeComponent();
        }

        private void btnNextTweet_Click(object sender, EventArgs e)
        {
            ITweets tweets = new TwitterService();
            rtbOutput.Text = tweets.NextTweet();
        }
    }
}
