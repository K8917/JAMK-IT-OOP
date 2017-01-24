using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    class Pesukone
    {
        private bool aloitaLopeta_;
        private string[] pesumuodot_ = { "Hienopesu", "Linkous", "Valkaisu" };
        private string pesumuoto_;
        public uint lampotila_ { get; set; }
        public uint aika_ { get; set; }

        public Pesukone()
        {
            aloitaLopeta_ = false;
        }
        /// <summary>
        /// </summary>
        /// <param name="pesuIndeksi">Pesuindeksi on valilla 0-2</param>
        /// <param name="lampotila">Lampotila on > 0</param>
        /// <param name="aika">Aika on > 0</param>
        public Pesukone(uint pesuIndeksi, uint lampotila, uint aika) 
            : this()
        {
            pesumuoto_ = pesumuodot_[pesuIndeksi];
            lampotila_ = lampotila;
            aika_ = aika;
        }

        public void Aloitus()
        {
            bool tmp = aloitaLopeta_;
            if (tmp != true)
            {
                Console.WriteLine("Pesukone kaynnistyy");
                tmp = true;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="pesuindeksi">Pesuindeksi on valilla 0-2</param>
        public void VaihdaPesumuoto(uint pesuindeksi)
        {
            pesumuoto_ = pesumuodot_[pesuindeksi];
        }

        public string Tulostus()
        {
            string tmp = "Pesunmuoto: " + pesumuoto_ + ", Lampotila: " + lampotila_ + "'C, Aika: " + aika_ + " min";
            return tmp;
        }
    }
}
