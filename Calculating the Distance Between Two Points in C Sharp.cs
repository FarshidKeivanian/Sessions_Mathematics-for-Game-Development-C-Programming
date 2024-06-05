using System;

class Program
{
    static void Main()
    {
        double x1 = 1, y1 = 2, x2 = 4, y2 = 6;
        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine($"The distance between ({x1}, {y1}) and ({x2}, {y2}) is {distance}.");
    }

    static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}
