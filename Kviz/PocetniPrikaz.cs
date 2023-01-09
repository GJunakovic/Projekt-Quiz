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
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public PocetniPrikaz()
        {
            InitializeComponent();
            UcitajRezultate();
            player.SoundLocation = "glazba2.wav";
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            player.Play();
            Form1 frm1 = new Form1();
            if (unosImenatxt.Text == "")    // provjera unosa imena ako nije popounjen textbox igra se nece pokreniti
            {
                MessageBox.Show("Polje ime je obavezno!");
                return;
            }
            else
            {
                frm1.imeIgraca = unosImenatxt.Text;
            }
            this.Visible = false;
            frm1.ShowDialog();
            
        }

        private void PocetniPrikaz_Load(object sender, EventArgs e)
        {
            
        }


        private void UcitajRezultate()                  //FUNKCIJA KOJA UCITAVA REZULTATE IZ TXT FILE-A, U LISTVIEW-U
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
