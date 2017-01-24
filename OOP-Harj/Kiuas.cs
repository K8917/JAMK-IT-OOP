using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    class Kiuas
    {
        private bool onOff_;
        public uint temp_ { get; set; }
        public uint steam_ { get; set; }

        public Kiuas ()
        {
            onOff_ = false;
        }

        public Kiuas(uint temp = 0, uint steam = 0)
            : this()
        {
            temp_ = temp;
            steam_ = steam;
        }

        public void TurnOnOff()
        {
            if (this.onOff_ == false)
            {
                this.onOff_ = true;
                Console.WriteLine("Kiuas on paalla");
            }
            else
            {
                this.onOff_ = false;
                Console.WriteLine("Kiuas on pois paalta");
            }
        }

        public string PrintInfo()
        {
            if (onOff_ == false)
            {
                return "Kiuas ei ole paalla";
            }
            string tmp;
            string tmp2;
            if (this.steam_ < 33)
            {
                tmp = "Alhainen";
            }
            else if (this.steam_ < 66)
            {
                tmp = "Sopiva";
            }
            else
            {
                tmp = "Liikaa";
            }

            return tmp2 = "Lampotila: " + this.temp_ + "'C, Vesihoyry: " + tmp;
        }
    }
}
