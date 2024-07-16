using System;

public class CoordinateTransformation
{
    public static void Main(string[] args)
    {
        double[,] transformationMatrix = {
            {1, 0, 0, 5},
            {0, 1, 0, 10},
            {0, 0, 1, -3},
            {0, 0, 0, 1}
        };

        double[] objectCoordinates = {2, 3, 4, 1};

        double[] worldCoordinates = new double[4];

        for (int i = 0; i < 4; i++)
        {
            worldCoordinates[i] = 0;
            for (int j = 0; j < 4; j++)
            {
                worldCoordinates[i] += transformationMatrix[i, j] * objectCoordinates[j];
            }
        }

        Console.WriteLine("World Coordinates: ({0}, {1}, {2})", worldCoordinates[0], worldCoordinates[1], worldCoordinates[2]);
    }
}
