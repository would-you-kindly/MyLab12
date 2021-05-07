using System;

namespace Custom.L12.Collections.Exceptions
{
    public class ItemNotFoundException<T> : Exception
    {
        public ItemNotFoundException()
            : base($"Элемент в списке не найден.")
        {
            // Nothing here
        }

        public ItemNotFoundException(T item)
            : base($"Элемент {item} в списке не найден.")
        {
            // Nothing here
        }

        public ItemNotFoundException(string message)
            : base(message)
        {
            // Nothing here
        }
    }
}
