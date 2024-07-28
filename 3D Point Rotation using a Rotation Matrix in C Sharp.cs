using System;

class Program
{
    static void Main()
    {
        // Original point
        double[] P = { 1, 1, 1 };

        // Rotation matrix for 90 degrees around Z-axis
        double[,] Rz = {
            { 0, -1, 0 },
            { 1, 0, 0 },
            { 0, 0, 1 }
        };

        // New point after rotation
        double[] P_new = RotatePoint(P, Rz);

        Console.WriteLine($"New coordinates after rotation: ({P_new[0]}, {P_new[1]}, {P_new[2]})");
    }

    static double[] RotatePoint(double[] point, double[,] matrix)
    {
        double[] result = new double[3];
        for (int i = 0; i < 3; i++)
        {
            result[i] = 0;
            for (int j = 0; j < 3; j++)
            {
                result[i] += matrix[i, j] * point[j];
            }
        }
        return result;
    }
}
