using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Треугольники
{

    /*
     * Два треугольника заданы длинами своих сторон. 
     * Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).  
     * Для решения задачи можно использовать формулу Герона  S= sqrt(p*(p-x)(p-y)(p-z))
     * , где x, y, z – стороны треугольника, p – полупериметр.
     */
    class Program
    {
        static void Main(string[] args)
        {
            // т.к. стороны треугольника могут быть не только целыми числами, поэтуму используется тип данных double
            double aX, aY, aZ, bX, bY, bZ;

            inPutData("Введите стороны для треугольника A", out aX, out aY, out aZ);
            Console.WriteLine();
            inPutData("Введите стороны для треугольника B", out bX, out bY, out bZ);

            double aS = 0,
                bS = 0;

            GetParam(aX, aY, aZ, out aS);
            GetParam(bX, bY, bZ, out bS);
            string str1, str2;
            if (aS > bS)
            {
                str1 = "A";
                str2 = "B";
            }
            else
            {
                str1 = "B";
                str2 = "A";
            }
            Console.WriteLine();
            Console.WriteLine("Площадь треугольника {0} больше, чем площадь треугольника {1}", str1, str2);
            Console.ReadKey();
        }

        static void inPutData(string str, out double x, out double y, out double z)
        {
            Console.WriteLine(str);
            Console.Write("Введите сторону x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону z: ");
            z = Convert.ToDouble(Console.ReadLine());
        }

        static void GetParam(double x, double y, double z, out double S)
        {
            double p = (x + y + z) / 2;
            S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        }
    }
}
