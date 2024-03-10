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

        long sum = 0; 
        foreach (int numbbbbbb in numbers)
        {
            sum += numbbbbbb;
        }
        return (double)sum / numbers.Length;
    }
}
public static class ArrayUtilities
{
    public static int FindMaximumValue(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("The array must not be null or empty.");
        }

        int maxValue = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maxValue)
            {
                maxValue = number;
            }
        }
        return maxValue;
    }
}