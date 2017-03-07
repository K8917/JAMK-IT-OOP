using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    public class Noppa
    {
        public int Heita()
        {
            Random rnd = new Random();
            return rnd.Next(1,6);
        }
        public double HeitaPaljon(int maara)
        {
            Random rnd = new Random();
            List<int> avg = new List<int>();
            for (int i = 0; i < maara; ++i)
            {
                avg.Add(rnd.Next(1,6));
            }
            return avg.Average();
        }
        public List<int> HeitaPaljonParemmin(int maara)
        {
            Random rnd = new Random();
            List<int> avg = new List<int>();
            for (int i = 0; i < maara; ++i)
            {
                avg.Add(rnd.Next(1, 6));
            }
            return avg;
        }
    }
}
