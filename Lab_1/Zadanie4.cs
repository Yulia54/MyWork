using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public static class Zadanie4
    {
        public static double TailorSeries(double x, double n)
        {
            double cos = 0;
            int i = 0;
            double temp;
            do
            {
                temp= Math.Pow(-1, i) * Math.Pow(x, 2 * i) / Zadanie1.Factorial((uint)(2 * i));
                cos += temp;
                i++;
            }
            while (Math.Abs(temp)>n); 
            return cos;
        }
    }
}
