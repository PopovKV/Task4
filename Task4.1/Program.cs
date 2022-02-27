using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N>0");
            int N = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i = 1; i <= N; i++)
            {
                a +=  2 * i - 1;
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}