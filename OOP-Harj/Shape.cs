using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    public abstract class Shape
    {
        public string Nimi { get; set; }
        public abstract double Ala();
        public abstract double Ymparys();
    }
    public class Circle : Shape
    {
        public double Halkaisija { get; set; }
        public override double Ala()
        {
            double sade = Halkaisija / 2;
            return ((sade * sade) * Math.PI);
        }
        public override double Ymparys()
        {
            double sade = Halkaisija / 2;
            return (2 * sade * Math.PI);
        }
    }
    public class Rectangle : Shape
    {
        public double Korkeus { get; set; }
        public double Leveys { get; set; }
        public override double Ala()
        {
            return (Leveys * Korkeus);
        }
        public override double Ymparys()
        {
            return ((Korkeus + Leveys) * 2);
        }
    }
}
