using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSquareMethod
{
    internal class Operation
    {
        public static double CalculateSquare(double a, double b, double c)
        {
            if (TriangeCheck(a, b, c))
            {
                //расчет полуперимета обычного треугольника
                double semiPerimeter = (a + b + c) / 2; 
                //расчет площади обычного треугольника
                double S = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c)); 
                return S;
            } else
            {
                Console.WriteLine("A triangle with such sides does not exist");
                return 0;
            }

        }
        private static bool TriangeCheck(double a, double b, double c)
        {
            bool checkTriangle = (a + b > c) && (a + c > b) && (b + c > a);
            return checkTriangle;
        }
        public static double CalculateSquare(double side)
        {
            if (TriangeCheck(side, side, side))
            {
                //расчет полуперимета равностороннего треугольника
                double semiPerimeter = (side + side + side) / 2; 
                //расчет площади равностороннего треугольника
                double S = Math.Sqrt(semiPerimeter * (semiPerimeter - side) * (semiPerimeter - side) * (semiPerimeter - side));
                return S;
            }
            else
            {
                return 0;
            }
        }
    }
}
