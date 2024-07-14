using System;
using System.Numerics;

class SlerpExample
{
    static void Main()
    {
        Quaternion start = Quaternion.CreateFromAxisAngle(Vector3.UnitY, 0);
        Quaternion end = Quaternion.CreateFromAxisAngle(Vector3.UnitY, MathF.PI);
        Quaternion result = Quaternion.Slerp(start, end, 0.5f);

        Console.WriteLine($"SLERP Result: {result}");
    }
}