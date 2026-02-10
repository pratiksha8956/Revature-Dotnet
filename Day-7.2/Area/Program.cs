using System;

namespace DelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegatesDemoApp app = new DelegatesDemoApp();
            app.HigherOrderFunctionDemo();
        }
    }

    class DelegatesDemoApp
    {
        public void HigherOrderFunctionDemo()
        {
            var result = CalculateArea(AreaOfRectangle);
            Console.WriteLine($"Area: {result}");
        }

        int CalculateArea(Func<int, int, int> areaFunction)
        {
            return areaFunction(5, 10);
        }

        int AreaOfRectangle(int length, int width)
        {
            return length * width;
        }

        int AreaOfTriangle(int baseLength, int height)
        {
            return (baseLength * height) / 2;
        }
    }
}

