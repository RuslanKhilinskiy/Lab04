namespace Utils
{
    using System;
    using System.ComponentModel.Design;

    public class Utils
    {
        // упражнение 1
        public static int Greater (int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        //упражнение 2
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        //упражнение 3
        public static bool Factorial( int n, out int answer)
        {
            int k, f;
            bool ok = true;
            if (n < 0)
                ok = false;
            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)
            {
                f = 0;
                ok = false;
            }
            answer = f;
            return ok;
        }
    }
}
