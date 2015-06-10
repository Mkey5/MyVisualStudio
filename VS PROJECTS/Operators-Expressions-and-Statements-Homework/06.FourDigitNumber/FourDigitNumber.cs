using System;

    class FourDigitNumber
    {
        static void Main()
        {
            int fDigitNum = int.Parse(Console.ReadLine());
            int d = fDigitNum % 10;
            int c = (fDigitNum / 10) % 10;
            int b = (fDigitNum / 100) % 10;
            int a = (fDigitNum / 1000) % 10;
            Console.WriteLine("Sum= "+(a+b+c+d));
            Console.WriteLine("dcba = {0}{1}{2}{3}",d,c,b,a);
            Console.WriteLine("dabc = {0}{1}{2}{3}",d,a,b,c);
            Console.WriteLine("acbd = {0}{1}{2}{3}",a,c,b,d);
        }
    }
