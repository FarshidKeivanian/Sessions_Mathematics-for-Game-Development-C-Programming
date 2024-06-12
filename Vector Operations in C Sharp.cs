using System;

namespace VectorExample
{
    // Define a Vector3D class to represent a 3D vector
    public class Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        // Constructor to initialize the vector
        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Method to add two vectors
        public static Vector3D Add(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        // Method to subtract two vectors
        public static Vector3D Subtract(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        // Method to calculate the dot product of two vectors
        public static double DotProduct(Vector3D v1, Vector3D v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        // Method to calculate the cross product of two vectors
        public static Vector3D CrossProduct(Vector3D v1, Vector3D v2)
        {
            double x = v1.Y * v2.Z - v1.Z * v2.Y;
            double y = v1.Z * v2.X - v1.X * v2.Z;
            double z = v1.X * v2.Y - v1.Y * v2.X;
            return new Vector3D(x, y, z);
        }

        // Override ToString() method to display the vector
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create two vectors
            Vector3D vector1 = new Vector3D(1, 2, 3);
            Vector3D vector2 = new Vector3D(4, 5, 6);

            // Perform vector operations
            Vector3D sum = Vector3D.Add(vector1, vector2);
            Vector3D difference = Vector3D.Subtract(vector1, vector2);
            double dotProduct = Vector3D.DotProduct(vector1, vector2);
            Vector3D crossProduct = Vector3D.CrossProduct(vector1, vector2);

            // Display results
            Console.WriteLine($"Vector 1: {vector1}");
            Console.WriteLine($"Vector 2: {vector2}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Dot Product: {dotProduct}");
            Console.WriteLine($"Cross Product: {crossProduct}");
        }
    }
}
