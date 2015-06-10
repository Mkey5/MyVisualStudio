using System;
using System.Linq; // this line gives you the opportunity of using "Contains" ;)

class CheckForAPlayCard
{
    static void Main()
    {
        Console.WriteLine("Enter a character to see if it is a valid card sing :");
        string[] cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string input = Console.ReadLine();
        Console.WriteLine(cards.Contains(input) ? "yes" : "no");
       
        //string isItACard = Console.ReadLine();
        //switch (isItACard)
        //{
        //    case "2": Console.WriteLine("Yes!");
        //        break;
        //    case "3": Console.WriteLine("Yes!");
        //        break;
        //    case "4": Console.WriteLine("Yes!");
        //        break;
        //    case "5": Console.WriteLine("Yes!");
        //        break;
        //    case "6": Console.WriteLine("Yes!");
        //        break;
        //    case "7": Console.WriteLine("Yes!");
        //        break;
        //    case "8": Console.WriteLine("Yes!");
        //        break;
        //    case "9": Console.WriteLine("Yes!");
        //        break;
        //    case "10": Console.WriteLine("Yes!");
        //        break;
        //    case "J": Console.WriteLine("Yes!");
        //        break;
        //    case "Q": Console.WriteLine("Yes!");
        //        break;
        //    case "K": Console.WriteLine("Yes!");
        //        break;
        //    case "A": Console.WriteLine("Yes!");
        //        break;
        //    default: Console.WriteLine("No!");
        //        break;
        //}
    }
}