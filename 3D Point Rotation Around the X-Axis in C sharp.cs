using System;

public class Program
{
    public static void Main()
    {
        // Define the original point coordinates
        double x = 1.0, y = 2.0, z = 3.0;
        // Angle of rotation in degrees
        double thetaDegrees = 45.0;
        
        // Convert angle to radians
        double theta = thetaDegrees * Math.PI / 180.0;
        
        // Apply the rotation matrix
        double newX = x;
        double newY = y * Math.Cos(theta) - z * Math.Sin(theta);
        double newZ = y * Math.Sin(theta) + z * Math.Cos(theta);
        
        // Output the new coordinates
        Console.WriteLine("Original point: ({0}, {1}, {2})", x, y, z);
        Console.WriteLine("New point after rotation: ({0}, {1}, {2})", newX, newY, newZ);
    }
}
