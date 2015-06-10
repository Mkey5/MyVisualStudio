//
//13.You are asked to calculate whether Lelia Vanche can finish a project on time. You will be given the number of hours required 
//to finish the project, the days that Lelia Vanche has available for working (mind that she goes to biking in 10% of this time) 
//and her average productivity during the given period. Assume that a normal work day for Lelia Vanche has 12 hours. Note that 
//only the whole hours are taken (e.g. 6.98 hours is rounded down to 6 hours).
//
using System;

class Program
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        while (d >89478485)
        {
            Console.WriteLine("try again");
        }
        double p = double.Parse(Console.ReadLine());
        while (p >100)
        {
            Console.WriteLine("try again");
        }

        double actualWork = (((d - (d * 0.1)) * 12.0) * (p * 0.01));
    // double actualWork=((d - (d * (10 / 100.0))) * 12) * (p / 100.0);
        int result = (int)actualWork;
        {
            if (result < h)
            {
                Console.WriteLine("No");
                Console.WriteLine("-" + (h - result));
            }
            else if (result >= h)
            {
                Console.WriteLine("Yes");              
                Console.WriteLine(Math.Abs(h - result));
               
            }
        }
    }
}  
        

        
        

    