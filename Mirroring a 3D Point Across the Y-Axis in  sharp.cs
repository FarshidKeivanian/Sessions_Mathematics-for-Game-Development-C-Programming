using System;

public class Program
{
    public static void Main()
    {
        // Define the original 3D point coordinates
        double x = 3.0, y = 4.0, z = 5.0;
        
        // Mirror the point across the Y-axis
        double mirroredX = -x;  // Invert the x-coordinate
        double mirroredY = y;   // y-coordinate remains unchanged
        double mirroredZ = -z;  // Invert the z-coordinate
        
        // Output the original 3D point and the mirrored coordinates
        Console.WriteLine("Original 3D point: ({0}, {1}, {2})", x, y, z);
        Console.WriteLine("Mirrored 3D point across the Y-axis: ({0}, {1}, {2})", mirroredX, mirroredY, mirroredZ);
    }
}
