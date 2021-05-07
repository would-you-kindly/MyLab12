using System;
using System.Collections.Generic;
using System.Text;

namespace Custom.L12.Collections.TwoLinkList
{
    public class LinkList<T>
    {
        Link<T> head;
        int count;

        public Link<T> Head => head;
        public int Count => count;

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
            link.Prev = current;
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

        public bool Remove(T item)
        {
            if (IsEmpty())
            {
                return false;
            }

            Link<T> current = head;

            while (!current.Item.Equals(item))
            {
                if (current.Next == null)
                    return false; // Элемент не найден
                else
                    current = current.Next;
            } // Совпадение найдено

            if (current == head) // Если первый элемент
            {
                head = head.Next;
                head.Prev = null;
            }
            else // В противном случае
            {
                current.Prev.Next = current.Next;
                if (current.Next != null) // Если спереди еще есть элементы
                {
                    current.Next.Prev = current.Prev;
                }
                else
                {
                    current.Prev = null;
                }
            }

            count--;
            return true;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            Link<T> current = head;
            int currentIndex = 0;

            if (index == 0)
            {
                head = head.Next;
                if (!IsEmpty())
                {
                    head.Prev = null;
                }
            }
            else
            {
                while (currentIndex != index)
                {
                    currentIndex++;
                    current = current.Next;
                } // Совпадение найдено

                current.Prev.Next = current.Next;
                if (current.Next != null) // Если спереди еще есть элементы
                {
                    current.Next.Prev = current.Prev;
                }
                else
                {
                    current.Prev = null;
                }
            }

            count--;
            return true;
        }
    }
}
