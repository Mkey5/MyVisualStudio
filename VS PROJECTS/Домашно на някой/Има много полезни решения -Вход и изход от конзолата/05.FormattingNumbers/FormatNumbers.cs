//
//Problem 6. Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them
//in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal, 
//left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits
//after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned.
//
using System;
    class FormatNumbers
    {
        static void Main()
        {

            Console.WriteLine("Type in value for integer a: ");
            int a = int.Parse(Console.ReadLine());
            while ((a <= 0) || (a > 500))
            {
                Console.WriteLine("The number must be > 0 and <= 500. Try again");
                a = int.Parse(Console.ReadLine());
            }
         
            
            Console.WriteLine("Type in value for float b: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Type in value for float c: ");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("|{0,-10}|", a.ToString("X"));
            Console.Write(Convert.ToString(a, 2).PadLeft(10, '0'));
            Console.Write("|{0,10:0.00}|{1,-10:0.000}|", b, c );
            Console.WriteLine();
        }
    }
