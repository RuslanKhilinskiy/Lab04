using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    internal class QuadraticEquation
    {
        public static double CalculateRoots (double a, double b, double c, out double x1, out double x2)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0) 
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                //найдено два различных корня
                return 1;
            }
            else if (discriminant == 0)
            {
                x1 = x2 = -b / (2 * a);
                //оба корня совпадают
                return 0;
            }
            else
            {
                x1 = x2 = 0;
                //корней нет
                return -1;
            }
        }
    }
}
