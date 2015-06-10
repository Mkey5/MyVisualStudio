using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Nums
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            for (int i = n; i <= m; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("{0:0.000}",i);
                }
                else if (i == 1)
                {
                    Console.WriteLine("{0:0.000}",i);
                }
                else if (i % 2 == 1)
                {
                    Console.WriteLine("{0:0.000}",(i*i));                    
                }
                else
                {
                    Console.WriteLine("{0:0.000}",(Math.Sqrt(i)));
                }
            }
        }
    }