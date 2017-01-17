using System;


namespace Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisteet = new int();

            Console.Write("Anna pisteet: ");
            pisteet = int.Parse(Console.ReadLine());

            if (pisteet == 12)
            {
                --pisteet;
            }

            Console.WriteLine("Numero on {0}", (pisteet/2));
        }
    }
}
