using System;

public class Program
{
    public static void Main()
    {
        // Define the original dimensions of the rectangle
        double width = 4.0, height = 3.0;
        
        // Define the factor by which to increase the width
        double alpha = 2.0;
        
        // Calculate the new dimensions
        double newWidth = width * alpha;
        double newHeight = height / alpha;  // Adjust the height to maintain the area
        
        // Calculate the areas to verify they are the same
        double originalArea = width * height;
        double newArea = newWidth * newHeight;
        
        // Output the results
        Console.WriteLine("Original dimensions: width = {0}, height = {1}, area = {2}", width, height, originalArea);
        Console.WriteLine("New dimensions: width = {0}, height = {1}, area = {2}", newWidth, newHeight, newArea);
    }
}
