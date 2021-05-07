using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Custom.Collections.List
{
    public class CustomList<T> : IList<T>
    {
        CustomListPoint<T> head;
        int count = 0;

        public T this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return head.Item;
                }
                int position = 1;
                CustomListPoint<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                    if (index == position)
                    {
                        return current.Item; //возвращаем текущий элем                       
                    }
                    position++;
                }
                throw new IndexOutOfRangeException();
            }
            set => throw new NotImplementedException();
        }

        public int Count => count;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            count++;

            CustomListPoint<T> point = new CustomListPoint<T>(item);

            // Добавляем первый элемент
            if (head == null)
            {
                head = point;
                return;
            }

            // Добавляем любой кроме первого
            CustomListPoint<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = point;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new CustomEnumerator<T>(head);
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
