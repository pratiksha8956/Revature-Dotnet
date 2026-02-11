using System;

class Account
{
    public int Balance = 1000;

    public void Deposit(int amount)
    {
        Balance += amount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account();
        acc.Deposit(500);
        Console.WriteLine(acc.Balance);
    }
}
