using System;

class RotationExample
{
    static void Main()
    {
        double[] v = { 1, 0, 0 };
        double[,] R = {
            { 0, -1, 0 },
            { 1, 0, 0 },
            { 0, 0, 1 }
        };

        double[] vPrime = MultiplyMatrixVector(R, v);
        Console.WriteLine($"New orientation: [{vPrime[0]}, {vPrime[1]}, {vPrime[2]}]");
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
