namespace Utils
{
    using System;
    public class Test
    {
        public static void Main()
        {
            // ���������� 1
            int x, y, greater;
            Console.WriteLine("Please enter the first number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            y = int.Parse(Console.ReadLine());
            greater = Utils.Greater(x, y);
            Console.WriteLine("The greater value is " + greater);

            //���������� 2
            Console.WriteLine("Before swap: "+ x + "," + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("After swap: " + x + "," + y);

            //���������� 3
            bool ok;
            int f;
            int g = int.Parse(Console.ReadLine()); //��� ���������� x �� ���������� 3 �������� �� g � ����� � �������������� ���������� x � ���������� 1, 2
            ok = Utils.Factorial(g, out f);
            if (ok)
                Console.WriteLine("Factorial(" + g + ") = " + f);
            else
                Console.WriteLine("Cannot compute this factorial");
        }
    }
}
