using System;
using System.Numerics;

class RobotArm
{
    static void Main()
    {
        Quaternion joint1 = Quaternion.CreateFromAxisAngle(Vector3.UnitX, MathF.PI / 6);
        Quaternion joint2 = Quaternion.CreateFromAxisAngle(Vector3.UnitY, MathF.PI / 3);
        Quaternion combined = Quaternion.Multiply(joint1, joint2);

        Console.WriteLine($"Combined Rotation: {combined}");
    }
}
