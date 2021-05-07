using System;
using System.Collections.Generic;
using System.Text;

namespace Custom.L12.Collections.TwoLinkList.Extensions
{
    public static class LinkListExtensions
    {
        public static void PrintList<T>(this LinkList<T> list)
        {
            Console.WriteLine("=== Печать двунаправленного списка ===");

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
            Console.WriteLine("=== Количество элементов в двунаправленном списке ===");

            if (list.IsEmpty())
            {
                Console.WriteLine("Список пустой");
                return;
            }

            Console.WriteLine(list.Count);
        }

        public static void RemoveOdd<T>(this LinkList<T> list)
        {
            Console.WriteLine("=== Удаление элементов с четными индексами ===");

            if (list.IsEmpty())
            {
                Console.WriteLine("Список пустой");
                return;
            }

            int countToRemove = (list.Count + 1) / 2;

            for (int i = 0; i < countToRemove; i++)
            {
                list.RemoveAt(i);
            }
        }
    }
}
