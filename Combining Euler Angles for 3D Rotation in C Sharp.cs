using System;
using System.Numerics;

class EulerRotation
{
    static void Main()
    {
        Matrix4x4 rotationX = Matrix4x4.CreateRotationX(MathF.PI / 4);
        Matrix4x4 rotationY = Matrix4x4.CreateRotationY(MathF.PI / 6);
        Matrix4x4 rotationZ = Matrix4x4.CreateRotationZ(MathF.PI / 3);

        Matrix4x4 combinedRotation = rotationZ * rotationY * rotationX;
        Vector3 point = new Vector3(1, 0, 0);
        Vector3 rotatedPoint = Vector3.Transform(point, combinedRotation);

        Console.WriteLine($"Rotated Point: {rotatedPoint}");
    }
}
