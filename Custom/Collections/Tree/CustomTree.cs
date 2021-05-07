using System;
using System.Collections.Generic;
using System.Text;

namespace Custom.Collections.Tree
{
    public class CustomTree
    {
        CustomTreePoint head;

        public CustomTree()
        {
            head = null;
        }

        public void Add(int item)
        {
            CustomTreePoint newItem = new CustomTreePoint(item);

            if (head == null)
            {
                head = newItem;
                return;
            }
            else
            {
                CustomTreePoint prev = null;
                CustomTreePoint current = head;

                while (true)
                {
                    prev = current;

                    if (item < current.Item) // Идем налево?
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            prev.Left = newItem;
                            return;
                        }
                    }
                    else if (item > current.Item) // Идем направо?
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            prev.Right = newItem;
                            return;
                        }
                    }
                    else
                    {
                        throw new Exception("Дерево не позволяет вставлять элементы с одинаковым значением.");
                    }
                }
            }
        }

        public void Draw()
        {
            int height = Height();
            int levelCells = (int)Math.Pow(2, height) - 1;
            Queue<string> nodes = Bfs();
            for (int i = 0; i < height; i++)
            {
                string row = string.Empty;
                string emptyString = new string(' ', (levelCells - 1));
                for (int j = 0; j < (int)Math.Pow(2, i); j++) // j - количество узлов, который нужно нарисовать на уровне i
                {
                    row += emptyString + nodes.Dequeue() + emptyString + "  ";
                }
                Console.WriteLine(row);
                levelCells /= 2;
            }
        }

        public void Print()
        {
            Print(head);
        }

        public void PrintBfs()
        {
            Console.WriteLine("Обход дерева в ширину с помощью очереди");

            Bfs(head);
        }

        public void PrintDfs()
        {
            Console.WriteLine("Обход дерева в глубину с помощью стека");

            Dfs(head);
        }

        // Обход в ширину
        private void Bfs(CustomTreePoint current)
        {
            if (current == null)
            {
                return;
            }

            Queue<CustomTreePoint> queue = new Queue<CustomTreePoint>();

            queue.Enqueue(current);

            while (queue.Count > 0)
            {
                var tempNode = queue.Dequeue();

                Console.WriteLine(tempNode.Item);

                if (tempNode.Left != null)
                    queue.Enqueue(tempNode.Left);
                if (tempNode.Right != null)
                    queue.Enqueue(tempNode.Right);
            }
        }

        private Queue<string> Bfs()
        {
            Queue<string> result = new Queue<string>();

            if (head == null)
            {
                return null;
            }

            Queue<CustomTreePoint> queue = new Queue<CustomTreePoint>();

            queue.Enqueue(head);
            result.Enqueue(head.Item.ToString());

            while (queue.Count > 0)
            {
                var tempNode = queue.Dequeue();

                if (tempNode.Left != null)
                {
                    queue.Enqueue(tempNode.Left);
                    result.Enqueue(tempNode.Left.Item.ToString());
                }
                else
                {
                    result.Enqueue("--");
                }
                if (tempNode.Right != null)
                {
                    queue.Enqueue(tempNode.Right);
                    result.Enqueue(tempNode.Right.Item.ToString());
                }
                else
                {
                    result.Enqueue("--");
                }
            }

            return result;
        }

        // Обход в глубину
        private void Dfs(CustomTreePoint current)
        {
            Stack<CustomTreePoint> stack = new Stack<CustomTreePoint>();

            if (current == null)
            {
                return;
            }

            stack.Push(current);

            while (stack.Count > 0)
            {
                var tempNode = stack.Pop();
                Console.WriteLine(tempNode.Item);
                if (tempNode.Right != null)
                    stack.Push(tempNode.Right);
                if (tempNode.Left != null)
                    stack.Push(tempNode.Left);
            }
        }

        // Высота дерева
        public int Height()
        {
            return Height(head);
        }

        private int Height(CustomTreePoint point)
        {
            int left, right;

            if (point != null)
            {
                left = (point.Left != null) ? Height(point.Left) : 0;
                right = (point.Right != null) ? Height(point.Right) : 0;

                return ((left > right) ? left : right) + 1;
            }

            return 0;
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
