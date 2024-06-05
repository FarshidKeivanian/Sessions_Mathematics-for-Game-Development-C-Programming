using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] pathCosts = { 2, 3, 5, 7, 1, 4, 6 };
        int totalCost = CalculateTotalCost(pathCosts);
        Console.WriteLine($"The total cost of the path is {totalCost}.");
    }

    static int CalculateTotalCost(int[] costs)
    {
        return costs.Sum();
    }
}
