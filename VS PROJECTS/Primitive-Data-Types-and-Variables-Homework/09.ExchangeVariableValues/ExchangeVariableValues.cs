using System;
//Declare two integer variables a and b and assign them with 5 and 10 and 
//after that exchange their values by using some programming logic. 
//Print the variable values before and after the exchange.
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine(@"a = {0}
b = {1}",a,b);
            a = b = 10;
            Console.WriteLine(@"new a = {0}",a);
            b = a = 5;
            Console.WriteLine(@"new b = {0}",b);

        }
    }
