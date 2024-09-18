using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public static class Zadanie3
    {
        public static List<int> Fibonacci(uint n)
        {
            List<int> list = new List<int>();
            int a = 0;
            int b = 1;
            list.Add(a);
            while(b<=n)
            {
                list.Add(b);
                int sum=a+b;
                a = b;
                b = sum;
            }
            return list;
        }
    }
}
