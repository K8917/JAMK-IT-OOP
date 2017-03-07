using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    // Harj 3.2
    public interface IJaakaappi
    {
        int Hinta { get; set; }
        string ViimKaytPvm { get; set; }
        string ToString();
    }
    public class Maito : IJaakaappi
    {
        public int Hinta { get; set; }
        public string ViimKaytPvm { get; set; }
        public Maito() { }
        public Maito(int hinta, string vkpvm)
        {
            Hinta = hinta;
            ViimKaytPvm = vkpvm;
        }
        public override string ToString()
        {
            return "Maito, hinta: " + Hinta + ", Viimeinen kaytto pvm: " + ViimKaytPvm;
        }
    }
    public class Liha : IJaakaappi
    {
        public int Hinta { get; set; }
        public string ViimKaytPvm { get; set; }
        public Liha() { }
        public Liha(int hinta, string vkpvm)
        {
            Hinta = hinta;
            ViimKaytPvm = vkpvm;
        }
        public override string ToString()
        {
            return "Liha, hinta: " + Hinta + ", Viimeinen kaytto pvm: " + ViimKaytPvm;
        }
    }
    public class Kananmuna : IJaakaappi
    {
        public int Hinta { get; set; }
        public string ViimKaytPvm { get; set; }
        public Kananmuna() { }
        public Kananmuna(int hinta, string vkpvm)
        {
            Hinta = hinta;
            ViimKaytPvm = vkpvm;
        }
        public override string ToString()
        {
            return "Kananmuna, hinta: " + Hinta + ", Viimeinen kaytto pvm: " + ViimKaytPvm;
        }
    }
}
