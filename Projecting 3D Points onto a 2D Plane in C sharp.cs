using System;

public class Program
{
    public static void Main()
    {
        // Define the original 3D point coordinates
        double x = 3.0, y = 4.0, z = 5.0;
        
        // Project the point onto the 2D plane
        double newX = x;  // x-coordinate remains unchanged
        double newY = y;  // y-coordinate remains unchanged
        
        // Output the original 3D point and the projected 2D coordinates
        Console.WriteLine("Original 3D point: ({0}, {1}, {2})", x, y, z);
        Console.WriteLine("Projected 2D point: ({0}, {1})", newX, newY);
    }
}
