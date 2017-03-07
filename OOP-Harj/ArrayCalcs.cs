using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harj
{
    class ArrayCalcs
    {
        public static double Sum(ref double[] temp)
        {
            double result = temp.Sum();
            return result;
        }
        public static double Average(ref double[] temp)
        {
            double result = temp.Average();
            return result;
        }
        public static double Min(ref double[] temp)
        {
            double result = temp.Min();
            return result;
        }
        public static double Max(ref double[] temp)
        {
            double result = temp.Max();
            return result;
        }
    }
}
