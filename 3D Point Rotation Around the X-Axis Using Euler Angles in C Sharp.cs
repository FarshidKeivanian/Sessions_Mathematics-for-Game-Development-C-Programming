using System;

public class EulerRotation
{
    public static void Main(string[] args)
    {
        double x = 4, y = 5, z = 6;
        double angle = Math.PI / 6; // 30 degrees

        double cosAngle = Math.Cos(angle);
        double sinAngle = Math.Sin(angle);

        double newY = y * cosAngle - z * sinAngle;
        double newZ = y * sinAngle + z * cosAngle;

        Console.WriteLine("Rotated Coordinates: ({0}, {1}, {2})", x, newY, newZ);
    }
}
