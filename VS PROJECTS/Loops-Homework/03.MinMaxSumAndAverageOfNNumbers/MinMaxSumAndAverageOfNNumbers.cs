using System;
using System.Linq;

    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of \"n\" numbers you want to work with:");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0;i<length ; i++)
            {
                array[i] = int.Parse(Console.ReadLine());   
            }
            Console.WriteLine(@"min = {0}
max = {1}
sum = {2}
avg = {3}",array.Min(),array.Max(),array.Sum(),Math.Round(array.Average(),2));
        }
    }
