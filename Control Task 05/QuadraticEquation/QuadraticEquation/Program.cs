using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the coefficients of the quadratic equation (a, b, c):");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double x1, x2;
            double result = QuadraticEquation.CalculateRoots(a, b, c, out x1, out x2);
            
            if (result == 1)
            {
                Console.WriteLine($"Roots of the equation with coefficients a = {a}, b = {b}, c = {c} are different: x1 = {x1}, x2 = {x2}");
            }
            else if (result == 0)
            {
                Console.WriteLine($"The root of the equation with coefficients a = {a}, b = {b}, c = {c} is one: x1 = x2 = {x1}");
            }
            else
            {
                Console.WriteLine($"There are no roots of the equation with coefficients a = {a}, b = {b}, c = {c}.");
            }
        }
    }
}
