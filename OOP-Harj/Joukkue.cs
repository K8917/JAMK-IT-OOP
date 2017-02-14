using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    class Joukkue
    {
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        public List<Pelaaja> Pelaajat;
        public Joukkue()
        {
            Pelaajat = new List<Pelaaja>();
            
        }
        public Joukkue(string nimi, string kk)
            : this()
        {
            Nimi = nimi;
            Kotikaupunki = kk;
        }
        public static void HaePelaajat(ref Joukkue joukkue)
        {
            Console.WriteLine("Joukkueen: " + joukkue.Nimi + " pelaajat haetaan...");
            joukkue.Pelaajat.Add(new Pelaaja("Olli", "Aitola", 25, 60));
            joukkue.Pelaajat.Add(new Pelaaja("Joonas", "Erving", 22, 53));
            joukkue.Pelaajat.Add(new Pelaaja("Niklas", "Friman", 23, 20));
            joukkue.Pelaajat.Add(new Pelaaja("Mikko", "Kalteva", 32, 7));
            joukkue.Pelaajat.Add(new Pelaaja("Valtteri", "Hotakainen", 26, 21));
            joukkue.Pelaajat.Add(new Pelaaja("Juha-Pekka", "Hytonen", 35, 15));
            joukkue.Pelaajat.Add(new Pelaaja("Henri", "Kanninen", 22, 71));
            joukkue.Pelaajat.Add(new Pelaaja("Ossi", "Louhivaara", 33, 23));
            joukkue.Pelaajat.Add(new Pelaaja("Janne", "Kolehmainen", 30, 55));
        }
    }
    class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int Ika { get; set; }
        public int Numero { get; set; }
        public Pelaaja() { }
        public Pelaaja(string enimi, string snimi, int ika, int num)
        {
            Etunimi = enimi;
            Sukunimi = snimi;
            Ika = ika;
            Numero = num;
        }
    }
}
