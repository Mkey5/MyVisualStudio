using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Problem
{
    class Program
    {
        static void Main()
        {
            int s = 1212;
            int[] helper = Array.ConvertAll(s.ToString().ToArray(), x => (int)x - 48);
            //int[] helper = s.ToString().Select(o => Convert.ToInt32(o)).ToArray();
            s = helper.Sum();
            Console.WriteLine(s);
                    
            
            
            //char[] arrayName = { 'P', 'a', 'n', 'a', 'y' , 'o', 't' };
            //char[] upperletters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            //char[] lowerletters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //int nameResult = 0;
            //for (int i = 0; i < arrayName.Length; i++) // "i" is for the name
            //{
            //    for (int m = 0; m < 26; m++)          // "m" is for the letter checking
            //    {
            //        bool helper = true;
            //        if (upperletters.Contains(arrayName[i]))
            //        {
            //            helper = false;
            //        }
            //        if (arrayName[i] == upperletters[m])
            //        {
            //            //nameResult += ((m + 1) * 2);    // the letter is Capital so we * by 2 ;)
            //            break;
            //        }
            //        else if (helper == true && arrayName[i] == lowerletters[m])
            //        {
            //            nameResult += (m + 1);         // the letter is lower case so we only +  Трябва да го накараш да брои и с малките букви!
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine(nameResult);
        }
    }
}
