using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKTeht
{
    class Program
    {
        static void Main(string[] args)
        {
            Teht5();
        }

        static void Harj1()
        {
            Console.Write("Anna kayttajien etunimet: ");

            string[] nimet = new string[5];
            for (int i = 0; i < 5; ++i)
            {
                nimet[i] = Console.ReadLine();
            }

            Console.Write("Annoit nimet: ");
            for (int i = 0; i < 5; ++i)
            {
                Console.Write(nimet[i] + " ");
            }

            Array.Sort(nimet);
            Console.Write("\nNimet aakkosjarjestyksessa: ");
            for (int i = 0; i < 5; ++i)
            {
                Console.Write(nimet[i] + " ");
            }
            Console.Write('\n');
        }
        static void Harj2()
        {
            var numerot = new List<int>();
            var numerot2 = new List<string>();
            Random r = new Random();

            Console.Write("Kuinka monta lottorivia > ");
            int rivit = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rivit; ++i)
            {
                numerot.Clear(); // Tyhjenna lista

                for (int j = 0; j < 7; ++j)
                {
                    int tmp_num = r.Next(0, 40);
                    if (!(j > 0 && numerot.Contains(tmp_num))) // Onko satunnaisnumero listassa
                    {
                        numerot.Add(tmp_num);
                        string tmp = tmp_num.ToString();
                        numerot2.Add(tmp);
                    }
                    else
                    {
                        --j;
                    }
                }

                Console.Write("Rivi " + i + ": ");
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}", numerot2.ToArray());
            }
        }
        static void Teht1()
        {
            string[] luvut = { "Yksi", "Kaksi", "Kolme" };

            Console.Write("Anna Luku (1-3) > ");
            int luku = int.Parse(Console.ReadLine());

            if (luku > 3 || luku < 1)
            {
                Console.WriteLine("Joku muu luku");
            }
            else
            {
                Console.WriteLine(luvut[luku - 1]);
            }
        }
        static void Teht2()
        {
            int pisteet = new int();

            Console.Write("Anna pisteet: ");
            pisteet = int.Parse(Console.ReadLine());

            if (pisteet == 12)
            {
                --pisteet;
            }

            Console.WriteLine("Numero on {0}", (pisteet / 2));
        }
        static void Teht3()
        {
            // Tee ohjelma, joka kysyy kayttajalta kolme lukua ja tulostaa niiden summan ja keskiarvon.
            int[] luvut = new int[3];
            Console.WriteLine("Anna kolme lukua: ");

            for (int i = 0; i < 3; ++i)
            {
                luvut[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Lukujen Summa: " + (luvut.Sum()) + ", " + "Keskiarvo " + (luvut.Average()));
        }
        static void Teht4()
        {
            /*Tee ohjelma, jossa kysytaan kayttajalta taman ika. 
             * Jos ika on alle 18 vuotta, tulosta "alaikainen", 
             * jos se on 18 - 65 vuotta, tulosta "aikuinen", 
             * muussa tapauksessa tulosta "seniori". */
            Console.Write("Anna ikasi: ");
            int ika = int.Parse(Console.ReadLine());

            if (ika < 18) { Console.WriteLine("Alaikainen"); }
            else if (ika >= 18 && ika < 66) { Console.WriteLine("Aikuinen"); }
            else { Console.WriteLine("Seniori"); }
            
        }
        static void Teht5()
        {
            /* Tee ohjelma, joka nayttaa annetun sekuntimaaran tunteina, 
             * minuutteina ja sekunteina. Aikamaare sekuntteina kysytään kayttajalta. */
            int[] aika = new int[3];

            Console.Write("Anna sekuntit: ");
            int sek = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; ++i)
            {
                switch (i)
                {
                    case 0:
                        aika[i] = (sek / 3600);
                        sek -= aika[i];
                        break;
                    case 1:
                        aika[i] = (sek / 60);
                        sek -= aika[i];
                        break;
                    case 2:
                        aika[i] = sek;
                        break;
                }
            }

            Console.WriteLine("Tunteja: " + aika[0] + " Minuutteja: " + aika[1] + " Sekuntteja: " + aika[2]);
        }
    }
}
