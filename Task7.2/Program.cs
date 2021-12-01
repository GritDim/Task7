using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
            double S, V;
            CalcSV(a, out S, out V);

            Console.WriteLine("Площадь поверхности куба {0}, его объем {1}", S,V);
            Console.WriteLine();
            Console.ReadKey();
        }

        static void CalcSV(int a, out double S, out double V)
        {
            S = a * a * 6;
            V = a * a * a;
            
        }
    }
}
