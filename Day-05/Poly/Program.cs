using System;

class Operation
{
    public virtual int Calculate(int a, int b)
    {
        return 0;
    }
}

class Add : Operation
{
    public override int Calculate(int a, int b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)   // 👈 MAIN METHOD
    {
        Operation op = new Add();
        Console.WriteLine(op.Calculate(5, 3));
    }
}
