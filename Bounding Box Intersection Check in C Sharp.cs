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
        // Define two bounding boxes
        BoundingBox box1 = new BoundingBox(new double[] {0, 0, 0}, new double[] {2, 2, 2});
        BoundingBox box2 = new BoundingBox(new double[] {1, 1, 1}, new double[] {3, 3, 3});
        
        // Check if the bounding boxes intersect
        if (box1.Intersects(box2))
        {
            Console.WriteLine("The bounding boxes intersect.");
        }
        else
        {
            Console.WriteLine("The bounding boxes do not intersect.");
        }
    }
}
