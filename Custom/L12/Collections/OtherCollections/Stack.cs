using Custom.L12.Collections.OneLinkList;
using System;
using System.Collections.Generic;

namespace Custom.L12.Collections.OtherCollections
{
    public class Stack<T>
    {
        LinkList<T> stack;

        public Link<T> Head => stack.Head;
        public int Count => stack.Count;

        public Stack()
        {
            stack = new LinkList<T>();
        }

        public Stack(int capacity)
        {
            stack = new LinkList<T>(capacity);
        }

        public Stack(IEnumerable<T> collection)
        {
            stack = new LinkList<T>(collection);
        }

        public void Push(T item)
        {
            stack.Add(item);
        }

        public T Pop()
        {
            T result = stack[Count - 1];
            stack.RemoveAt(Count - 1);
            return result;
        }

        public T Peek()
        {
            return stack[Count - 1];
        }

        public void Clear()
        {
            stack.Clear();
        }

        public bool IsEmpty()
        {
            return stack.IsEmpty();
        }
    }
}
