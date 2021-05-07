using Custom.L12.Collections.OneLinkList;
using System;

namespace Custom.L12.Collections.OtherCollections.Extensions
{
    public static class StackExtensions
    {
        public static void Print<T>(this Stack<T> stack)
        {
            Console.WriteLine("=== Печать стека ===");

            if (stack.IsEmpty())
            {
                Console.WriteLine("Стек пустой");
                return;
            }

            Link<T> current = stack.Head;
            while (current != null)
            {
                Console.WriteLine(current.Item.ToString());
                current = current.Next;
            }
        }    
    }
}
