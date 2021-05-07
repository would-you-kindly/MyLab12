using System;

namespace Custom.Collections.JavaList
{
    public class ItemNotFoundException<T> : Exception
    {
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
