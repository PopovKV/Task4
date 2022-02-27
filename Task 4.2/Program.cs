using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int c1 = 0, c2 = 0;
            int i = 1;
            Console.WriteLine("Введите последовательность чисел");
            do
            {
                i = Convert.ToInt32(Console.ReadLine());
                if (i > 0)
                {
                    c1 ++;
                }
                else
                {
                    if (i<0)
                    c2 ++;
                }
            } while (i != 0);
            if (c1 > c2)
            {
                Console.WriteLine("Положительных чисел в последовательности больше, чем отрицательных");
            }
            else
            {
                if (c1 == c2)
                {
                    Console.WriteLine("Количество положительных и отрицательных чисел в последовательности равно");
                }
                else
                {
                    Console.WriteLine("Отрицательных чисел в последовательности больше, чем положительных");
                }
            }
            Console.ReadKey();
        }
    }
}
