using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину сторон первого треугольника");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите длину сторон второго треугольника");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            double s1 = CalcSquare(a1, b1, c1);
            double s2 = CalcSquare(a2, b2, c2);

            if (s1==s2)
            {
                Console.WriteLine("Площади треугольников равны");
            }
            else
            {
                if (s1 > s2)
                {
                    Console.WriteLine("Площадь первого треугольника больше");
                }
                else
                {
                    Console.WriteLine("Площадь второго треугольника больше");
                }
            }
           
            Console.WriteLine();
            Console.ReadKey();
        }


        static double CalcSquare(int a, int b, int c)
        {
            int p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }

    }
}
