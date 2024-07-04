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

    public static double[,] Transpose(double[,] matrix)
    {
        double[,] transpose = new double[2, 2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                transpose[i, j] = matrix[j, i];
            }
        }
        return transpose;
    }

    public static bool AreMatricesEqual(double[,] matrix1, double[,] matrix2)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (Math.Abs(matrix1[i, j] - matrix2[i, j]) > 1e-9) // using a small epsilon for floating-point comparison
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static bool IsOrthogonal(double[,] matrix)
    {
        double[,] transpose = Transpose(matrix);
        double[,] inverse = Inverse(matrix);
        return AreMatricesEqual(transpose, inverse);
    }
}

public class Program
{
    public static void Main()
    {
        double[,] matrix = {
            { 0.6, 0.8 },
            { 0.8, -0.6 }
        };

        try
        {
            bool result = MatrixOperations.IsOrthogonal(matrix);
            Console.WriteLine($"The matrix is orthogonal: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
