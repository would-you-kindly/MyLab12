using System;

namespace Custom.L12.Collections.Exceptions
{
    public class ListIsEmptyException : Exception
    {
        public ListIsEmptyException()
            : base("Список пуст.")
        {
            // Nothing here
        }

        public ListIsEmptyException(string message)
            : base(message)
        {
            // Nothing here
        }
    }
}
