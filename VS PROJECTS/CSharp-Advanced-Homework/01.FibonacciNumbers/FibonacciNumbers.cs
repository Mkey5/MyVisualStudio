using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// fn=Fn-1 + Fn-2 + . . . 

    class FibonacciNumbers
    {
        static void Fibonacci(int n , int a , int b)
        {
            if (n < 0)
            {
                Console.WriteLine("Invalid number \"n\":");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    int fibonacci = a;
                    a = b;
                    b = fibonacci + b;
                }
                Console.WriteLine("Fibonacci = {0}", b);
            }  
        }
        static void Main()
        {
            Console.WriteLine("Enter number \"n\" to see the Fubonacci numbes of \"n\" :");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            Fibonacci(n,a,b);

        }
    }
