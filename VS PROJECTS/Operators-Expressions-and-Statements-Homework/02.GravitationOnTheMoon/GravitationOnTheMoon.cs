﻿using System;

    class GravitationOnTheMoon
    {
        static void Main()
        {
            double weightOnEarth = double.Parse(Console.ReadLine());
            double weightOnMoon = weightOnEarth * 0.17;
            Console.WriteLine(@"Weight on the Moon = {0}",weightOnMoon);
        }
    }
