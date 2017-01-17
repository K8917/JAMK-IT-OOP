// Ohjelma: Lotto

using System;
using System.Collections.Generic;


namespace Harjoitus2
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
