using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class RandomizeTheNumbers1toN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write(random.Next(1,n) + " ");
            }

        }
    }
