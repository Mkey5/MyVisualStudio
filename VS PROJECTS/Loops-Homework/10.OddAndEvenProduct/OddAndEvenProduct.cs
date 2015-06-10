using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class OddAndEvenProduct
    {
        static void Main()
        {
            Console.WriteLine(@"Enter ""n"" integers to check whether the product of the odd elements is equal to the product of the even elements!
Enter the numbers given in a single line, separated by a space :");
            string[] numbers = Console.ReadLine().Split(' ');
            if (numbers.Length == 4)
            {
                int a = int.Parse(numbers[0]);
                int b = int.Parse(numbers[1]);
                int c = int.Parse(numbers[2]);
                int d = int.Parse(numbers[3]);
                int odd = a * c;
                int even = b * d;
                if (odd == even)
                {
                    Console.WriteLine(@"Yes!
product = {0}",odd );
                }
                else
                {
                    Console.WriteLine(@"No!
odd_product = {0}
even_product = {1}",odd,even);
                }
            }
            else if (numbers.Length == 5)
            {
                int a = int.Parse(numbers[0]);
                int b = int.Parse(numbers[1]);
                int c = int.Parse(numbers[2]);
                int d = int.Parse(numbers[3]);
                int e = int.Parse(numbers[4]);
                int odd = a * c * e;
                int even = b * d;
                if (odd == even)
                {
                    Console.WriteLine(@"Yes!
product = {0}", odd);
                }
                else
                {
                    Console.WriteLine(@"No!
odd_product = {0}
even_product = {1}", odd, even);
                }
            }
            else if (numbers.Length == 6)
            {
                int a = int.Parse(numbers[0]);
                int b = int.Parse(numbers[1]);
                int c = int.Parse(numbers[2]);
                int d = int.Parse(numbers[3]);
                int e = int.Parse(numbers[4]);
                int f = int.Parse(numbers[5]);
                int odd = a * c * e;
                int even = b * d * f;
                if (odd == even)
                {
                    Console.WriteLine(@"Yes!
product = {0}", odd);
                }
                else
                {
                    Console.WriteLine(@"No!
odd_product = {0}
even_product = {1}", odd, even);
                }
            }
        }
    }
