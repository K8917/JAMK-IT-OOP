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
            // Harjoitus 1
            Kiuas k1 = new Kiuas();
            k1.TurnOnOff();
            k1.temp_ = 50;
            k1.steam_ = 30;
            Console.WriteLine(k1.PrintInfo());
            k1.TurnOnOff();

            Console.WriteLine();

            // Harjoitus 2
            Pesukone p1 = new Pesukone();
            Pesukone p2 = new Pesukone(1, 50, 30);
            p1.VaihdaPesumuoto(0);
            p1.lampotila_ = 30;
            p1.aika_ = 60;
            p2.Aloitus();
            Console.WriteLine(p1.Tulostus());
            p1.Aloitus();
            Console.WriteLine(p2.Tulostus());

            Console.WriteLine();

            // Harjoitus 3
            Televisio t1 = new Televisio();
            Televisio t2 = new Televisio(20, 80);
            t1.Volume = 120;
            t1.Channel = 50;
            Console.WriteLine(t1.Tulosta());
            t1.OnOff = true;
            t2.OnOff = true;
            Console.WriteLine(t1.Tulosta());
            Console.WriteLine(t2.Tulosta());
        }
    }
}
