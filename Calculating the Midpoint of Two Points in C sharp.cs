using System;

class Program
{
    static void Main()
    {
        double x1 = 2, y1 = 3, x2 = 4, y2 = 7;
        var midpoint = FindMidpoint(x1, y1, x2, y2);
        Console.WriteLine($"The midpoint between ({x1}, {y1}) and ({x2}, {y2}) is ({midpoint.Item1}, {midpoint.Item2}).");
    }

    static (double, double) FindMidpoint(double x1, double y1, double x2, double y2)
    {
        double midX = (x1 + x2) / 2;
        double midY = (y1 + y2) / 2;
        return (midX, midY);
    }
}
