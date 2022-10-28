using System;
namespace GenericInClass;
class GenericInClass
{
    public static void Main(String[] args)
    {
        Console.WriteLine("the max value of integer is");
        Console.WriteLine(ClassInGeneric<int>.GetMax(23, 56, 99));
        Console.WriteLine("The max value of float is");
        Console.WriteLine(ClassInGeneric<Double>.GetMax(.99, 5.5, 2.5));
        Console.WriteLine("The max value of string is");
        Console.WriteLine(ClassInGeneric<String>.GetMax("x", "L", "D"));
    }
}