using RefractoredViaGenerics;
using System;
using System.Security.Cryptography.X509Certificates;

namespace RefractoredGenerics;
class Program
{
    public static void Main()
    {
        Console.Write("The maximum integer is " + GenericRefractored.MaxValue<int>(33, 45, 98));
        Console.Write("The maximum Float value is " + GenericRefractored.MaxValue<Double>(3.3, .45, .98));
        Console.Write("The maximum String value is " + GenericRefractored.MaxValue<string>("acd", "xyz","ACD"));
    }
}
