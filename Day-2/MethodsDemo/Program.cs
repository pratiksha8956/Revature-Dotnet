using System;

class Program
{
    static void Main(string[] args)
    {
        int num = 121, rev = 0, temp = num;

        while (temp > 0)
        {
            rev = rev * 10 + temp % 10;
            temp /= 10;
        }

        if (num == rev)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}
