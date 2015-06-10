using System;
using System.Globalization;
using System.Threading;

    class BeerTime
    {
        static void Main()
        {
            CultureInfo enUS = new CultureInfo("en-US");
            DateTime time;
            DateTime startTime = DateTime.Parse("1:00 PM");
            DateTime endTime = DateTime.Parse("3:00 AM");
            string dateString = Console.ReadLine();

            if (DateTime.TryParseExact(dateString, "h:mm tt", enUS,
                                        DateTimeStyles.None, out time))
            {
                if (time > startTime || time < endTime)
                {
                    Console.WriteLine("beer time");
                }
                else
                {
                    Console.WriteLine("non-beer time");
                }
            }
            else
            {
                Console.WriteLine("invalid time");
            }
        //    string time = Console.ReadLine();
        //    string formatingString = "hh:mm TT";
        //    DateTime beerTime = DateTime.ParseExact(time,formatingString,null);
       


            //DateTime beerTime = DateTime.Parse(Console.ReadLine());
            //string sign = beerTime.ToString("tt");

            //if ((beerTime.Hour >=3 && beerTime.Minute > 0) && (beerTime.Hour <=12 && beerTime.Minute <= 59))
            //{
            //    if (sign =="AM")
            //    {
            //        Console.WriteLine("non-beer time");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("beer time");
            //}

            //if (beerTime.Hour < 12)
            //{
            //    if (sign == "AM")
            //    {
            //        if (beerTime.Hour >= 3 && beerTime.Minute >= 0 && beerTime.Minute < 60)
            //        {
            //            Console.WriteLine("non-beer time");
            //        }
            //        else
            //        {
            //            Console.WriteLine("beer time");
            //        }
            //    }
            //}
            //else
            //{
            //    if (beerTime.Hour - 12 >= 1)
            //    {
            //        Console.WriteLine("beer time");
            //    }
            //    else
            //    {
            //        Console.WriteLine("non-beer time");
            //    }

            //}

        }
    }