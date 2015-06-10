using System;

class CurrentDateAndTime
{
    class Program
    {
        public DateTime HiringDate { get; set; }
    }

    static void Main()
    {
        //
        // Write the current date and time.
        //
        DateTime now = DateTime.Now;
        Console.WriteLine(now);

        //
        // Store a DateTime in a class.
        //
        Program employee = new Program() { HiringDate = now };
        Console.WriteLine(employee.HiringDate);
    }
}