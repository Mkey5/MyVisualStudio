using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BinaryToDecimalNumber

    {
        static void Main()
        {
            Console.WriteLine("Enter a number in its binary representation: ");
            string binary = Console.ReadLine();
            long dec = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - i - 1] == '0')
                {
                    continue;
                }

                dec += (long)Math.Pow(2, i);
            }

            Console.WriteLine(dec);
        }
    }
