using System;

class OrientationMatrixExample
{
    static void Main()
    {
        double angle = 45.0 * (Math.PI / 180.0); // Convert to radians
        double cosAngle = Math.Cos(angle);
        double sinAngle = Math.Sin(angle);

        double[,] R_y = {
            { cosAngle, 0, sinAngle },
            { 0, 1, 0 },
            { -sinAngle, 0, cosAngle }
        };

        Console.WriteLine("Rotation matrix for 45 degrees about the y-axis:");
        PrintMatrix(R_y);
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
