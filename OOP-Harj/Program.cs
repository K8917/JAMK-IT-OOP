using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    class Program
    {
        static void Main(string[] args)
        {
            // Steam: Alhainen < 33, Sopiva < 66, Liikaa < 100
            Kiuas k1 = new Kiuas();
            
            k1.TurnOnOff();
            k1.SetTemp(30);
            k1.SetSteam(60);
            k1.PrintInfo();

            k1.SetTemp(90);
            k1.SetSteam(10);
            k1.PrintInfo();
        }
    }
}
