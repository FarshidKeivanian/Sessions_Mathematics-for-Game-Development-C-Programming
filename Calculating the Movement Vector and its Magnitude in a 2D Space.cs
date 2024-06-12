using System;

class Program
{
    static void Main()
    {
        // Coordinates of point A and point B
        int[] pointA = { 1, 2 };
        int[] pointB = { 4, 6 };

        // Calculate the movement vector
        int[] movementVector = { pointB[0] - pointA[0], pointB[1] - pointA[1] };

        // Calculate the magnitude of the movement vector
        double magnitude = Math.Sqrt(Math.Pow(movementVector[0], 2) + Math.Pow(movementVector[1], 2));

        // Display the results
        Console.WriteLine("Movement Vector: (" + movementVector[0] + ", " + movementVector[1] + ")");
        Console.WriteLine("Magnitude of Movement Vector: " + magnitude);
    }
}
