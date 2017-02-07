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
            /*
            // Harjoitus 1.1
            Kiuas k1 = new Kiuas();
            k1.TurnOnOff();
            k1.temp_ = 50;
            k1.steam_ = 30;
            Console.WriteLine(k1.PrintInfo());
            k1.TurnOnOff();

            // Harjoitus 1.2
            Pesukone p1 = new Pesukone();
            Pesukone p2 = new Pesukone(1, 50, 30);
            p1.VaihdaPesumuoto(0);
            p1.lampotila_ = 30;
            p1.aika_ = 60;
            p2.Aloitus();
            Console.WriteLine(p1.Tulostus());
            p1.Aloitus();
            Console.WriteLine(p2.Tulostus());

            // Harjoitus 1.3
            Televisio t1 = new Televisio();
            Televisio t2 = new Televisio(20, 80);
            t1.Volume = 120;
            t1.Channel = 50;
            Console.WriteLine(t1.Tulosta());
            t1.OnOff = true;
            t2.OnOff = true;
            Console.WriteLine(t1.Tulosta());
            Console.WriteLine(t2.Tulosta());

            // Harjoitus 4
            Vehicle v1 = new Vehicle();
            v1.name = "Ford";
            v1.speed = 100;
            v1.tyres = 4;
            v1.PrintData();
            v1.speed = 50;
            Console.WriteLine(v1.ToString());

            // Harjoitus 1.5
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

            // Harjoitus 1.6
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
            
            // Harjoitus 2.1
            Hissi hi1 = new Hissi();
            string tmp;
            int num;
            bool x;

            Console.WriteLine("Lopeta painamalla Ctrl+C");

            do
            {
                Console.Write("Mille kerrokselle haluat (1-5) > ");
                tmp = Console.ReadLine();
                x = int.TryParse(tmp, out num);
                if (num > 0 && num <= 5 && x)
                {
                    hi1.Floor = num;
                }
                else
                {
                    Console.WriteLine("Kerrosta ei ole");
                }

                Console.WriteLine("Hissi on kerroksella : " + hi1.Floor);

            } while (x);
            
            // Harjoitus 2.2
            Vahvistin va1 = new Vahvistin();
            bool x = true;
            string tmp;
            int tmp2;

            do
            {
                Console.Write("Anna aanenvoimakkuus (0-100) > ");
                tmp = Console.ReadLine();
                x = int.TryParse(tmp, out tmp2);
                
                if (tmp2 < 0)
                {
                    va1.Volume = 0;
                    Console.WriteLine("Liian hiljaisella, aanenvoimakkuus on " + va1.Volume);
                }
                else if (tmp2 > 100)
                {
                    va1.Volume = 100;
                    Console.WriteLine("Liian kovalla, aanenvoimakkuus on " + va1.Volume);
                }
                else
                {
                    va1.Volume = tmp2;
                    Console.WriteLine("Aanenvoimakkuus: " + va1.Volume);
                }
            } while (x);
            
            // Harjoitus 2.3
            Employee emp1 = new Employee("Matti", "Tradenomi", 2000);
            Boss bo1 = new Boss("Joonas", "Insinoori", 5000, "Volvo", 500);
            emp1.Tulosta();
            bo1.Tulosta();
            bo1.Profession = "Tyoton";
            bo1.Car = "Rikki";
            bo1.Salary = 0;
            bo1.Bonus = 0;
            bo1.Tulosta();
            
            // Harjoitus 2.4
            Vene ven1 = new Vene("Vene1", "Romukasa", 1960, "Ruskea", "Soutuvene", 6);
            Pyora py1 = new Pyora("Pyora1", "Kilpapyora", 2015, "Punainen");
            Pyora py2 = new Pyora("Pyora2", "Peruspyora", 2005, "Sininen", "7 Vaihdetta");
            ven1.Tulosta();
            py1.Tulosta();
            py2.Tulosta();
            
            // Harjoitus 2.5
            Radio r1 = new Radio(5,5000.5);
            r1.TurnOnOff();
            r1.ChangeVol(9);
            r1.ChangeFreq(6000.0);
            Console.WriteLine("Radion aanenvoimakkuus: " + r1.Vol + ", taajuus: " + r1.Freq);
            r1.ChangeVol(3);
            r1.ChangeFreq(1000.0);
            Console.WriteLine("Radion aanenvoimakkuus: " + r1.Vol + ", taajuus: " + r1.Freq);
            r1.ChangeVol(20);
            r1.ChangeFreq(20000.7);
            Console.WriteLine("Radion aanenvoimakkuus: " + r1.Vol + ", taajuus: " + r1.Freq);
            r1.TurnOnOff();
            
            // Harjoitus 2.6
            Tavarat t1 = new Tavarat("Tavarat");
            Kirja ki1 = new Kirja("Kirja", 200);
            Puhelin p1 = new Puhelin("Puhelin", "Malli 1");
            CDLevy cd1 = new CDLevy("CD-levy", 20);
            Console.WriteLine(ki1.Tulosta());
            Console.WriteLine(p1.Tulosta());
            Console.WriteLine(cd1.Tulosta());
            
            // Harjoitus 2.7
            Internet i1 = new Internet();
            Kello ke1 = new Kello();
            ke1.HaeAika();
            Console.WriteLine(ke1.Tulosta() + "\nPaina jotain...");
            Console.ReadKey();
            ke1.HaeAika();
            Console.WriteLine(ke1.Tulosta() + "\nPaina jotain...");
            Console.ReadKey();
            ke1.HaeAika();
            Console.WriteLine(ke1.Tulosta() + "\nPaina jotain...");
            Console.ReadKey();
            ke1.HaeAika();
            Console.WriteLine(ke1.Tulosta());
            */
            // Harjoitus 3.1
            Ajoneuvo au1 = new Ajoneuvo();
            Rengas r1 = new Rengas();
            au1.renkaat_.Add(r1);

            Console.WriteLine("Renkaat: " + au1.renkaat_[0].Koko);
        }
    }
}
