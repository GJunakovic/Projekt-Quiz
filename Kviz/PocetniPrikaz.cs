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
    public partial class PocetniPrikaz : Form
    {
        
        public PocetniPrikaz()
        {
            InitializeComponent();
            UcitajRezultate();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.imeIgraca = unosImenatxt.Text;
            this.Visible = false;
            frm1.ShowDialog();
            
        }

        private void PocetniPrikaz_Load(object sender, EventArgs e)
        {
            
        }


        private void UcitajRezultate()
        {
            string[] nizRezultata = File.ReadAllLines("rezultati.txt");

            foreach (string linija in nizRezultata)
            {
                listView1.Items.Add(linija);
            }
                

        }

        private void unosImenatxt_TextChanged(object sender, EventArgs e)
        {
            
        }   
    }
}
