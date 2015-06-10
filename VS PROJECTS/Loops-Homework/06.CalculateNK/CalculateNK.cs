using System;
using System.Linq;

    class CalculateNK
    {
        static void Main()
        {
            Console.WriteLine("Enter \"n!\" :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"k!\" :");
            int k = int.Parse(Console.ReadLine());
            int factorialN = 1;
            int factorialK = 1;
            if (1 < k && k < n && n < 100)
            {
                do
                {
                    if (n >= 1)
                    {
                        factorialN *= n;
                        n--;
                    }
                    if (k >= 1)
                    {
                        factorialK *= k;
                        k--;
                    }
                } while (n>0);
            }
            Console.WriteLine("N!/K! = {0}", factorialN / factorialK);
        }
    }