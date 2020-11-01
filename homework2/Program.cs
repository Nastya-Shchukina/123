using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 100 до 999");
            int x, y, z, c;
            int n = int.Parse(Console.ReadLine());
            x = n / 100 * 100; //сотни
            y = n % 10 * 10; //десятки
            z = n / 10 % 10; //единицы
            c = z + y + x;
            Console.WriteLine("Исходное число:" + c);

            Console.ReadKey();
        }
    }
}
