using System;

class Add
{
    public virtual int Calc(int a, int b)
    {
        return a + b;   // Addition
    }
}

class AddAgain : Add
{
    public override int Calc(int a, int b)
    {
        return a + b;   // Same operation, different class
    }
}

class Program
{
    static void Main()
    {
        Add obj;

        obj = new Add();
        Console.WriteLine(obj.Calc(2, 3));  // 5

        obj = new AddAgain();
        Console.WriteLine(obj.Calc(2, 3));  // 5
    }
}
