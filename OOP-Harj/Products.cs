using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    public interface Products
    {
        int Hinta { get; set; }
        string Nimi { get; set; }
    }
    public class Milk : Products
    {
        public int Hinta { get; set; }
        public string Nimi { get; set; }
        public Milk () { }
        public Milk (int hinta, string nimi)
        {
            Hinta = hinta;
            Nimi = nimi;
        }
    }
    public class Beer : Products
    {
        public int Hinta { get; set; }
        public string Nimi { get; set; }
        public Beer() { }
        public Beer(int hinta, string nimi)
        {
            Hinta = hinta;
            Nimi = nimi;
        }
    }
    public class Butter : Products
    {
        public int Hinta { get; set; }
        public string Nimi { get; set; }
        public Butter() { }
        public Butter(int hinta, string nimi)
        {
            Hinta = hinta;
            Nimi = nimi;
        }
    }
    public class Cheese : Products
    {
        public int Hinta { get; set; }
        public string Nimi { get; set; }
        public Cheese() { }
        public Cheese(int hinta, string nimi)
        {
            Hinta = hinta;
            Nimi = nimi;
        }
    }
}
