using System;

public class Program
{
    public static void Main()
    {
        // Define the original point coordinates
        double x = 2.0, y = 3.0, z = 4.0;
        // Define scaling factors for each axis
        double Sx = 1.5, Sy = 2.0, Sz = 0.5;
        
        // Scale the point
        double newX = x * Sx;
        double newY = y * Sy;
        double newZ = z * Sz;
        
        // Output the original and scaled coordinates
        Console.WriteLine("Original point: ({0}, {1}, {2})", x, y, z);
        Console.WriteLine("Scaled point: ({0}, {1}, {2})", newX, newY, newZ);
    }
}
