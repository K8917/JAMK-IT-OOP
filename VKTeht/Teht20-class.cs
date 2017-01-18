using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKTeht
{
    class Teht20_class
    {
        private int i1_;
        private int i2_;

        public Teht20_class(int i1 = 1, int i2 = 2)
        {
            this.i1_ = i1;
            this.i2_ = i2;
        }

        public void SetI(int v, int v2)
        {
            i1_ = v;
            i2_ = v2;
        }

        public void Tulostus()
        {
            int summa = i1_ + i2_;
            Console.WriteLine("Numeroiden summa: " + i1_ + " + " + i2_ + " = " + summa);
        }
    }
}
