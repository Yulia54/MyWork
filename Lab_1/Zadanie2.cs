using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public static class Zadanie2
    {
        public static double Function(double x)
        {
            if (x <= 0) throw new ArgumentOutOfRangeException("Логарифм не определен");
            if (x == 12) throw new DivideByZeroException("Деление на ноль");
            double rt = Math.Cos(Math.Pow(x, 3) - 13) * ((x - 9) / (x - 12));
            if (rt < 0) throw new Exception("Выражение под квадратным корнем не может быть отрицательным");
            return Math.Sqrt(rt)-Math.Pow(Math.E,Math.Log(x,2));
        }
    }
}
