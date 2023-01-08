using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Kviz
{
    public partial class Form1 : Form
    {
        //varijable

        int indexPitanja = 0;

        string tocanOdg;
        public string imeIgraca;

        PocetniPrikaz frm1 = new PocetniPrikaz();

        List<Pitanje> lista = new List<Pitanje>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            string imeDatoteke = "Pitanja i odgovori.txt"; // datoteka sa pitanjima i odgovorima

            if (!File.Exists(imeDatoteke))
            {
                MessageBox.Show("Nema datoteke sa pitanjima!");
                return;
            }
            StreamReader sr = File.OpenText(imeDatoteke);
            string linija;
            while ((linija = sr.ReadLine()) != null)
            {
                string[] niz = linija.Split(';');

                string pitanje = niz[0];
                string odg1 = niz[1];
                string odg2 = niz[2];
                string odg3 = niz[3];
                string odg4 = niz[4];
                tocanOdg = niz[5];

                Pitanje novoPitanje = new Pitanje(pitanje, odg1, odg2, odg3, odg4, tocanOdg);

                lista.Add(novoPitanje);
            }

            Ispis(lista);
            
        }

        int tocniOdgovori;

        public void OdgovoriEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            if (senderObject.Text == tocanOdg)
            {
                MessageBox.Show("tocan odgovor");
                tocniOdgovori++;
                indexPitanja++;

                if (indexPitanja < lista.Count)
                {
                    Ispis(lista);
                }
                else
                {
                    MessageBox.Show("Vas rezultat je" + tocniOdgovori + "/" + lista.Count); //OVO JE ZAPRAVO NOVA FORMA KADA JE KORISNIK ODGOVORIJA NA SVA PITANJA
                }
            }
            else
            {
                //OVO JE ZAPRAVO NOVA FORMA KADA KRIVO ODGOVORI                
                this.Visible = false;
                GameOver_prikaz gameOverForma = new GameOver_prikaz();
                gameOverForma.prikazBodova.Text = "Vas rezultat je " + tocniOdgovori + "/" + lista.Count;
                gameOverForma.ShowDialog();
                dodajRezultat(tocniOdgovori);
                
                // IGRA JE GOTOVA
            }
        }

        void Ispis(List<Pitanje> lista)
        {
            lblPitanje.Text = lista[indexPitanja].pitanje;
            odgovor1.Text = lista[indexPitanja].odgovor1;
            odgovor2.Text = lista[indexPitanja].odgovor2;
            odgovor3.Text = lista[indexPitanja].odgovor3;
            odgovor4.Text = lista[indexPitanja].odgovor4;
            tocanOdg = lista[indexPitanja].tocanOdgovor;
        }

        private void dodajRezultat(int rezultat)
        {
            
            using (StreamWriter sw = File.AppendText("rezultati.txt"))
            {
                sw.WriteLine(imeIgraca + " --> " + rezultat);
            }
        }

    }
}
