using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    public abstract class Nisakas
    {
        public int Ika { get; set; }
        public abstract void Liiku();
    }
    public class Ihminen : Nisakas
    {
        public string Nimi { get; set; }
        public int Paino { get; set; }
        public int Pituus { get; set; }
        public override void Liiku()
        {
            Console.WriteLine("Liikun!");
        }
        public void Kasva()
        {
            ++Ika;
        }
    }
    public class Vauva : Ihminen
    {
        public string Vaippa { get; set; }
        public override void Liiku()
        {
            Console.WriteLine("Konttaan!");
        }
    }
    public class Aikuinen : Ihminen
    {
        public string Auto { get; set; }
        public override void Liiku()
        {
            Console.WriteLine("Kavelee!");
        }
    }
}
