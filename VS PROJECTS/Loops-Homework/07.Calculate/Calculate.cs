using System;
using System.Linq;
using System.Numerics;
    class Calculate
    {
        static void Main()
        {
            Console.WriteLine("Enter \"n\" :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"k\" :");
            int k = int.Parse(Console.ReadLine());
            int nk1 = n;
            int nk2 = k;
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            BigInteger factorialNK = 1;
            if (1 < k  &&  k < n  &&  n < 100)
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
                } while (n > 0);

                for (int i = 2; i <= (nk1 - nk2); i++)
                {
                    factorialNK *= i;
                }
                BigInteger result = factorialN / (factorialK * factorialNK);
                Console.WriteLine("n! / (k! * (n-k)!)= {0}", result);    
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
