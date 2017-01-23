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
            Kiuas k1 = new Kiuas(10, 5);
            int valinta = new int();

            do
            {
                Console.Write("\n[1] Laita kiuas paalle/pois paalta\n" +
                    "[2] Lisaa lampotilaa\n" +
                    "[3] Lisaa vesihoyrya\n" +
                    "[4] Tulosta kiukaan tiedot\n" +
                    "[5] Lopeta\n");

                valinta = int.Parse(Console.ReadLine());

                switch (valinta)
                {
                    case 5:
                        break;
                    case 1:
                        k1.TurnOnOff();
                        break;
                    case 2:
                        Console.Write("Kuinka paljon lisataan lampotilaa: ");
                        k1.SetTemp(uint.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.Write("Kuinka paljon lisataan vesihoyrya: ");
                        k1.SetSteam(uint.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        k1.PrintInfo();
                        break;
                }

            } while (valinta != 5);
        }
    }
}
