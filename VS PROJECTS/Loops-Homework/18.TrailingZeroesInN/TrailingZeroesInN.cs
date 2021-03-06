﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


    class TrailingZeroesInN
    {
        static void Main()
        {
            Console.Write("n = ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            BigInteger factN = 1;

            for (int i = 1; i <= n; i++)
            {
                factN *= i;
            }

            Console.WriteLine("trailing zeroes of n! = " + (n / 5));
            Console.WriteLine(factN);
        }
    }