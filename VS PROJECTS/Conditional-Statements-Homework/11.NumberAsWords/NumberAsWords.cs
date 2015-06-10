using System;

    class NumberAsWords
    {
        static void Main()
        {
            Console.Write("Please enter a number (0-999): ");
            int number = int.Parse(Console.ReadLine());

            string[] unitsMap = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve",
                            "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
            string[] tensMap = { "Zero", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string words = null;

            int hundreds = number / 100;
            int tens = number / 10 % 10;
            int units = number % 10;

            bool isZero = hundreds == 0 && tens == 0 && units == 0;

            if (number < 0 || number > 999)
            {
                Console.WriteLine("Invalid number. Enter a number from 0 to 999.");
            }
            else
            {
                if (isZero)
                {
                    words += unitsMap[units];
                }
                if (hundreds != 0 && tens >= 0 && units != 0)
                {
                    words += unitsMap[hundreds] + " hundred and ";
                }
                else if (hundreds != 0 && tens >= 0 && units == 0)
                {
                    words += unitsMap[hundreds] + " hundred and ";
                }
                else if (hundreds != 0 && tens == 0)
                {
                    words += unitsMap[hundreds] + " hundred ";
                }
                if (tens != 0)
                {
                    if (tens == 1)
                    {
                        words += unitsMap[units + 10] + " ";
                    }
                    else
                    {
                        words += tensMap[tens] + " ";
                        if (units != 0)
                        {
                            words += unitsMap[units];
                        }
                    }
                }
                if (units != 0 && tens == 0)
                {
                    words += unitsMap[units];
                }
                Console.WriteLine(words);
            }
        }
    }