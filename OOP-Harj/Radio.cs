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
        private int freq_;

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
        public int Volume
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
        public int Freq
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
    }
}
