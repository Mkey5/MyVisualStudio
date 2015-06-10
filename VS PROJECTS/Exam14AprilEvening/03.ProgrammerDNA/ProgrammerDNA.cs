using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ProgrammerDNA
    {
        static void Main()
        {

            int numbLength = int.Parse(Console.ReadLine());
            char firstLetter = char.Parse(Console.ReadLine());
            char dot = '.';
            int blockSize = 7;
            int middle = blockSize / 2;
            int diff = 0;
            int diffCounter = 0;

            for (int counter = 0; counter < numbLength; counter++)
            {
                // for printing the block
                for (int i = 0; i < blockSize; i++)
                {
                    if (i >= middle - diff && i <= middle + diff)
                    {
                        Console.Write(firstLetter);
                        if (firstLetter == 'G')
                        {
                            firstLetter = 'A';
                        }
                        else
                        {
                            firstLetter++;
                        }

                    }
                    else
                    {
                        Console.Write(dot);
                    }
                    
                }
                if (diffCounter >= middle)
                {
                    diff--;   
                }
                else
                {
                    diff++;
                }
                
                diffCounter++;
                
                if (diffCounter == blockSize)
                {
                    diffCounter = 0;
                    diff++;
                }
                Console.WriteLine();
            }
        }
    }

//...B...
//..CDE..
//.FGABC.
//DEFGABC
//.DEFGA.
//..BCD..
//...E...
