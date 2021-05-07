using System;
using System.Collections.Generic;
using System.Text;

namespace Custom.Collections.Tree
{
    public class CustomIdealTree
    {
        CustomTreePoint head;
        Queue<CustomTreePoint> queue;

        public CustomIdealTree()
        {
            head = null;
            queue = new Queue<CustomTreePoint>();
        }

        public void Add(int item)
        {
            if (head == null)
            {
                head = new CustomTreePoint(item);
                return;
            }
            else
            {
                AddBfs(head, item);
            }
        }

        private void AddBfs(CustomTreePoint head, int item)
        {
            queue.Clear();

            if (head == null)
            {
                return;
            }

            queue.Enqueue(head);
            CustomTreePoint current = null;

            while (queue.Count > 0)
            {
                current = queue.Dequeue();
                if (current.Left != null)
                    queue.Enqueue(current.Left);
                else
                {
                    current.Left = new CustomTreePoint(item);
                    return;
                }
                if (current.Right != null)
                    queue.Enqueue(current.Right);
                else
                {
                    current.Right = new CustomTreePoint(item);
                    return;
                }
            }
        }

        private List<CustomTreePoint> Bfs()
        {
            queue.Clear();

            if (head == null)
            {
                return new List<CustomTreePoint>();
            }

            List<CustomTreePoint> values = new List<CustomTreePoint>();
            queue.Enqueue(head);
            CustomTreePoint current = null;

            while (queue.Count > 0)
            {
                current = queue.Dequeue();
                values.Add(current);
                if (current.Left != null)
                    queue.Enqueue(current.Left);
                if (current.Right != null)
                    queue.Enqueue(current.Right);
            }

            return values;
        }

        public CustomTree TransformToCustomTree()
        {
            CustomTree tree = new CustomTree();
            var list = Bfs();

            foreach (var item in list)
            {
                tree.Add(item.Item);
            }

            return tree;
        }

        public void Print()
        {
            Print(head);
        }

        private void Add(CustomTreePoint point)
        {
            CustomTreePoint current = point;

            if (current != null)
            {
                Console.WriteLine(current.Item);

                Add(current.Left);
                Add(current.Right);
            }
        }

        private void Print(CustomTreePoint point)
        {
            CustomTreePoint current = point;

            if (current != null)
            {
                Console.WriteLine(current.Item);

                Print(current.Left);
                Print(current.Right);
            }
        }
    }
}
