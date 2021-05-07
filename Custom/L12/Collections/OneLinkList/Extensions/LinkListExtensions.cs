using System;
using System.Collections.Generic;
using System.Text;

namespace Custom.L12.Collections.OneLinkList.Extensions
{
    public static class LinkListExtensions
    {
        public static void PrintList<T>(this LinkList<T> list)
        {
            Console.WriteLine("=== Печать однонаправленного списка ===");

            if (list.IsEmpty())
            {
                Console.WriteLine("Список пустой");
                return;
            }

            Link<T> current = list.Head;
            while (current != null)
            {
                Console.WriteLine(current.Item.ToString());
                current = current.Next;
            }
        }

        public static void PrintCount<T>(this LinkList<T> list)
        {
            Console.WriteLine("=== Количество элементов в однонаправленном списке ===");

            if (list.IsEmpty())
            {
                Console.WriteLine("Список пустой");
                return;
            }

            Console.WriteLine(list.Count);
        }

        // V-15-1
        public static void AddClones<T>(this LinkList<T> list, T item)
        {
            Console.WriteLine("=== Добавление клонов в список ===");

            if (list.IsEmpty())
            {
                Console.WriteLine("Список пустой");
                return;
            }

            Link<T> current = list.Head;
            int currentIndex = 0;

            while (current != null)
            {
                if (current.Item.Equals(item))
                {
                    list.Insert(currentIndex + 1, item);

                    // Чтобы не клонировать элемент, который только что
                    // клонировали, выполняем переход на следующий еще раз
                    current = current.Next;
                    currentIndex++;
                }
                current = current.Next;
                currentIndex++;
            }
        }
    }
}
