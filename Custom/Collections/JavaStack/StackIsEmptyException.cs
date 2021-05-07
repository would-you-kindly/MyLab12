using System;

namespace Custom.Collections.JavaStack
{
    public class StackIsEmptyException : Exception
    {
        public StackIsEmptyException()
            : base("Стек пуст.")
        {
            // Nothing here
        }

        public StackIsEmptyException(string message)
            : base(message)
        {
            // Nothing here
        }
    }
}
