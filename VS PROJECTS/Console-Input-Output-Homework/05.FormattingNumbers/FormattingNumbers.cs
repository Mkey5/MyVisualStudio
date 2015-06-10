using System;

    class FormattingNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            string binaryA = Convert.ToString(a,2).PadLeft(10,'0'); 
            Console.WriteLine(@"|{0,-10}|{1}|{2,10:0.00}|{3,-10:0.000}|", a.ToString("X"),binaryA,b,c);
        }
    }