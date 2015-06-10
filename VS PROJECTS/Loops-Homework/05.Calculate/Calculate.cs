using System;
using System.Linq;
//S = 1 + 1!/x + 2!/x2 + … + n!/xn
    class Calculate
    {
        static void Main()
        {
            Console.WriteLine("Enter number \"n\" :");
            double n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number \"x\" :");
            double x = int.Parse(Console.ReadLine());
            double resultX = 1;
            double factorialN = 1;
            double s = 1;
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                resultX *= x;
                s += (factorialN / resultX);
            }
            Console.WriteLine("S = {0:F5}",s); // F5 so that n,0 0 0 0 0 

        }
    }
