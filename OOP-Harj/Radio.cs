using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    class Radio
    {
        private bool onOff_;
        private int vol_;
        private double freq_;

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
        public int Vol
        {
            get
            {
                return vol_;
            }
            set
            {
                vol_ = value;
            }
        }
        public double Freq
        {
            get
            {
                return freq_;
            }
            set
            {
                freq_ = value;
            }
        }

        public Radio() { }
        public Radio(int vol, double freq)
        {
            Vol = vol;
            Freq = freq;
        }

        public void TurnOnOff()
        {
            if (OnOff != false)
            {
                Console.WriteLine("Radio on pois paalta");
                OnOff = false;
            }
            else
            {
                Console.WriteLine("Radio on paalla");
                OnOff = true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vol">Volume has to be within range 0-9</param>
        public void ChangeVol(int vol)
        {
            if (vol >= 0 && vol <= 9)
            {
                Vol = vol;
            }
            else
            {
                Vol = 9;
                Console.WriteLine("Yritit kaantaa aanenvoimakkuuden " + vol + ", rikoit radion");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="freq">Freq has to be within range 2000.0-26000.0</param>
        public void ChangeFreq(double freq)
        {
            if (freq >= 2000.0 && freq <= 26000.0)
            {
                Freq = freq;
            }
            else
            {
                Freq = 2000.0;
                Console.WriteLine("Yritit kaantaa taajuuden " + freq + ", radiosta kuuluu kohinaa");
            }
        }
    }
}
