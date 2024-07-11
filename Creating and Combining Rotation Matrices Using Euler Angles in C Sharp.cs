using System;

class EulerAnglesExample
{
    static void Main()
    {
        double roll = 30.0 * (Math.PI / 180.0); // Convert to radians
        double pitch = 45.0 * (Math.PI / 180.0); // Convert to radians
        double yaw = 60.0 * (Math.PI / 180.0); // Convert to radians

        double[,] R_x = {
            { 1, 0, 0 },
            { 0, Math.Cos(roll), -Math.Sin(roll) },
            { 0, Math.Sin(roll), Math.Cos(roll) }
        };

        double[,] R_y = {
            { Math.Cos(pitch), 0, Math.Sin(pitch) },
            { 0, 1, 0 },
            { -Math.Sin(pitch), 0, Math.Cos(pitch) }
        };

        double[,] R_z = {
            { Math.Cos(yaw), -Math.Sin(yaw), 0 },
            { Math.Sin(yaw), Math.Cos(yaw), 0 },
            { 0, 0, 1 }
        };

        double[,] R = MultiplyMatrices(R_z, MultiplyMatrices(R_y, R_x));
        Console.WriteLine("Combined rotation matrix:");
        PrintMatrix(R);
    }

    static double[,] MultiplyMatrices(double[,] A, double[,] B)
    {
        int n = A.GetLength(0);
        double[,] result = new double[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    result[i, j] += A[i, k] * B[k, j];
                }
            }
        }
        return result;
    }

    static void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]:F3} ");
            }
            Console.WriteLine();
        }
    }
}
