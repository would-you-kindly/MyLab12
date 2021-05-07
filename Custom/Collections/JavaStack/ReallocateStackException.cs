using System;

namespace Custom.Collections.JavaStack
{
    public class ReallocateStackException : Exception
    {
        public ReallocateStackException(int capacity, int size)
            : base($"Размер выделенной памяти {capacity} не может быть меньше размера стека {size}")
        {
            // Nothing here
        }

        public ReallocateStackException(string message)
            : base(message)
        {
            // Nothing here
        }
    }
}
