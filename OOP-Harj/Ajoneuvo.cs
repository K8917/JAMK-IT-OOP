using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    class Rengas
    {
        public int Koko { get; set; }
        public string Nimi { get; set; }
        public string Merkki { get; set; }
        public Rengas()
        {
            Koko = 20;
            Nimi = "rengas";
            Merkki = "DSA";
        }
        public Rengas(int koko, string nimi, string merkki)
        {
            Koko = koko;
            Nimi = nimi;
            Merkki = merkki;
        }
        public string Tulosta()
        {
            return "Renkaan Koko: " + Koko + ", Nimi: " + Nimi + ", Merkki: " + Merkki;
        }
    }
    class Ajoneuvo
    {
        public List<Rengas> Renkaat;
        public string Nimi { get; set; }
        public string Merkki { get; set; }
        public Ajoneuvo()
        {
            Renkaat = new List<Rengas>();
        }
        public Ajoneuvo(string nimi, string merkki)
            : base()
        {
            Nimi = nimi;
            Merkki = merkki;
        }
        public Ajoneuvo(int renkaat, string nimi, string merkki)
        {
            Renkaat = new List<Rengas>();
            for (int i = 0; i < renkaat; ++i)
            {
                Rengas tmp = new Rengas();
                this.Renkaat.Add(tmp);
            }
            Nimi = nimi;
            Merkki = merkki;
        }
        public string Tulosta()
        {
            return "Ajoneuvon nimi: " + Nimi + ", Merkki: " + Merkki + ", Renkaita: " + Renkaat.Count;
        }
    }
}
