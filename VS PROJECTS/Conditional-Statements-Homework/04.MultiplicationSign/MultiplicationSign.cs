using System;

    class MultiplicationSign
    {
        static void Main()
        {
            Console.WriteLine("Enter 3 numbers to see what would be their sign if they were multiplied.");
            Console.Write("Enter number a : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter number b : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter number c : ");
            double c = double.Parse(Console.ReadLine());
            object sign;
            if (a==0 || b==0 || c==0)
            {
                sign = "0";
            }
            else
            {
                if (a<0)
                {
                    if (b>0 && c>0)
                    {
                        sign = "-";
                    }
                    else if (b<0 && c<0)
                    {
                        sign = "-";
                    }
                    else
                    {
                        sign = "+";
                    }
                }
                else
                {
                    if (b > 0 && c > 0)
                    {
                        sign = "+";
                    }
                    else if (b < 0 && c < 0)
                    {
                        sign = "+";
                    }
                    else
                    {
                        sign = "-";
                    }
                }
            }
            Console.WriteLine("The sign of the 3 numbers is: {0}",sign);
        }
    }
