using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kviz
{
    public partial class SveOdgovorenoForma : Form
    {
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer();

        public SveOdgovorenoForma()
        {
            InitializeComponent();
            player2.SoundLocation = "pljesak.wav";
        }

        private void SveOdgovorenoForma_Load(object sender, EventArgs e)
        {
            player2.Play();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
