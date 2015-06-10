using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("Enter integer \"n\" so that (1 < n < 100) : ");
            int n = int.Parse(Console.ReadLine());
            BigInteger catalanNumbers;
            BigInteger factorialN = 1;
            BigInteger factorialNp1 = 1;
            BigInteger factorialNt2 = 1;
            
            if (n > 1 && n < 100) //1 < n < 100
            {
                for (int i = 1; i <= n ; i++)
                {
                    factorialN *= i;
                }
                for (int i = 1; i <= (n + 1); i++)
                {
                    factorialNp1 *= i;
                }
                for (int i = 1; i <= (2 * n); i++)
                {
                    factorialNt2 *= i;   
                }
                catalanNumbers = factorialNt2 / (factorialNp1 * factorialN); //
                Console.WriteLine("Catalan number of \"n\" = {0}",catalanNumbers);
            }
            else if (n == 0) 
            {
                Console.WriteLine("Catalan number of \"0\" = 1");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            
        }
    }