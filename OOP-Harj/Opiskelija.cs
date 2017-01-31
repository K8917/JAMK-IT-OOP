using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    class Opiskelija
    {
        public string name_ { get; set; }
        public string ryhma_ { get; set; }
        public int math_ { get; set; }
        public int eng_ { get; set; }

        public Opiskelija () { }

        public Opiskelija (string name, string ryhma, int math, int eng)
        {
            name_ = name;
            ryhma_ = ryhma;
            math_ = math;
            eng_ = eng;
        }

        public override string ToString()
        {
            return "Nimi: " + name_ + " Ryhma: " + ryhma_ + " Matematiikka: " + math_ + " Englanti: " + eng_;
        }
    }
}
