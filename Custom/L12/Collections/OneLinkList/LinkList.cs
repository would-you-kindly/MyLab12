using Custom.L12.Collections.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Custom.L12.Collections.OneLinkList
{
    public class LinkList<T> : IList<T>
    {
        Link<T> head;
        int count;

        public Link<T> Head => head;
        public int Count => count;
        public bool IsReadOnly => false;

        public LinkList()
        {
            head = null;
            count = 0;
        }

        public LinkList(int capacity)
        {
            head = null;
            count = 0;
        }

        public LinkList(IEnumerable<T> collection)
        {
            head = null;
            count = 0;

            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public T this[int index]
        {
            get
            {
                if (IsEmpty())
                    throw new ListIsEmptyException();

                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException();

                Link<T> current = head;
                int currentIndex = 0;

                while (current != null)
                {
                    if (index == currentIndex)
                    {
                        // Возвращаем текущий элемент
                        return current.Item;
                    }

                    current = current.Next;
                    currentIndex++;
                }

                throw new ItemNotFoundException<T>();
            }
            set
            {
                if (IsEmpty())
                    throw new ListIsEmptyException();

                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException();

                Link<T> current = head;
                int currentIndex = 0;

                while (current != null)
                {
                    if (index == currentIndex)
                    {
                        // Присваиваем текущий элемент 
                        current.Item = value;
                        return;
                    }

                    current = current.Next;
                    currentIndex++;
                }

                throw new ItemNotFoundException<T>();
            }
        }

        public void Add(T item)
        {
            Link<T> link = new Link<T>(item);
            count++;

            // Добавляем первый элемент
            if (IsEmpty())
            {
                head = link;
                return;
            }

            // Добавляем любой кроме первого
            Link<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = link;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException();
            }

            Link<T> link = new Link<T>(item);
            count++;
            Link<T> current = head;
            int currentIndex = 0;

            if (index == 0)
            {
                head = link;
                head.Next = current;
                return;
            }

            while (currentIndex != index - 1)
            {
                currentIndex++;
                current = current.Next;
            }

            link.Next = current.Next;
            current.Next = link;
        }

        public void InsertFirst(T item)
        {
            Link<T> link = new Link<T>(item);
            link.Next = head;
            head = link;
            count++;
        }

        public T DeleteFirst()
        {
            if (IsEmpty())
                throw new ListIsEmptyException();

            Link<T> temp = head;
            head = head.Next;
            count--;
            return temp.Item;
        }

        public T Find(T item)
        {
            if (IsEmpty())
                throw new ListIsEmptyException();

            Link<T> current = head; // Начиная с 'first'
            while (!current.Item.Equals(item)) // Пока совпадение не найдено
            {
                if (current.Next == null) // Если достигнут конец списка
                    throw new ItemNotFoundException<T>(item); // и совпадение не найдено
                else // Если еще остались элементы
                    current = current.Next; // Перейти к следующему элементу
            }

            return current.Item; // Совпадение обнаружено
        }

        public T Delete(T item)
        {
            if (IsEmpty())
                throw new ListIsEmptyException();

            Link<T> previous = head;
            Link<T> current = head;

            while (!current.Item.Equals(item))
            {
                if (current.Next == null)
                    throw new ItemNotFoundException<T>(item); // Элемент не найден
                else
                {
                    previous = current; // Перейти к следующему элементу
                    current = current.Next;
                }
            } // Совпадение найдено

            if (current == head) // Если первый элемент,
                head = head.Next; // изменить first
            else // В противном случае
                previous.Next = current.Next; // обойти его в списке

            count--;
            return current.Item;
        }

        public T DeleteAll(T item)
        {
            if (IsEmpty())
                throw new ListIsEmptyException();

            T deleted = default(T);

            try
            {
                do
                {
                    deleted = Delete(item);
                } while (true);
            }
            catch (ItemNotFoundException<T> e)
            {
                if (deleted == null)
                {
                    throw e;
                }
            }

            return deleted;
        }

        public bool IsEmpty()
        {
            return head == null;
            //return count == 0;
        }

        public void Clear()
        {
            head = null;
            count = 0;
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            Link<T> previous = head;
            Link<T> current = head;
            int currentIndex = 0;

            if (index == 0)
            {
                head = head.Next;
            }
            else
            {
                while (currentIndex != index)
                {
                    currentIndex++;
                    previous = current;
                    current = current.Next;
                } // Совпадение найдено

                previous.Next = current.Next;
                current.Next = null;
            }

            count--;
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            try
            {
                T deleted = Delete(item);
                return deleted != null;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Link<T> current = head;
            while (current != null)
            {
                yield return current.Item;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
