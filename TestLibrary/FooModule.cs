using System;

namespace TestLibrary
{
    /// <summary>
    /// It's foo.
    /// </summary>
    public class FooModule
    {
        /// <summary>
        /// Adds y to x.
        /// </summary>
        /// <param name="x">Integer.</param>
        /// <param name="y">Integer.</param>
        /// <returns>Integer.</returns>
        public int Add(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Subtract x from y.
        /// </summary>
        /// <param name="x">Integer.</param>
        /// <param name="y">Integer.</param>
        /// <returns>Integer.</returns>
        public int Subtract(int x, int y)
        {
            return x - y;
        }

        /// <summary>
        /// Give me life!
        /// </summary>
        public FooModule()
        {

        }
    }
}
