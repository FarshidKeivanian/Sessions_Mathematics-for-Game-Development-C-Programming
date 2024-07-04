using System;

public class MatrixOperations
{
    public static double[,] Multiply(double[,] matrixA, double[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int rowsB = matrixB.GetLength(0);
        int colsB = matrixB.GetLength(1);

        if (colsA != rowsB)
        {
            throw new ArgumentException("Matrix dimensions are not compatible for multiplication.");
        }

        double[,] result = new double[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < colsA; k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return result;
    }

    public static double[,] Translate(double[,] matrix, double tx, double ty, double tz)
    {
        double[,] translationMatrix = new double[,] {
            {1, 0, 0, tx},
            {0, 1, 0, ty},
            {0, 0, 1, tz},
            {0, 0, 0, 1}
        };
        return Multiply(matrix, translationMatrix);
    }
}

public class Program
{
    public static void Main()
    {
        double[,] matrix = new double[,] {
            {1, 0, 0, 0},
            {0, 1, 0, 0},
            {0, 0, 1, 0},
            {0, 0, 0, 1}
        };

        double tx = 3;
        double ty = 4;
        double tz = 5;

        double[,] translatedMatrix = MatrixOperations.Translate(matrix, tx, ty, tz);

        Console.WriteLine("Translated matrix:");
        for (int i = 0; i < translatedMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < translatedMatrix.GetLength(1); j++)
            {
                Console.Write(translatedMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
