using System;

    class DivideBy7And5
    {
        static void Main()
        {
            int givenNum = int.Parse(Console.ReadLine());
            bool dividing = givenNum % 7 == 0 && givenNum % 7 == 0 && givenNum !=0;
            Console.WriteLine(dividing);
        }
    }
