using System;

class Program
{
    static bool TryFindMax(int[] a, out int max)
    {
        if (a.Length == 0) { max = 0; return false; }
        max = a[0];
        foreach (int x in a) if (x > max) max = x;
        return true;
    }

    static void Main()
    {
        int[] arr = { 4, 9, 2 };
        if (TryFindMax(arr, out int m))
            Console.WriteLine(m);
    }
}

