using System;

    class ThirdDigitIs7
    {
        static void Main()
        {
            int givenNum = Math.Abs(int.Parse(Console.ReadLine()));
            bool isSeven = (givenNum / 100) % 10 == 7;
            Console.WriteLine(isSeven);
        }
    }
