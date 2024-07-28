using System;

class BoundingBox
{
    public double[] Min { get; private set; }
    public double[] Max { get; private set; }

    public BoundingBox(double[] min, double[] max)
    {
        Min = min;
        Max = max;
    }

    public bool Intersects(BoundingBox other)
    {
        return (Min[0] <= other.Max[0] && Max[0] >= other.Min[0]) &&
               (Min[1] <= other.Max[1] && Max[1] >= other.Min[1]) &&
               (Min[2] <= other.Max[2] && Max[2] >= other.Min[2]);
    }
}

class Program
{
    static void Main()
    {
        // Define bounding boxes
        BoundingBox box1 = new BoundingBox(new double[] {0, 0, 0}, new double[] {1, 1, 1});
        BoundingBox box2 = new BoundingBox(new double[] {0.5, 0.5, 0.5}, new double[] {1.5, 1.5, 1.5});
        BoundingBox box3 = new BoundingBox(new double[] {2, 2, 2}, new double[] {3, 3, 3});

        // Check for intersections
        Console.WriteLine($"Box1 intersects Box2: {box1.Intersects(box2)}"); // Should be True
        Console.WriteLine($"Box1 intersects Box3: {box1.Intersects(box3)}"); // Should be False
    }
}
