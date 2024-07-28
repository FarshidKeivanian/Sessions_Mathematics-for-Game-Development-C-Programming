using System;

class Program
{
    static void Main()
    {
        float x1 = 1, y1 = 2, x2 = 4, y2 = 6;
        float m = (y2 - y1) / (x2 - x1);
        Console.WriteLine("Slope: " + m);
        Console.WriteLine("Equation: y - 2 = " + m + "(x - 1)");
    }
}
