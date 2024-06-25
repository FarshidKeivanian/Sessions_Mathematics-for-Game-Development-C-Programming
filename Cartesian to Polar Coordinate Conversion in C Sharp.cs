using System;

public class CoordinateConverter
{
    public static void CartesianToPolar(double x, double y, out double r, out double theta)
    {
        r = Math.Sqrt(x * x + y * y);  // Calculate the radius
        theta = Math.Atan2(y, x);      // Calculate the angle in radians
        theta = theta * (180.0 / Math.PI); // Convert radians to degrees
    }

    public static void Main()
    {
        double x = 3.0;
        double y = 4.0;
        double r, theta;

        CartesianToPolar(x, y, out r, out theta);
        Console.WriteLine("Polar Coordinates: Radius = {0}, Theta = {1} degrees", r, theta);
    }
}
