using FindMaximum.cs;
using System;
using System.Collections.Generic;
namespace FindMax;
class GenericMax
{
    public static void Main(string arr)
    {
        int[] intArray = { 10, 20, 30, 40, 50 };
        char[] charArray = { 'H', 'e', 'l', 'l', 'o' };
        double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
        Console.WriteLine("Find max Number");
        int output = FindMaximumNumber.MaximumIntegerNumber(11, 22, 33);
        Console.WriteLine(output);
    }
}
