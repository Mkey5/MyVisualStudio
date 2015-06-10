using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

    class Numerology
    {
        static void Main()
        {
            string[] info = Console.ReadLine().Split('.',' ');
            int numb1 = int.Parse(info[0]);
            int numb2 = int.Parse(info[1]);
            int numb3 = int.Parse(info[2]);
            string name = info[3];
            char[] upperletters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] numToCheck = {'0','1','2', '3' ,'4' , '5' , '6' , '7' , '8' , '9'};
            char[] arrayName = name.Substring(0, name.Length).ToArray();
            
            // firts calculate the date part
            BigInteger numberResult;
            if (numb2 != 0 && numb2 % 2 == 1)
            {
                numberResult = numb1 * numb2 * numb3;
                numberResult *= numberResult;
            }
            else
            {
                numberResult = numb1 * numb2 * numb3;
            }

            // secound calculating the name part
            int nameResult = 0;
            for (int i = 0; i < arrayName.Length; i++) // "i" is for the name
            {
                for (int m = 0; m < 26; m++)          // "m" is for the letter checking
                {
                    bool helper = true;
                    if (upperletters.Contains(arrayName[i]))
                    {
                        helper = false;
                    }
                    if (arrayName[i] == upperletters[m])
                    {
                        nameResult += ((m + 1) * 2);    // the letter is Capital so we * by 2 ;)
                        break;
                    }
                    else if (helper == true && arrayName[i] == lowerLetters[m])
                    {
                        nameResult += (m + 1);         // the letter is lower case so we only +  
                        break;
                    }
                    else if (numToCheck.Contains(arrayName[i])) // maybe here is the problem  ?!
                    {
                        for (int l = 0; l < numToCheck.Length; l++)
                        {
                            if (arrayName[i]== numToCheck[l])
                            {
                                nameResult += l;
                            }
                        }
                    }
                }
            }

            // third part
            BigInteger finalNumber = numberResult + nameResult;
            int[] forCalculations = Array.ConvertAll(finalNumber.ToString().ToArray(), x => (int)x - 48);
            int s = forCalculations.Sum();
            if (s>13)
            {
                do
                {
                    int[] helper = Array.ConvertAll(s.ToString().ToArray(), x => (int)x - 48);
                    s = helper.Sum();

                } while (s >= 13); 
                Console.WriteLine(s); 
                
            }
            else if (s<=13 && s>=0)
            {
                Console.WriteLine(s);
            }
        }
    }
