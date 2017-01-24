using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    class Televisio
    {
        private bool onOff_;
        private uint channel_;
        private uint volume_;
        public uint Volume
        {
            get
            {
                return volume_;
            }
            set
            {
                if (value > 100)
                {
                    volume_ = 100;
                }
                else
                {
                    volume_ = value;
                }
            }
        }
        public uint Channel
        {
            get
            {
                return channel_;
            }
            set
            {
                channel_ = value;
            }
        }
        public bool OnOff
        {
            get
            {
                return onOff_;
            }
            set
            {
                onOff_ = value;
            }
        }

        public Televisio()
        {
            OnOff = false;
        }

        public Televisio(uint channel, uint volume)
            : this()
        {
            Channel = channel;
            Volume = volume;
        }

        public string Tulosta()
        {
            if (OnOff == false)
            {
                return "Televisio on pois paalta.";
            }
            return "Kanava: " + Channel + ", Aanenvoimakkuus: " + Volume;
        }
    }
}
