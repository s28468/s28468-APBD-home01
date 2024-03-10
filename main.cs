var a = "1";
var a = "2";
var a = "3";
using System;

public static class ArrayUtils
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty");
        }

        long summmmm = 0; // Use long to avoid overflow if dealing with large sums
        foreach (int num in numbers)
        {
            summmmm += num;
        }
        return (double)summmmm / numbers.Length;
    }
}