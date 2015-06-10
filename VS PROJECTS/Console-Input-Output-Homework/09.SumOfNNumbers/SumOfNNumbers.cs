using System;

    class SumOfNNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter the number \"n\" and after that , enter \"n\" numbers:");
            int number = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < number; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine("The sum of the \"n\" numbers is = {0}",sum);
        }
    }
