using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviz
{
    public class Rezultat
    {
        public int tocniOdgovori;
        public bool tocanTrenutniOdgovor;
        public int indexPitanja;

        public Rezultat(int tocniOdgovori, bool tocanTrenutniOdgovor, int indexPitanja)
        {
            this.tocniOdgovori = tocniOdgovori;
            this.tocanTrenutniOdgovor = tocanTrenutniOdgovor;
            this.indexPitanja = indexPitanja;
        }
    }
}
