using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    class Kello : Internet
    {
        private double minNyt_;
        private double sekNyt_;
        private double milSekNyt_;
        public double Minuutit
        {
            get
            {
                return minNyt_;
            }
            set
            {
                minNyt_ = value;
            }
        }
        public double Sekuntit
        {
            get
            {
                return sekNyt_;
            }
            set
            {
                sekNyt_ = value;
            }
        }
        public double Millisekuntit
        {
            get
            {
                return milSekNyt_;
            }
            set
            {
                milSekNyt_ = value;
            }
        }
        public Kello() { }
        public void HaeAika()
        {
            DateTime tmp = Aika();
            Minuutit = tmp.Minute;
            Sekuntit = tmp.Second;
            Millisekuntit = tmp.Millisecond;
        }
        public string Tulosta()
        {
            return "Aika: " + Minuutit + ":" + Sekuntit + ":" + Millisekuntit;
        }
    }

    class Internet
    {
        public Internet() { }
        public DateTime Aika()
        {
            return DateTime.Now;
        }
    }
}
