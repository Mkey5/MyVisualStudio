using System;

    class ModifyABitAtGivenPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive number \"n\" :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the specific bit position \"p\" :");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value \"v\" of the secific bit you want to change (0 or 1) :");
            int v = int.Parse(Console.ReadLine());
            if(v == 0)
            {
                n = n & ~ (1 << p);
            }
            else
            {
                n = n | (1 << p);
            }
            Console.WriteLine("This is the new number : {0}" ,n);
        }
    }
