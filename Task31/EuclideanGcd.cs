using System;
using System.Diagnostics;

public static class EuclideanGcd
{
    // Метод для вычисления НОД двух чисел
    public static int Calculate(int a, int b)
    {
        return Gcd(a, b);
    }

    // Метод для вычисления НОД двух чисел с измерением времени
    public static int Calculate(int a, int b, out TimeSpan elapsed)
    {
        var stopwatch = Stopwatch.StartNew();
        int result = Gcd(a, b);
        stopwatch.Stop();
        elapsed = stopwatch.Elapsed;
        return result;
    }

    // Метод для вычисления НОД трёх чисел с измерением времени
    public static int Calculate(int a, int b, int c, out TimeSpan elapsed)
    {
        var stopwatch = Stopwatch.StartNew();
        int result = Gcd(Gcd(a, b), c);
        stopwatch.Stop();
        elapsed = stopwatch.Elapsed;
        return result;
    }

    // Метод для вычисления НОД любого количества чисел
    public static int Calculate(params int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("At least one number must be provided.");

        int result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            result = Gcd(result, numbers[i]);
        }
        return result;
    }

    // Метод для вычисления НОД любого количества чисел с измерением времени
    public static int Calculate(out TimeSpan elapsed, params int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("At least one number must be provided.");

        var stopwatch = Stopwatch.StartNew();
        int result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            result = Gcd(result, numbers[i]);
        }
        stopwatch.Stop();
        elapsed = stopwatch.Elapsed;
        return result;
    }

    // Вспомогательный метод для вычисления НОД
    private static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}

