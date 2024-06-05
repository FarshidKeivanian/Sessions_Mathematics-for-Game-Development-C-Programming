using System;

class Program
{
    static void Main()
    {
        double degrees = 90;
        double radians = DegreesToRadians(degrees);
        Console.WriteLine($"{degrees} degrees is equal to {radians} radians.");
    }

    static double DegreesToRadians(double degrees)
    {
        return degrees * (Math.PI / 180);
    }
}
