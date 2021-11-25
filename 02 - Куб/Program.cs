using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Куб
{
    /*
     * Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
     */
    class Program
    {
        static void Main(string[] args)
        {
            // т.к. стороны куба могут быть не только целыми числами, поэтуму используется тип данных double
            double r;
            Console.Write("Введите длину ребра куба: ");
            r = Convert.ToDouble(Console.ReadLine());


            double S = 0,
                V = 0;

            GetParam(r, out S, out V);

            Console.WriteLine();
            Console.WriteLine("Площадь поверхности куба {0} ", S);
            Console.WriteLine("Объем поверхности куба {0} ", V);
            Console.ReadKey();
        }


        static void GetParam(double x, out double S, out double V)
        {
            V = Math.Pow(x, 3);
            S = 6 * Math.Pow(x, 2);
        }
    }
}
