using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testim4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательно 9 чисел");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int g = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());



            double answer = mathf(a, b, c) + mathf(d, e, f) + mathf(g, h, i);
            Console.WriteLine(answer);
        }
        public static double mathf(double x, double y, double z)
        {
            return (Math.Sqrt((x + Math.Tan(y) * Math.Tan(y)) / z));
        }
    }
}

