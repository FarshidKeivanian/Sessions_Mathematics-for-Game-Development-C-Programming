using System;

class RotationExample
{
    static void Main()
    {
        double angle = 45.0 * (Math.PI / 180.0); // Convert to radians
        double cosAngle = Math.Cos(angle);
        double sinAngle = Math.Sin(angle);

        double[,] R_z = {
            { cosAngle, -sinAngle, 0 },
            { sinAngle, cosAngle, 0 },
            { 0, 0, 1 }
        };

        double[] v = { 1, 0, 0 };
        double[] vPrime = MultiplyMatrixVector(R_z, v);
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
