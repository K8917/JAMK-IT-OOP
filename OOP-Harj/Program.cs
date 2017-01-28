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

            Console.WriteLine();

            // Harjoitus 4
            Vehicle v1 = new Vehicle();
            v1.name = "Ford";
            v1.speed = 100;
            v1.tyres = 4;
            v1.PrintData();
            v1.speed = 50;
            Console.WriteLine(v1.ToString());

            Console.WriteLine();

            // Harjoitus 5
            List<Opiskelija> opiskelijat = new List<Opiskelija>();
            Opiskelija o1 = new Opiskelija("Mikko","A",4,3);
            Opiskelija o2 = new Opiskelija("Matti", "B", 5, 2);
            Opiskelija o3 = new Opiskelija("Matias", "A", 4, 5);
            Opiskelija o4 = new Opiskelija("Marko", "C", 4, 1);
            Opiskelija o5 = new Opiskelija("Mikael", "D", 2, 5);
            opiskelijat.Add(o1);
            opiskelijat.Add(o2);
            opiskelijat.Add(o3);
            opiskelijat.Add(o4);
            opiskelijat.Add(o5);

            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine(opiskelijat[i].ToString());
            }

            Console.WriteLine();
            
            // Harjoitus 6
            List<Levy> Levyt = new List<Levy>();
            Uuni h1 = new Uuni(250, true);
            Levy l1 = new Levy(12, true);
            Levy l2 = new Levy(12, true);
            Levy l3 = new Levy(0, false);
            Levy l4 = new Levy(0, false);
            Levyt.Add(l1);
            Levyt.Add(l2);
            Levyt.Add(l3);
            Levyt.Add(l4);

            Console.WriteLine(h1.Tulosta(ref Levyt));
        }
    }
}
