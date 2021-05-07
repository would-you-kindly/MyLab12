using System;
using System.Collections.Generic;

namespace Custom.Collections.List
{
    public class CustomEnumerator<T> : IEnumerator<T>
    {
        CustomListPoint<T> head;
        CustomListPoint<T> current;
        bool begin;

        public CustomEnumerator(CustomListPoint<T> head)
        {
            this.head = head;
            this.current = head;
            this.begin = true;
        }

        public object Current => current.Item;

        T IEnumerator<T>.Current => current.Item;

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            // Конец списка
            if (current == null)
            {
                // Переход на начало коллекции
                Reset();
                return false;
            }
            else
            {
                if (begin)
                {
                    begin = false;
                    return true;
                }

                // Переход к следующему элементу коллекции
                current = current.Next;
                return current != null;
            }
        }

        public void Reset()
        {
            current = head;
            begin = true;
        }
    }
}
