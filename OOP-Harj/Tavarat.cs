using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    class Tavarat
    {
        private string name_;
        public string Name
        {
            get
            {
                return name_;
            }
            set
            {
                name_ = value;
            }
        }

        public Tavarat() { }
        public Tavarat(string name)
        {
            Name = name;
        }

        public virtual string Tulosta()
        {
            return "Nimi: " + Name;
        }
    }

    class Kirja : Tavarat
    {
        private int sivut_;
        public int Sivut
        {
            get
            {
                return sivut_;
            }
            set
            {
                sivut_ = value;
            }
        }
        public Kirja() { }
        public Kirja(string name, int sivut)
            : base(name)
        {
            Sivut = sivut;
        }
        public override string Tulosta()
        {
            
            return "Luet kirjaa nimelta: " + base.Name + ", jossa on " + Sivut + " sivua.";
        }
    }

    class CDLevy : Tavarat
    {
        private int hinta_;
        public int Hinta
        {
            get
            {
                return hinta_;
            }
            set
            {
                hinta_ = value;
            }
        }
        public CDLevy() { }
        public CDLevy(string name, int hinta)
            : base(name)
        {
            Hinta = hinta;
        }
        public override string Tulosta()
        {
            return "Kuuntelet CD-levya nimelta: " + base.Name + ", joka maksaa " + Hinta + " euroa.";
        }
    }

    class Puhelin : Tavarat
    {
        private string malli_;
        public string Malli
        {
            get
            {
                return malli_;
            }
            set
            {
                malli_ = value;
            }
        }
        public Puhelin() { }
        public Puhelin(string name, string malli)
            : base(name)
        {
            Malli = malli;
        }
        public override string Tulosta()
        {
            return "Kaytat puhelinta nimelta " + base.Name + ", jonka malli on " + Malli;
        }
    }
}
