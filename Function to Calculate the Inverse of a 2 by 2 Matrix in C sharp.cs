using System;

public class MatrixOperations
{
    public static double Determinant(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            throw new ArgumentException("The input matrix must be a 2x2 matrix.");
        }

        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }

    public static double[,] Inverse(double[,] matrix)
    {
        double det = Determinant(matrix);
        if (det == 0)
        {
            throw new InvalidOperationException("Matrix is not invertible.");
        }

        double[,] inverse = new double[2, 2];
        inverse[0, 0] = matrix[1, 1] / det;
        inverse[0, 1] = -matrix[0, 1] / det;
        inverse[1, 0] = -matrix[1, 0] / det;
        inverse[1, 1] = matrix[0, 0] / det;
        return inverse;
    }
}

public class Program
{
    public static void Main()
    {
        double[,] matrix = {
            { 4, 7 },
            { 2, 6 }
        };

        try
        {
            double[,] inverseMatrix = MatrixOperations.Inverse(matrix);
            Console.WriteLine("The inverse of the matrix is:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(inverseMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
