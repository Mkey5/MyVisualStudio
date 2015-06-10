using System;

    class BooleanVariable
    {
        static void Main()
        {
            int male = 1;
            int female = 0;

            bool isFemale = male < female;
            Console.WriteLine("Am I a female: {0} !" , isFemale);
        }
    }

