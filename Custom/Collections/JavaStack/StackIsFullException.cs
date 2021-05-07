using System;

namespace Custom.Collections.JavaStack
{
    public class StackIsFullException : Exception
    {
        public StackIsFullException() 
            : base("Стек переполнен.")
        {
            // Nothing here
        }

        public StackIsFullException(string message)
            : base(message)
        {
            // Nothing here
        }
    }
}
