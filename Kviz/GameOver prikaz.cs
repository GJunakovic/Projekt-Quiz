using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kviz
{
    public partial class GameOver_prikaz : Form
    {
        public Form1 frm1;

        public GameOver_prikaz()
        {
            InitializeComponent();
            
        }

        private void GameOver_prikaz_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // DOGADAJ KOJI PRITISKOM NA BOTUN ZATVARA CIJELI PROGRAM.
        }
    }
}
