using System;

class EulerRotationComplex
{
    static void Main()
    {
        double[] v = { 1, 2, 3 };

        double[,] R_x = {
            { 1, 0, 0 },
            { 0, 0, -1 },
            { 0, 1, 0 }
        };

        double[,] R_y = {
            { Math.Cos(Math.PI / 4), 0, Math.Sin(Math.PI / 4) },
            { 0, 1, 0 },
            { -Math.Sin(Math.PI / 4), 0, Math.Cos(Math.PI / 4) }
        };

        double[,] R_z = {
            { Math.Cos(Math.PI / 6), -Math.Sin(Math.PI / 6), 0 },
            { Math.Sin(Math.PI / 6), Math.Cos(Math.PI / 6), 0 },
            { 0, 0, 1 }
        };

        double[,] R = MultiplyMatrices(R_z, MultiplyMatrices(R_y, R_x));
        double[] vPrime = MultiplyMatrixVector(R, v);
        Console.WriteLine($"New orientation: [{vPrime[0]}, {vPrime[1]}, {vPrime[2]}]");
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

    static double[] MultiplyMatrixVector(double[,] matrix, double[] vector)
    {
        double[] result = new double[3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result[i] += matrix[i, j] * vector[j];
            }
        }
        return result;
    }
}
