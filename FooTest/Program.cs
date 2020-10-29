using System;
using NuGetPackTest;

namespace FooTest
{
    class Program
    {
        private static AnotherFoo _Foo = new AnotherFoo();

        static void Main(string[] args)
        {
            Console.WriteLine("Another foo says 1 + 1 = " + _Foo.Add(1, 1));
            Console.WriteLine("Another foo says 9 - 3 = " + _Foo.Subtract(9, 3));
        }
    }
}
