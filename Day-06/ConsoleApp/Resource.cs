using System;

namespace Day6
{
    class Resource
    {
        private string name;

        public Resource(string name)
        {
            this.name = name;
            Console.WriteLine($"{name} created");
        }

        ~Resource()
        {
            Console.WriteLine($"{name} destroyed");
        }
    }
}
