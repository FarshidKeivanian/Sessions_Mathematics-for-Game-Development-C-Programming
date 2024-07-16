using System;

public class PolarToCartesian
{
    public static void Main(string[] args)
    {
        double r = 7;
        double theta = Math.PI / 6;

        double x = r * Math.Cos(theta);
        double y = r * Math.Sin(theta);

        Console.WriteLine("Cartesian Coordinates: ({0}, {1})", x, y);
    }
}
