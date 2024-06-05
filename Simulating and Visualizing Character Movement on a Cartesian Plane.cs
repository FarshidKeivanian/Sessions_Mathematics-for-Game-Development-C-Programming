using System;

class Program
{
    static void Main()
    {
        // Coordinates of the point
        int xPoint = 3;
        int yPoint = 4;

        // Simulate the character's movement in "The Sims"
        // Starting at (0, 0), moving to (2, -1), (4, -3), (3, -4), and back to (0, 0)
        int[,] path = new int[,]
        {
            {0, 0},
            {2, -1},
            {4, -3},
            {3, -4},
            {0, 0}
        };

        // Plot the point (3, 4)
        Console.WriteLine("Plotting the point (3, 4) on a 2D Cartesian plane:");
        Console.WriteLine($"Point: ({xPoint}, {yPoint})");

        // Simulate the movement
        Console.WriteLine("\nSimulating character movement in 'The Sims':");
        for (int i = 0; i < path.GetLength(0); i++)
        {
            Console.WriteLine($"Step {i + 1}: ({path[i, 0]}, {path[i, 1]})");
        }

        // Visual representation
        Console.WriteLine("\nVisual representation (X, Y):");

        // Creating a grid for visualization
        int gridSize = 10; // Define grid size
        char[,] grid = new char[gridSize, gridSize];

        // Initialize the grid with dots
        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                grid[i, j] = '.';
            }
        }

        // Mark the point (3, 4) on the grid
        grid[gridSize / 2 - yPoint, gridSize / 2 + xPoint] = 'P';

        // Mark the path on the grid
        for (int i = 0; i < path.GetLength(0); i++)
        {
            int x = path[i, 0];
            int y = path[i, 1];
            grid[gridSize / 2 - y, gridSize / 2 + x] = 'C';
        }

        // Print the grid
        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                Console.Write(grid[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
