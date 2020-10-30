using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "кинематограф";

            string word2 = word1.Substring(8, 4) + word1.Substring(7, 1) + word1.Substring(4, 3);
            Console.WriteLine("Первое полученное слово:" + word2);

            string word3 = word1.Substring(4, 1) + word1.Substring(3, 1) + word1.Substring(6, 1) + word1.Substring(9, 1) + word1.Substring(7, 1);
            Console.WriteLine("Второе полученное слово:" + word3);

            Console.ReadKey();
        }
    }
}
