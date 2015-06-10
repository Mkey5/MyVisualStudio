using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            Random random = new Random();
            //Random rng = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(rng.Next(1, 101));
            //}
                
            for (int i = 0; i < n; i++)
            {
                Console.Write(random.Next(min,max) + " ");
            }
            
           
            
//Next(int minimum, int maximum);
//Next(int Maximum);
//where you can specify the minimum and maximum range between which you want the random number.

//Code snippet:

//Random random = new Random();
//int maxValue = 100;

//int r = random.Next(maxValue);

        }
    }