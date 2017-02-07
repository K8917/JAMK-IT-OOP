using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    // Harj 3.2
    public interface Jaakaappi
    {
        int Hinta { get; set; }
        string ViimKaytPvm { get; set; }
        string ToString();
    }
    public class Maito : Jaakaappi
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
    public class Liha : Jaakaappi
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
    public class Kananmuna : Jaakaappi
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
