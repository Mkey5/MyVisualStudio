using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class InsideTheBuilding
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            int y4 = int.Parse(Console.ReadLine());
            int x5 = int.Parse(Console.ReadLine());
            int y5 = int.Parse(Console.ReadLine());
            // x 1

            if ((x1>=0 && x1<= h*3 ) && (y1>=0 && y1<=h))
            {
                Console.WriteLine("inside");
            }
            else if ((x1>=0+h && x1<=0 + h*2) && (y1>=0+h && y1<=h*4))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }

            // x 2

            if ((x2 >= 0 && x2 <= h * 3) && (y2 >= 0 && y2 <= h))
            {
                Console.WriteLine("inside");
            }
            else if ((x2 >= 0 + h && x2 <= 0 + h * 2) && (y2 >= 0 + h && y2 <= h * 4))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }

            // x 3

            if ((x3 >= 0 && x3 <= h * 3) && (y3 >= 0 && y3 <= h))
            {
                Console.WriteLine("inside");
            }
            else if ((x3 >= 0 + h && x3 <= 0 + h * 2) && (y3 >= 0 + h && y3 <= h * 4))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
            
            // x 4

            if ((x4 >= 0 && x4 <= h * 3) && (y4 >= 0 && y4 <= h))
            {
                Console.WriteLine("inside");
            }
            else if ((x4 >= 0 + h && x4 <= 0 + h * 2) && (y4 >= 0 + h && y4 <= h * 4))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }

            // x 5

            if ((x5 >= 0 && x5 <= h * 3) && (y5 >= 0 && y5 <= h))
            {
                Console.WriteLine("inside");
            }
            else if ((x5 >= 0 + h && x5 <= 0 + h * 2) && (y5 >= 0 + h && y5 <= h * 4))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
