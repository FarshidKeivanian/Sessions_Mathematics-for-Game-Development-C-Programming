using System;

class Program
{
    static void Main()
    {
        double x1 = 1, y1 = 2, z1 = 3, x2 = 4, y2 = 5, z2 = 6;
        var midpoint = FindMidpoint3D(x1, y1, z1, x2, y2, z2);
        Console.WriteLine($"The midpoint between ({x1}, {y1}, {z1}) and ({x2}, {y2}, {z2}) is ({midpoint.Item1}, {midpoint.Item2}, {midpoint.Item3}).");
    }

    static (double, double, double) FindMidpoint3D(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double midX = (x1 + x2) / 2;
        double midY = (y1 + y2) / 2;
        double midZ = (z1 + z2) / 2;
        return (midX, midY, midZ);
    }
}
