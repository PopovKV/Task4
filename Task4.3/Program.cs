using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число В");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число С");
            int C = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            int B1 = B;
            while (A >= C)
            {
                A += -C;
                while (B1>=C)
                {
                    B1 += -C;
                    k++;
                }
                B1 = B;                
            }
            Console.WriteLine("Количество квадратов со стороной С, в прямоугольнике со сторонами А и В = {0}", k);
            Console.ReadKey();
        }
    }
}
