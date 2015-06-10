using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class MatrixOfNumbers
    {
        static void Main()
        {
            //n (1 ≤ n ≤ 20)
            //n = 4:
            //1 2 3 4
            //2 3 4 5
            //3 4 5 6
            //4 5 6 7

            Console.Write("Enter integer \"n\" as that (1 <= n <= 20) : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int result1;
            int helper = 0;
            for (int i = 1; i <= n; i++)
            {
                result1 = i;
                Console.Write(i + " ");
            }
            for (int m = 0; m <= n - 2; m++) 
            {
                Console.WriteLine("");
                for (int k = 2 + m; k <= n + m + 1 ; k++) 
                {
                    helper += k;
                    Console.Write(k + " ");
                }
            }
            Console.WriteLine("");
        }
    }