using System;

    class PrintADeckOf52Cards
    {
        static void Main()
        {
            int card1 = 2;
            int card2 = 10;
            string[] card3 = { "J", "Q", "K", "A" };

            for (int i = 2; i >= card1 && i<=card2; i++)
            {
                Console.Write(@"{0}♠ {0}♥ {0}♣ {0}♦
",i);
            }
            for (int m = 0; m < card3.Length; m++)
            {
                Console.Write(@"{0}♠ {0}♥ {0}♣ {0}♦
", card3[m]);
            }
        }
    }
