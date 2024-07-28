using System;

class Program
{
    static void Main()
    {
        // Define points A and B
        double x1 = 1, y1 = 2;
        double x2 = 4, y2 = 6;
        
        // Calculate the slope of the line
        double m = (y2 - y1) / (x2 - x1);
        Console.WriteLine($"Equation of the line: y - {y1} = {m}(x - {x1})");

        // Define a point P
        double px = 3, py = 4;

        // Check if point P lies on the ray
        if (IsPointOnRay(x1, y1, x2, y2, px, py))
        {
            Console.WriteLine($"Point P({px}, {py}) lies on the ray.");
        }
        else
        {
            Console.WriteLine($"Point P({px}, {py}) does not lie on the ray.");
        }
    }

    static bool IsPointOnRay(double x1, double y1, double x2, double y2, double px, double py)
    {
        // Check if the point satisfies the line equation
        bool onLine = (px - x1) * (y2 - y1) == (py - y1) * (x2 - x1);
        // Check the direction of the ray
        bool onRay = (px - x1) * (x2 - x1) >= 0 && (py - y1) * (y2 - y1) >= 0;
        return onLine && onRay;
    }
}
