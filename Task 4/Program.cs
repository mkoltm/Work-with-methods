using System;

public class MinMaxFinder
{
    public static (int, int) FindMinMax(int[] array)
    {
        if (array.Length == 0)
            throw new ArgumentException("Масив порожній");

        int min = array[0];
        int max = array[0];

        foreach (var num in array)
        {
            if (num < min)
                min = num;
            else if (num > max)
                max = num;
        }

        return (min, max);
    }
}