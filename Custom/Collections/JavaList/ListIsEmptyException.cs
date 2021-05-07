using System;

namespace Custom.Collections.JavaList
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
