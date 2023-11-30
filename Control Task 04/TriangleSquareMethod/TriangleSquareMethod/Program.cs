using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSquareMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose the type of triangle (1 - regular, 2 - equilateral): ");
            int triangleType = int.Parse(Console.ReadLine());

            if (triangleType == 1)
            {
                Console.WriteLine("Please enter values of triangle's sides.");
                Console.WriteLine("Please enter the first side value: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second side value: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the third side value: ");
                double c = double.Parse(Console.ReadLine());

                double squareResult = Operation.CalculateSquare(a, b, c);
                Console.WriteLine($"Triangle's square is: {squareResult}");
            }
            else if (triangleType == 2)
            {
                Console.WriteLine("Please enter the value of equilateral triangle's side: ");
                double side = double.Parse(Console.ReadLine());
                double eqSquareResult = Operation.CalculateSquare(side);
                Console.WriteLine($"Equilateral triangle's square is: {eqSquareResult}");
            }
            else
            {
                Console.WriteLine("Incorrect choice of triangle type.");
            }
        }
    }
}
