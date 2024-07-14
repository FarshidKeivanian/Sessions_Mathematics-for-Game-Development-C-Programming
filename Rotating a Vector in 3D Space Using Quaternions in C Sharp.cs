using System;
using System.Numerics;

class RotateVector
{
    static void Main()
    {
        Quaternion rotation = Quaternion.CreateFromAxisAngle(Vector3.UnitZ, MathF.PI / 2);
        Vector3 point = new Vector3(1, 0, 0);
        Vector3 rotatedPoint = Vector3.Transform(point, rotation);

        Console.WriteLine($"Rotated Point: {rotatedPoint}");
    }
}
