using System;

public class Program
{
    public static void Main()
    {
        // Define the original point
        double x = 1.0, y = 1.0;
        
        // Define the transformation parameters
        double angleDegrees = 45.0;
        double scale = 2.0;
        double tx = 5.0, ty = 3.0;
        
        // Convert angle to radians
        double angleRadians = angleDegrees * Math.PI / 180.0;
        
        // Create the transformation matrices
        double[,] rotation = {
            {Math.Cos(angleRadians), -Math.Sin(angleRadians)},
            {Math.Sin(angleRadians), Math.Cos(angleRadians)}
        };
        
        double[,] scaling = {
            {scale, 0},
            {0, scale}
        };
        
        double[,] translation = {
            {1, 0, tx},
            {0, 1, ty},
            {0, 0, 1}
        };
        
        // Apply rotation and scaling first (2D point to 2D matrix multiplication)
        double newX = rotation[0, 0] * x + rotation[0, 1] * y;
        double newY = rotation[1, 0] * x + rotation[1, 1] * y;
        newX *= scale;
        newY *= scale;
        
        // Apply translation (switch to homogeneous coordinates for translation)
        newX += tx;
        newY += ty;
        
        // Output the transformed point
        Console.WriteLine("Transformed point: ({0}, {1})", newX, newY);
    }
}
