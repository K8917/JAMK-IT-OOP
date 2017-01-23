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
        private uint temp_;
        private uint steam_;

        public Kiuas ()
        {
            this.onOff_ = false;
            this.temp_ = 0;
            this.steam_ = 0;
        }

        public Kiuas(uint temp, uint steam)
        {
            this.temp_ = temp;
            this.steam_ = steam;
        }

        public bool TurnOnOff()
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

            return this.onOff_;
        }

        public void SetTemp(uint temp)
        {
            this.temp_ = temp;
        }

        public void SetSteam(uint steam)
        {
            this.steam_ = steam;
        }

        public void PrintInfo()
        {
            string tmp;
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

            Console.WriteLine("Lampotila: " + this.temp_ + "'C, Vesihoyry: " + tmp);
        }
    }
}
