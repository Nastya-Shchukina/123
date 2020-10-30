using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x:");
            var x = double.Parse(Console.ReadLine());

            var y = F(x);

            Console.WriteLine("f(x) = " + y);
            Console.ReadKey();
        }

        static double F(double x)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Sqrt(Math.Pow(x, 2) + 1 / (Math.Pow(x, 2))));
        }
    }
}