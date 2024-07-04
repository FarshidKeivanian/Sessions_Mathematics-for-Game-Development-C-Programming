using System;

public class MatrixDeterminant
{
    public static double Determinant(double[,] matrix)
    {
        // Check if the input matrix is 3x3
        if (matrix.GetLength(0) != 3 || matrix.GetLength(1) != 3)
        {
            throw new ArgumentException("The input matrix must be a 3x3 matrix.");
        }

        // Calculate the determinant of the 3x3 matrix
        double det = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) -
                     matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) +
                     matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        return det;
    }
}

public class Program
{
    public static void Main()
    {
        double[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        try
        {
            double result = MatrixDeterminant.Determinant(matrix);
            Console.WriteLine($"The determinant of the matrix is: {result}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
