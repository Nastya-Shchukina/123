using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double side;
            double angleInDegrees;
            Console.WriteLine("Введите сторону:");
            side = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите угол: ");
            angleInDegrees = double.Parse(Console.ReadLine());
            double angleInRadians = angleInDegrees * Math.PI / 180;
            Console.WriteLine(("Площадь ромба: " + (side * side * Math.Round(Math.Sin(angleInRadians), 2))));
            Console.WriteLine(("Периметр ромба: " + (side + side + side + side)));

            Console.ReadKey();