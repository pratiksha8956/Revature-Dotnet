using System;

class Program
{
    static (bool, int) FindMax(int[] a)
    {
        if (a.Length == 0) return (false, 0);
        int m = a[0];
        foreach (int x in a) if (x > m) m = x;
        return (true, m);
    }

    static void Main()
    {
        int[] arr = { 3, 8, 1 };
        var result = FindMax(arr);
        Console.WriteLine(result.Item2);
    }
}
