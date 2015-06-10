using System;

    class FuelConsumptionCalculator
    {
        static void Main()
        {
            Console.WriteLine("Enter kilometers :");
            double km = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of fuel /in litres/ :");
            double fuel = double.Parse(Console.ReadLine());
            double fuelConsumption = 0.0;
            fuelConsumption = fuel / (km / 100);
            Console.WriteLine("The fuel consumption of your car is : {0} / 100 km",Math.Round(fuelConsumption,3));
            Console.WriteLine("TOSHKO ti si pich ! Nali taka ?");
            string toshko = Console.ReadLine();
        }
    }