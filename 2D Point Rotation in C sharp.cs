using System;

public class PointRotator
{
    public static void RotatePoint(double x, double y, double angleDegrees, out double xPrime, out double yPrime)
    {
        double angleRadians = angleDegrees * (Math.PI / 180.0); // Convert angle to radians
        xPrime = x * Math.Cos(angleRadians) - y * Math.Sin(angleRadians); // Calculate new x
        yPrime = x * Math.Sin(angleRadians) + y * Math.Cos(angleRadians); // Calculate new y
    }

    public static void Main()
    {
        double x = 1.0;
        double y = 0.0;
        double xPrime, yPrime;

        RotatePoint(x, y, 90, out xPrime, out yPrime); // Rotate point by 90 degrees
        Console.WriteLine("New coordinates after rotation: x' = {0}, y' = {1}", xPrime, yPrime);
    }
}
