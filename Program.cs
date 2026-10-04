using System;

public static class ArrayHelper
{
    public static int IndexOf<T>(T[] array, T value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (object.Equals(array[i], value))
            {
                return i;
            }
        }
        return -1;
    }

    public static void Reverse<T>(T[] array)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left < right)
        {
            T temp = array[left];
            array[left] = array[right];
            array[right] = temp;

            left++;
            right--;
        }
    }

    public static T Min<T>(T[] array) where T : IComparable<T>
    {
        T min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i].CompareTo(min) < 0)
            {
                min = array[i];
            }
        }
        return min;
    }

    public static T Max<T>(T[] array) where T : IComparable<T>
    {
        T max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i].CompareTo(max) > 0)
            {
                max = array[i];
            }
        }
        return max;
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 2, 9, 1, 7 };
        Console.WriteLine("--- Тест int[] ---");
        Console.WriteLine("Початковий: " + string.Join(", ", numbers));
        Console.WriteLine($"IndexOf(9): {ArrayHelper.IndexOf(numbers, 9)}");
        Console.WriteLine($"Min: {ArrayHelper.Min(numbers)}");
        Console.WriteLine($"Max: {ArrayHelper.Max(numbers)}");

        ArrayHelper.Reverse(numbers);
        Console.WriteLine("Після Reverse: " + string.Join(", ", numbers));

        Console.WriteLine();

        string[] words = { "яблуко", "груша", "ананас", "банан" };
        Console.WriteLine("--- Тест string[] ---");
        Console.WriteLine("Початковий: " + string.Join(", ", words));
        Console.WriteLine($"IndexOf(\"груша\"): {ArrayHelper.IndexOf(words, "груша")}");
        Console.WriteLine($"Min (за алфавітом): {ArrayHelper.Min(words)}");
        Console.WriteLine($"Max (за алфавітом): {ArrayHelper.Max(words)}");

        ArrayHelper.Reverse(words);
        Console.WriteLine("Після Reverse: " + string.Join(", ", words));
    }
}