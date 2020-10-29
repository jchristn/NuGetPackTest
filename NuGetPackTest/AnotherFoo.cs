using System;
using TestLibrary;

namespace NuGetPackTest
{
    /// <summary>
    /// I literally just emulate foo.
    /// </summary>
    public class AnotherFoo
    {
        private FooModule _Foo = new FooModule();

        /// <summary>
        /// I ask foo to add y to x.
        /// </summary>
        /// <param name="x">Integer.</param>
        /// <param name="y">Integer.</param>
        /// <returns>Integer.</returns>
        public int Add(int x, int y)
        {
            return _Foo.Add(x, y);
        }

        /// <summary>
        /// I ask foo to subtract x from y.
        /// </summary>
        /// <param name="x">Integer.</param>
        /// <param name="y">Integer.</param>
        /// <returns>Integer.</returns>
        public int Subtract(int x, int y)
        {
            return _Foo.Subtract(x, y);
        }

        /// <summary>
        /// Give me life!
        /// </summary>
        public AnotherFoo()
        {

        }
    }
}
