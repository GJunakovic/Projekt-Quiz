using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Kviz
{
    public partial class Form1 : Form
    {
        //varijable

        int indexPitanja = 0;

        string tocanOdg;
        public string imeIgraca;
        int tocniOdgovori;

        int milliseconds = 2000; // delay za izlaz iz apk

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
            label1.Text = tocniOdgovori + "/" + lista.Count;
        }

        public Rezultat KalkulirajRezultat(string text, string tocanOdogovr, int tocniOdgovori, int indexPitanja)   // funkcija koja provjerava tocnost odgovora i povecava broj bodova i index
        {
            if (text == tocanOdogovr)
            {
                tocniOdgovori++;
                indexPitanja++;
                return new Rezultat(tocniOdgovori, true, indexPitanja);
            }
            else
            {
                return new Rezultat(tocniOdgovori, false, indexPitanja);
            }
        }



        public void OdgovoriEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender; //Provjera dogadaja kada je pritisnut jedan od ponudenih botuna

            Rezultat rezultat = KalkulirajRezultat(senderObject.Text, tocanOdg, tocniOdgovori, indexPitanja);

            if (rezultat.tocanTrenutniOdgovor)  //AKO JE ODGOVOR TOCAN 
            {
                tocniOdgovori = rezultat.tocniOdgovori;
                indexPitanja = rezultat.indexPitanja;
                label1.Text = tocniOdgovori + "/" + lista.Count;

                if (indexPitanja < lista.Count)     // AKO TRENUTNI BROJ PITANJA MANJI OD UKUPNOG BROJA PITANJA
                {
                    Ispis(lista);
                }
                else
                {
                    //OVO JE  NOVA FORMA KADA JE KORISNIK ODGOVORIJA NA SVA PITANJA
                    SveOdgovorenoForma sveOdg = new SveOdgovorenoForma();
                    sveOdg.ShowDialog();
                    dodajRezultat(tocniOdgovori);
                    this.Close();

                    Thread.Sleep(milliseconds); // dodano da aplikacija bez obzira sta je stisnuto na kraju botun za izlaz ili X u kantunu prekine sa radon
                    Application.Exit();
                }
            }
            else
            {
                //OVO JE ZAPRAVO NOVA FORMA KADA KRIVO ODGOVORI                
                this.Close();
                GameOver_prikaz gameOverForma = new GameOver_prikaz();
                gameOverForma.prikazBodova.Text = "Vaš rezultat je " + tocniOdgovori + "/" + lista.Count;
                gameOverForma.ShowDialog();
                dodajRezultat(tocniOdgovori);

                  
                Thread.Sleep(milliseconds); // dodano da aplikacija bez obzira sta je stisnuto na kraju botun za izlaz ili X u kantunu prekine sa radon
                Application.Exit();

                // IGRA JE GOTOVA
            }
        }

        void Ispis(List<Pitanje> lista) // funkcija koja ispisuje pitanja i odgovore na botune
        {
            lblPitanje.Text = lista[indexPitanja].pitanje;
            odgovor1.Text = lista[indexPitanja].odgovor1;
            odgovor2.Text = lista[indexPitanja].odgovor2;
            odgovor3.Text = lista[indexPitanja].odgovor3;
            odgovor4.Text = lista[indexPitanja].odgovor4;
            tocanOdg = lista[indexPitanja].tocanOdgovor;
        }

        private void dodajRezultat(int rezultat) // funkcija koja zapisuje ime igraca i njegove osvojene bodove.
        {

            using (StreamWriter sw = File.AppendText("rezultati.txt"))
            {
                sw.WriteLine(imeIgraca + " --> " + rezultat);
            }
        }

    }
}
