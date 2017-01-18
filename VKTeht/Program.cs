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
            Teht15();
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
                        sek -= (aika[i] * 3600);
                        break;
                    case 1:
                        aika[i] = (sek / 60);
                        sek -= (aika[i] * 60);
                        break;
                    case 2:
                        aika[i] = sek;
                        break;
                }
            }

            Console.WriteLine("Tunteja: " + aika[0] + " Minuutteja: " + aika[1] + " Sekuntteja: " + aika[2]);
        }
        static void Teht6()
        {
            /* Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. 
             * Tee ohjelma, joka tulostaa ajetulla matkalla (kysytaan kayttajalta) kuluvan bensan maaran 
             * seka bensaan menevan rahan maaran. */
            double litraKm = (7.02 / 100);
            double bHinta = 1.595;

            Console.Write("Kuinka paljon ajetaan: ");
            int km = int.Parse(Console.ReadLine());

            Console.WriteLine("Bensaa kuluu " + (litraKm * km).ToString("#.##") + " Litraa ja se maksaa " + (litraKm*km*bHinta).ToString("#.##") + " Euroa.");
        }
        static void Teht7()
        {
            Console.Write("Anna vuosi: ");
            int y = int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(y))
            {
                Console.WriteLine("Karkausvuosi");
            }
            else
            {
                Console.WriteLine("Ei Karkausvuosi");
            }
        }
        static void Teht8()
        {
            uint[] num = new uint[3];

            Console.Write("Anna kolme lukua: ");
            for (int i = 0; i < 3; ++i)
            {
                num[i] = uint.Parse(Console.ReadLine());
            }

            Console.WriteLine("Isoin luku: {0}", (num.Max()));
        }
        static void Teht9()
        {
            int luku = new int();
            int summa = new int();
            do
            {
                Console.Write("Anna luku: ");
                luku = int.Parse(Console.ReadLine());

                summa += luku;

            } while (luku != 0);

            Console.WriteLine("Lukujen summa: {0}", summa);
        }
        static void Teht10()
        {
            int[] arvot = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for (int i = 0; i < arvot.Length; ++i)
            {
                if (arvot[i] % 2 == 0)
                {
                    Console.WriteLine("{0}: HEP", arvot[i]);
                }
            }
        }
        static void Teht11()
        {
            Console.Write("Kuinka korkea: ");
            uint luku = uint.Parse(Console.ReadLine());

            for (uint i = 1; i < luku+1; ++i)
            {
                for (uint j = 0; j < i; ++j)
                {
                    Console.Write("*");
                }
                Console.Write('\n');
            }
        }
        static void Teht12()
        {
            string[] luvut = new string[5];
            Console.WriteLine("Anna viisi lukua: ");

            for (int i = 0; i < 5; ++i)
            {
                luvut[i] = Console.ReadLine();
            }

            Array.Reverse(luvut);
            Console.WriteLine("Luvut kaanteisessa jarjestyksessa: {0}, {1}, {2}, {3}, {4}", luvut);
        }
        static void Teht13()
        {
            uint[] arvostelut = new uint[5];
            uint summa = new uint();

            for (int i = 0; i < 5; ++i)
            {
                Console.Write("Arvostele hyppy: ");
                arvostelut[i] = uint.Parse(Console.ReadLine());
            }

            for (int j = 0; j < arvostelut.Length; ++j)
            {
                if (!(arvostelut[j] == arvostelut.Max() || arvostelut[j] == arvostelut.Min()))
                {
                    summa += arvostelut[j];
                }
            }

            Console.WriteLine("Summa: {0}", summa);
        }
        static void Teht14()
        {
            uint[] num = new uint[6];
            uint luku = new uint();

            Console.WriteLine("Lopeta antamalla 6");

            do
            {
                Console.Write("Anna arvosana (0-5): ");
                luku = uint.Parse(Console.ReadLine());
                
                if (luku >= 0 && luku <= 5)
                {
                    ++num[luku];
                }

            } while (luku != 6);

            for (int i = 0; i < num.Length; ++i)
            {
                Console.Write("{0}: ", i);
                for (int j = 0; j < num[i]; ++j)
                {
                    Console.Write("*");
                }
                Console.Write('\n');
            }
        }
        static void Teht15()
        {
            Console.Write("Puun korkeus: ");
            uint luku = uint.Parse(Console.ReadLine());
            int x = 0;

            for (int h = 1; h < luku-1; ++h)
            {
                for (int s = 0; s < luku-h-2; ++s)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < h+x; ++j)
                {
                    Console.Write("*");
                }
                x += 1;

                Console.Write('\n');
            }

            for (int j = 0; j < 2; ++j)
            {
                for (int t = 0; t < x-1; ++t)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
        }
        static void Teht16()
        {
            Random rnd = new Random();
            int rand = rnd.Next(0, 100);
            int arvaus = new int();
            int arvaukset = new int();

            do
            {
                Console.Write("Arvaa luku: ");
                arvaus = int.Parse(Console.ReadLine());
                
                if (arvaus < rand)
                {
                    Console.WriteLine("Luku on isompi");
                }
                else if (arvaus > rand)
                {
                    Console.WriteLine("Luku on pienempi");
                }
                ++arvaukset;
            } while (arvaus != rand);

            Console.WriteLine("Arvasit luvun {0} kerralla", arvaukset);
        }
        static void Teht17()
        {
            int[] num1 = { 10, 20, 30, 40, 50 };
            int[] num2 = { 5, 15, 25, 35, 45, 55 };

            Console.WriteLine("Luvut taulukossa 1: " + num1[0] + ", " + num1[1] + ", " + num1[2] + ", " + num1[3] + ", " + num1[4]);
            Console.WriteLine("Luvut taulukossa 2: " + num2[0] + ", " + num2[1] + ", " + num2[2] + ", " + num2[3] + ", " + num2[4]);

            int[] numA = new int[num1.Length + num2.Length];

            Array.Copy(num1, numA, num1.Length);
            Array.Copy(num2, 0, numA, num1.Length, num2.Length);

            Array.Sort(numA);
            Console.Write("Yhdistetyt numerot jarjestyksessa: ");
            for (int i = 0; i < numA.Length; ++i)
            {
                Console.Write(numA[i]);
                if (i < numA.Length-1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write('\n');

        }
        static void Teht18()
        {
            Console.Write("Kirjoita sana: ");
            string sana = Console.ReadLine();

            sana = sana.Substring(0, sana.Length);
            char[] sana2 = sana.ToCharArray();

            Array.Reverse(sana2);
            string tmp = new string(sana2);
           
            if (tmp.Equals(sana))
            {
                Console.WriteLine("Sana on palindromi");
            }
            else
            {
                Console.WriteLine("Sana ei ole palindromi");
            }
        }
        static void Teht19()
        {
            string[] sana1 = { "A", "r", "v", "a", "a" };
            string[] sana2 = { "_", "_", "_", "_", "_" };

            string tmp;
            string tmp2;

            bool x = new bool();
            do
            {
                x = false;

                Console.Write("Arvaa kirjain: ");
                string k = Console.ReadLine();

                int ind = Array.IndexOf(sana1, k);

                if (ind > -1)
                {
                    sana2[ind] = sana1[ind];
                    sana1[ind] = "";
                    Console.WriteLine("{0} {1} {2} {3} {4}", sana2);
                }

                tmp = String.Join("", sana1);
                        
                if (tmp.Equals(""))
                {
                    x = true;
                }
                
            } while (!(x));
        }
        static void Teht20()
        {

        }
    }
}
