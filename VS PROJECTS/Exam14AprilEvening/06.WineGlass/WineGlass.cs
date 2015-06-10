using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class WineGlass
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char theStar = '*';
            char theDot = '.';
            int borderingSpacing = 0;
            int midle = n - 2;
            
            for (int i = 0; i < n; i++)
            {
                if (i < n/2)
                {
                    string dot = new string(theDot, borderingSpacing);
                    string star = new string(theStar, midle);
                    Console.WriteLine(dot + "\\" + star + "/" + dot);
                    borderingSpacing++;
                    midle -= 2;
                }
                else if ( n < 12 && i < n-1 || n>=12 && i < n -2 )
                {
                    string dot = new string(theDot, (n / 2) - 1);
                    Console.WriteLine(dot + "|" + "|" + dot);
                }
                else
                {
                    Console.WriteLine(new string('-',n));
                }
                
            }
        }
    }

