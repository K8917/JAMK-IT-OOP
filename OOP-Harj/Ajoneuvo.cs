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
        public Rengas() { Koko = 10; }
    }
    class Ajoneuvo
    {
        public List<Rengas> Renkaat;
        public Ajoneuvo()
        {
            Renkaat = new List<Rengas>();
        }
    }
}
