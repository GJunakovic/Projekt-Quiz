namespace Kviz
{
    class Pitanje

    {
        public string pitanje;
        public string odgovor1;
        public string odgovor2;
        public string odgovor3;
        public string odgovor4;
        public string tocanOdgovor;

        public Pitanje(string pitanje, string odgovor1, string odgovor2, string odgovor3, string odgovor4, string tocanOdgovor)
        {
            this.pitanje = pitanje;
            this.odgovor1 = odgovor1;
            this.odgovor2 = odgovor2;
            this.odgovor3 = odgovor3;
            this.odgovor4 = odgovor4;
            this.tocanOdgovor = tocanOdgovor;
        }
    }
}
