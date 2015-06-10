using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 70 of 100 in the judge system 

    class StudentCables
    {
        static void Main()
        {
            int numbOfCables = int.Parse(Console.ReadLine());
            int[] cableAll = new int[numbOfCables];
            for (int i = 0; i < numbOfCables; i++) 
            {
                int cableLength = int.Parse(Console.ReadLine());
                string measure = Console.ReadLine();
                if (measure == "meters")
                {
                    cableLength *= 100;
                    cableAll[i] = cableLength;
                }
                else if (cableLength >= 20)
                {
                    cableAll[i] = cableLength;
                }
            }
            
            cableAll = cableAll.Except(new int[] { 0 }).ToArray(); // this removes entries equal to 0
            
            int newCableLength = 0;
               
            for (int i = 0; i < cableAll.Length; i++)
            {
                newCableLength += cableAll[i];
            }

            int joiningCable = (cableAll.Length - 1) * 3;
            
            newCableLength -= joiningCable; 

            int result = newCableLength / 504;
            int remainder = newCableLength % 504;
            Console.WriteLine("{0}", result);
            Console.WriteLine("{0}", remainder);

        }
    }

