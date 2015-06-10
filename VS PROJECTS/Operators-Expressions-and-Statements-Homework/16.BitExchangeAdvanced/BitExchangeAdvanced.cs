using System;

    class BitExchangeAdvanced
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter positive number \"n\" :");
                uint n = uint.Parse(Console.ReadLine());
                Console.WriteLine("Enter specific bit position \"p\" :");
                uint p = uint.Parse(Console.ReadLine());
                Console.WriteLine("Enter specific bit position \"q\" :");
                uint q = uint.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of bits \"k\" that will be exchanged :");
                uint k = uint.Parse(Console.ReadLine());
                if (Math.Max(p, q) + k - 1 > 31)
                {
                    Console.WriteLine("Out of range!");
                }
                else if (Math.Min(p, q) + k - 1 >= Math.Max(p, q))
                {
                    Console.WriteLine("Overlapping!");
                }
                else
                {
                    for (int i = (int)p; i <= p + k - 1; i++)
                    {
                        uint mask = 1;
                        uint bitQ = (n & (mask << (int)q)) >> (int)q;
                        uint bitP = (n & (mask << (int)i)) >> (int)i;
                        n = n & ~(mask << (int)i);
                        n = n & ~(mask << (int)q);
                        n = n | (bitP << (int)q);
                        n = n | (bitQ << (int)i);
                        q++;
                    }
                    Console.WriteLine("The new number is : {0}", n);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Out of range!");
            }
        }
    }