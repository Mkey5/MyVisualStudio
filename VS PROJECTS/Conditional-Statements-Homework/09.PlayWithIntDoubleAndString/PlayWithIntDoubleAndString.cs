using System;

    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Console.WriteLine(@"Please choose a type:
1 --> int
2 --> double
3 --> string");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": Console.WriteLine("Please enter a integer:");
                    int case1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(case1+1);
                    break;
                case "2": Console.WriteLine("Please enter a double:");
                    double case2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(case2+1);
                    break;
                case "3": Console.WriteLine("Please enter a string:");
                    string case3 = Console.ReadLine();
                    Console.WriteLine("{0}*",case3);
                    break;
                default: Console.WriteLine("Invalid command!");
                    break;
            }
        }
    }
