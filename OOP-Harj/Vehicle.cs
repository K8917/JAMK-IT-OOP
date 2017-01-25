using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    class Vehicle
    {
        public string name { get; set; }
        public int speed { get; set; }
        public int tyres { get; set; }

        public Vehicle () { }

        public void PrintData()
        {
            Console.WriteLine("Nimi: " + name + " Nopeus :" + speed + " Renkaita: " + tyres);
        }

        public string ToString()
        {
            return "Nimi: " + name + " Nopeus :" + speed + " Renkaita: " + tyres;
        }
    }
}
