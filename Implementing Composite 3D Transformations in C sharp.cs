using System;

public class Program
{
    public static void Main()
    {
        // Define the original point coordinates
        double x = 1.0, y = 1.0, z = 1.0;
        
        // Transformation parameters
        double sx = 2.0, sy = 2.0, sz = 2.0; // Scaling factors
        double tx = 10.0, ty = 5.0, tz = 0.0; // Translation distances
        double angleDegrees = 90.0; // Rotation angle
        double angleRadians = angleDegrees * Math.PI / 180.0; // Convert to radians
        
        // Scaling matrix
        double[,] scaling = {
            {sx, 0, 0, 0},
            {0, sy, 0, 0},
            {0, 0, sz, 0},
            {0, 0, 0, 1}
        };
        
        // Rotation matrix around Z-axis
        double[,] rotationZ = {
            {Math.Cos(angleRadians), -Math.Sin(angleRadians), 0, 0},
            {Math.Sin(angleRadians), Math.Cos(angleRadians), 0, 0},
            {0, 0, 1, 0},
            {0, 0, 0, 1}
        };
        
        // Translation matrix
        double[,] translation = {
            {1, 0, 0, tx},
            {0, 1, 0, ty},
            {0, 0, 1, tz},
            {0, 0, 0, 1}
        };
        
        // Combine transformations: Translate * Rotate * Scale
        double[,] combined = MatrixMultiply(MatrixMultiply(translation, rotationZ), scaling);
        
        // Apply the combined transformation to the point
        double[] newPoint = MatrixMultiply(combined, new double[] {x, y, z, 1});
        
        // Output the transformed point
        Console.WriteLine("Transformed point: ({0}, {1}, {2})", newPoint[0], newPoint[1], newPoint[2]);
    }
    
    public static double[,] MatrixMultiply(double[,] a, double[,] b)
    {
        int aRows = a.GetLength(0);
        int aCols = a.GetLength(1);
        int bRows = b.GetLength(0);
        int bCols = b.GetLength(1);
        double[,] result = new double[aRows, bCols];
        
        for (int i = 0; i < aRows; i++)
            for (int j = 0; j < bCols; j++)
                for (int k = 0; k < aCols; k++)
                    result[i, j] += a[i, k] * b[k, j];
                    
        return result;
    }
    
    public static double[] MatrixMultiply(double[,] matrix, double[] vector)
    {
        double[] result = new double[vector.Length];
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < vector.Length; j++)
                result[i] += matrix[i, j] * vector[j];
        
        return result;
    }
}
