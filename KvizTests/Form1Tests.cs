using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kviz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviz.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void KalkulirajRezultatTest()
        {
            Form1 test = new Form1();
            Rezultat rezultaTocan = test.KalkulirajRezultat("blabla", "blabla", 0, 0);
            Assert.IsTrue(rezultaTocan.tocanTrenutniOdgovor);
            Assert.AreSame(rezultaTocan.tocniOdgovori, 1);
            Assert.AreSame(rezultaTocan.indexPitanja, 1);


            Rezultat rezultatNetocan = test.KalkulirajRezultat("blabla", "nestoDrugo", 0, 0);
            Assert.IsTrue(rezultatNetocan.tocanTrenutniOdgovor);
            Assert.AreSame(rezultatNetocan.tocniOdgovori, 0);
            Assert.AreSame(rezultatNetocan.indexPitanja, 0);
        }
    }
}