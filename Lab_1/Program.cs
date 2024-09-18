using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Задание 1. Факториал числа \n Введите число: ");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine(n + "! = " + Zadanie1.Factorial(n));

            Console.Write("Задание 2. Расчет функции \n Введите число: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Результат: " + Zadanie2.Function(x));

            Console.Write("Задание 3. Последовательность чисел Фибоначчи \n Введите число: ");
            uint N = uint.Parse(Console.ReadLine());
            Console.Write("Результат: ");
            List<int> list = Zadanie3.Fibonacci(N);
            foreach (int item in list)
                Console.Write(item + ", ");
            Console.WriteLine();

            Console.Write("Задание 4. Ряд Тейлора для cos(x) \n Введите число: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write(" Введите точность: ");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("cos("+m+") = "+Zadanie4.TailorSeries(m,t));

            Console.ReadLine();
        }
    }
}
