// Ohjelma: Nimet aakkosjarjestykseen

using System;

namespace Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
