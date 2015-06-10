using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class MagicCarNumbers
    {
        static void Main()
        {
            int magicValue = int.Parse(Console.ReadLine());
            int[] xY = { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };
            int result = 0;

            for (int x = 0; x < xY.Length; x++)
            {
                for (int y = 0; y < xY.Length; y++)
                {
                    for (int a = 0; a <= 9; a++)
                    {
                        int weight = xY[0] + xY[2] + a + a + a + a + xY[x] + xY[y];
                        if (weight == magicValue)
                        {
                            result++;
                        }
                        for (int b = 0; b <= 9 ; b++)
                        {
                            if (b != a)
                            {
                                int weight2 = xY[0] + xY[2] + a + a + a + b + xY[x] + xY[y];
                                if (weight2 == magicValue)
                                {
                                    result++;
                                }
                                int weight3 = xY[0] + xY[2] + a + b + b + b + xY[x] + xY[y];
                                if (weight3 == magicValue)
                                {
                                    result++;
                                }
                                int weight4 = xY[0] + xY[2] + a + a + b + b + xY[x] + xY[y];
                                if (weight4 == magicValue)
                                {
                                    result++;
                                }
                                int weight5 = xY[0] + xY[2] + a + b + a + b + xY[x] + xY[y];
                                if (weight5 == magicValue)
                                {
                                    result++;
                                }
                                int weight6 = xY[0] + xY[2] + a + b + b + a + xY[x] + xY[y];
                                if (weight6 == magicValue)
                                {
                                    result++;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
