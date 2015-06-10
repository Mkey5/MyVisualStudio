using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class RockLq
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char theStar = '*';
            char theDot = '.';
            int borderingSpacing = n;
            int midle = n;
            //string dot = new string(theDot, borderingSpacing);
            //string star = new string(theStar, midle);
            string firstDots = new string(theDot,n);
            string firstStars = new string(theStar,n);
            Console.WriteLine(firstDots + firstStars + firstDots);
            int helper = 0;
            int helper2 = n - 2;
            for (int i = 2; helper2>0; i+=2)
			{
                string dot1 = new string ( theDot,n-i);
                string dot2 = new string (theDot,n+i+helper);
                helper+=2;
                Console.WriteLine(dot1+"*"+dot2+"*"+dot1);
                helper2-=2;
			}
            if (n == 5)
            {
                string dot11 = new string(theDot, n - 2);
                string dot22 = new string(theDot, n);
                Console.WriteLine("*"+dot11+"*"+dot22+"*"+dot11+"*");
            }
            else
            {
                int m = n - 2;
                int k = 0;
                for (int i = 0; m+1 > 0; i+=2) // m+1
                {
                    if (m == n - 2)
                    {
                        string dotT1 = new string(theDot, n - 2);
                        string dotT2 = new string(theDot, n);
                        Console.WriteLine("*" + dotT1 + "*" + dotT2 + "*" + dotT1 + "*");
                        m -= 2;
                    }
                    else
                    {
                        string DOT1 = new string(theDot, n - (2 + i));
                        string DOT2 = new string(theDot, 1 + k);
                        string DOT3 = new string(theDot, n);
                        Console.WriteLine("*"+DOT1+"*"+DOT2+"*"+DOT3+"*"+DOT2+"*"+DOT1+"*");
                        k += 2;
                        m-=2;
                    }  
                }
            }
            int b = 1;
            int c = 0;
            for (int i = 0; i < n-1; i++)
            {
                string dot = new string(theDot, n - b);
                string dot2 = new string(theDot, n + c);
                b++;
                c+=2;
                Console.WriteLine(dot+"*"+dot2+"*"+dot);
            }
            string stars = new string(theStar, n * 3);
            Console.WriteLine(stars);
                    
        }
    }