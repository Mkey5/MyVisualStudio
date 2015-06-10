using System;
//Create a program that assigns null values to an integer and to a double variable. Try to print these variables 
//at the console. Try to add some number or the null literal to these variables and print the result.
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? someInteger = null;
            double? someDouble = null;
            Console.WriteLine(@"Integer with the nullable value - {0}
Double with the nullable value - {1}",someInteger,someDouble);
            someInteger = 5;
            someDouble = 2.5;
            Console.WriteLine(@"Integer with the new value - {0}
Double with the new value - {1}",someInteger,someDouble);
        }
    }
