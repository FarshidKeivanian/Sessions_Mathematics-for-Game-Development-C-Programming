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
}

public class Program
{
    public static void Main()
    {
        double[,] rotateY = {
            { 0, 0, 1, 0 },
            { 0, 1, 0, 0 },
            { -1, 0, 0, 0 },
            { 0, 0, 0, 1 }
        };
        double[,] translateZ = {
            { 1, 0, 0, 0 },
            { 0, 1, 0, 0 },
            { 0, 0, 1, 5 },
            { 0, 0, 0, 1 }
        };

        double[,] combined = MatrixOperations.Multiply(rotateY, translateZ);

        Console.WriteLine("Combined matrix:");
        for (int i = 0; i < combined.GetLength(0); i++)
        {
            for (int j = 0; j < combined.GetLength(1); j++)
            {
                Console.Write(combined[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
