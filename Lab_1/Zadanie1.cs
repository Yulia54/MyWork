using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public static class Zadanie1
    {
        public static ulong Factorial(uint n)
        {
            ulong fact = 1;
            for(uint i = 1; i <= n; i++) 
                fact *= i;
            return fact;
        }
    }
}
