using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Tokyo_Hair_Project
{
    public partial class Startup : Form
    {
        login log = new login();
        public Startup()
        {
            InitializeComponent();
            SoundPlayer Mytrack = new SoundPlayer();

            Mytrack.SoundLocation = "Shadowmaker.wav";
            Mytrack.Load();
            Mytrack.Play();
        }

        private void btnOpenStore_Click(object sender, EventArgs e)
        {
            log.ShowDialog();
        }
    }
}
