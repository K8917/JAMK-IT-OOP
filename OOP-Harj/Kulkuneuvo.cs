using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    class Kulkuneuvo
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public int Vuosimalli { get; set; }
        public string Vari { get; set; }

        public Kulkuneuvo() { }
        public Kulkuneuvo(string nimi, string malli, int vm, string vari)
        {
            Nimi = nimi;
            Malli = malli;
            Vuosimalli = vm;
            Vari = vari;
        }

        public virtual void Tulosta()
        {
            Console.WriteLine("Kulkuneuvo:");
            Console.WriteLine("Nimi: " + Nimi + ", Malli: " + Malli + ", Vuosimalli: " + Vuosimalli + ", Vari: " + Vari);
            Console.WriteLine();
        }
    }

    class Pyora : Kulkuneuvo
    {
        public bool Vaihteet { get; set; }
        public string Vaihdetyyppi { get; set; }
        private string tmp;

        public Pyora() { }
        public Pyora(string nimi, string malli, int vm, string vari)
            : base(nimi, malli, vm, vari)
        {
            Vaihteet = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nimi"></param>
        /// <param name="malli"></param>
        /// <param name="vm"></param>
        /// <param name="vari"></param>
        /// <param name="vt">Vaihdetyyppi</param>
        public Pyora(string nimi, string malli, int vm, string vari, string vt) 
            : base(nimi, malli, vm, vari)
        {
            Vaihteet = true;
            Vaihdetyyppi = vt;
        }

        public override void Tulosta()
        {
            if (Vaihteet == false)
            {
                Console.WriteLine("Pyora:");
                Console.WriteLine("Nimi: " + Nimi + ", Malli: " + Malli + ", Vuosimalli: " + Vuosimalli + ", Vari: " + Vari + ", Vaihteita ei ole");
            }
            else
            {
                Console.WriteLine("Vaihdepyora:");
                Console.WriteLine("Nimi: " + Nimi + ", Malli: " + Malli + ", Vuosimalli: " + Vuosimalli + ", Vari: " + Vari + ", Vaihteet: Loytyy" + ", Vaihdetyyppi " + Vaihdetyyppi);
            }
            Console.WriteLine();
        }
    }

    class Vene : Kulkuneuvo
    {
        public string Venetyyppi  { get; set; }
        public int Istuimet { get; set; }

        public Vene() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nimi"></param>
        /// <param name="malli"></param>
        /// <param name="vm">Vuosimalli</param>
        /// <param name="vari"></param>
        /// <param name="vt">Venetyyppi</param>
        /// <param name="istuimet"></param>
        public Vene(string nimi, string malli, int vm, string vari, string vt, int istuimet ) 
            : base(nimi, malli, vm, vari)
        {
            Venetyyppi = vt;
            Istuimet = istuimet;
        }

        public override void Tulosta()
        {
            Console.WriteLine("Vene:");
            Console.WriteLine("Nimi: " + Nimi + ", Malli: " + Malli + ", Vuosimalli: " + Vuosimalli + ", Vari: " + Vari + ", Venetyyppi: " + Venetyyppi + ", Istuimet: " + Istuimet);
            Console.WriteLine();
        }
    }
}
