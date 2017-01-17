using System;

namespace Teht1
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
