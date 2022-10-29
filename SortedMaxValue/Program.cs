using SortedMaxValue;
using System;
namespace GenericSorted;
class Program
{
    public static void Main()
    {
        int[] arr = { 233, 456, 6786, 453, 5667 };
        double[] arg = { 1.22, 43.5, 67.5, 34.67, 33.33 };
        MaxGenericSort<int> Gen = new MaxGenericSort<int>(arr);
        MaxGenericSort<Double> max = new MaxGenericSort<Double>(arg);
        max.PrintValue();
        Gen.PrintValue();
    }
}