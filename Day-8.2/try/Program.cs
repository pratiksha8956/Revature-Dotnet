using System;

class Program
{
    static void Main()
    {
        try
        {
            First();
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Divide By Zero Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"General Error: {ex.Message}");
            Console.WriteLine($"Inner Exception: {ex.InnerException?.Message}");
        }
        finally
        {
            Console.WriteLine("finally block executed.");
        }

        Console.WriteLine("Program continues after handling the exception.");

        // Custom Exception Example
        try
        {
            AcceptPayment(1000, 500);
        }
        catch (NotEnoughBalanceException ex)
        {
            Console.WriteLine($"Payment Error: {ex.Message}");
        }
    }

    static void First()
    {
        Second();
    }

    static void Second()
    {
        try
        {
            Third();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception From Third: {ex.Message}");

            // Good rethrow
            throw;
        }
    }

    static void Third()
    {
        int numerator = 10;
        int denominator = 0;

        int result = numerator / denominator;
        Console.WriteLine(result);
    }

    static void AcceptPayment(decimal amount, decimal balance)
    {
        if (amount > balance)
        {
            throw new NotEnoughBalanceException("Not enough balance to complete the payment.");
        }

        Console.WriteLine("Payment accepted.");
    }
}

class BankException : ApplicationException
{
    public BankException(string message) : base(message) { }
    public BankException(string message, Exception innerException) : base(message, innerException) { }
}

class NotEnoughBalanceException : BankException
{
    public NotEnoughBalanceException(string message) : base(message) { }
    public NotEnoughBalanceException(string message, Exception innerException) : base(message, innerException) { }
}
