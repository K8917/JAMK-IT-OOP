using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    class Uuni
    {
        private bool uOnOff_;
        private int uTemp_;

        virtual public bool OnOff
        {
            get
            {
                return uOnOff_;
            } 
            set
            {
                uOnOff_ = value;
            }
        }
        virtual public int Temp
        {
            get
            {
                return uTemp_;
            }
            set
            {
                uTemp_ = value;
            }
        }

        public Uuni()
        {
            OnOff = false;
        }
        public Uuni(int temp, bool onOff)
        {
            OnOff = onOff;
            Temp = temp;
        }

        public string Tulosta(ref List<Levy> levyt)
        {
            string tmp = "";
            string tmp2 = "";

            if (OnOff)
            {
                tmp = "paalla";
            }
            else
            {
                tmp = "pois paalta";
            }

            tmp2 += "Uuni on " + tmp + ", lampotila on " + Temp + '\n';

            for (int i = 0; i < levyt.Count; ++i)
            {
                if (levyt[i].OnOff)
                {
                    tmp = "paalla";
                }
                else
                {
                    tmp = "pois paalta";
                }

                tmp2 += "Levy " + (i+1) + " on " + tmp + ", lampotila on " + levyt[i].Temp + '\n';
            }

            return tmp2;
        }
    }

    class Levy : Uuni
    {
        private bool lOnOff_;
        private int lTemp_;

        public override bool OnOff
        {
            get
            {
                return lOnOff_;
            }
            set
            {
                lOnOff_ = value;
            }
        }
        public override int Temp
        {
            get
            {
                return lTemp_;
            }
            set
            {
                lTemp_ = value;
            }
        }

        public Levy()
        {
            OnOff = false;
        }
        public Levy(int temp, bool onOff)
        {
            OnOff = onOff;
            Temp = temp;
        }
    }
}
