using System;

class Program
{
    static void Main()
    {
        int n = 10;
        int result = SumFirstNaturalNumbers(n);
        Console.WriteLine($"The sum of the first {n} natural numbers is {result}.");
    }

    static int SumFirstNaturalNumbers(int n)
    {
        return n * (n + 1) / 2;
    }
}
