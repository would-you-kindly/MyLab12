using Custom.Collections.JavaStack;
using Custom.Collections.List;
using Custom.Collections.Tree;
using Custom.L12.Collections.OneLinkList;
using Custom.L12.Collections.OneLinkList.Extensions;
using Custom.L12.Collections.OtherCollections;
using Custom.L12.Collections.OtherCollections.Extensions;
using Custom.L12.Collections.TwoLinkList.Extensions;
using MyLab12.Models;
using System;

namespace MyLab12
{
    class Program
    {
        static void Main(string[] args)
        {
            NewMethod();

            // NewMethod1();

            // NewMethod2();

            //CustomTree tree = new CustomTree();
            //tree.Add(45);
            //tree.Add(20);
            //tree.Add(50);
            //tree.Add(30);
            //tree.Add(90);
            //tree.Add(15);
            //tree.Add(25);
            //tree.Add(95);
            //tree.Add(55);
            //tree.Add(40);
            //tree.Add(80);
            //tree.Print();
            //tree.PrintBfs();
            //tree.PrintDfs();
            //Console.WriteLine(tree.Height());
            //tree.Draw();

            Console.ReadLine();
        }

        private static void NewMethod2()
        {
            Custom.L12.Collections.TwoLinkList.LinkList<Person> list = new Custom.L12.Collections.TwoLinkList.LinkList<Person>();
            Student student = new Student("AAA", 20, 3);
            list.Add(student);
            list.Add(Student.GeneratePupil());
            list.Add(student);
            list.Add(Student.GeneratePupil());
            list.Add(student);

            //list.PrintList();
            //list.Remove(student);
            //list.PrintList();
            //list.Remove(student);
            //list.PrintList();
            //list.Remove(student);
            //list.PrintList();
            //list.Remove(student);
            //list.PrintList();
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());

            list.PrintList();
            list.RemoveAt(0);
            list.PrintList();
            list.RemoveAt(1);
            list.PrintList();
            list.RemoveAt(4);
            list.PrintList();
            list.RemoveAt(7);
            list.PrintList();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            list.Clear();
            list.PrintList();
            list.PrintCount();
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.PrintList();
            list.PrintCount();
            list.RemoveAt(2);
            list.PrintList();
            list.PrintCount();
            list.RemoveAt(1);
            list.PrintList();
            list.PrintCount();
            list.RemoveAt(0);
            list.PrintList();
            list.PrintCount();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            list.Clear();
            list.PrintList();
            list.PrintCount();
            Student student1 = new Student("AAAAAAAAAAAA", 20, 3);
            Student student2 = new Student("BBBBBBBBBBBB", 20, 3);
            list.Add(student1);
            list.Add(student2);
            list.Add(student1);
            list.Add(student2);
            list.Add(student1);
            list.Add(student2);
            list.PrintList();
            list.PrintCount();
            list.RemoveOdd();
            list.PrintList();
            list.PrintCount();
            //List<Person> people = new List<Person>();
            //people.Add(Pupil.GeneratePupil());
            //people.Add(Pupil.GeneratePupil());
            //people.Add(Pupil.GeneratePupil());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Stack<Person> stack = new Stack<Person>();
            stack.Push(Student.GeneratePupil());
            stack.Push(Student.GeneratePupil());
            stack.Push(Student.GeneratePupil());
            stack.Push(Student.GeneratePupil());
            stack.Push(Student.GeneratePupil());
            stack.Push(Student.GeneratePupil());
            stack.Print();
            Console.WriteLine(stack.Peek().ToString());
            stack.Pop();
            Console.WriteLine(stack.Peek().ToString());
            stack.Pop();
            Console.WriteLine(stack.Peek().ToString());
            stack.Pop();
            stack.Print();


            //LinkList<Person> linkList = new LinkList<Person>(people);
            //linkList.PrintList();
        }

        private static void NewMethod1()
        {
            LinkList<Person> people = new LinkList<Person>();
            people.Add(Student.GeneratePupil());
            people.Add(Student.GeneratePupil());
            people.Add(Student.GeneratePupil());
            people.Add(Pupil.GeneratePupil());
            people.Add(Pupil.GeneratePupil());
            people.Add(Pupil.GeneratePupil());
            people.Add(Pupil.GeneratePupil());
            people.Add(Pupil.GeneratePupil());

            people.PrintCount();
            people.PrintList();

            people.Clear();
            people.PrintCount();
            people.PrintList();
            people.Add(Pupil.GeneratePupil());
            people.Add(Pupil.GeneratePupil());
            people.PrintCount();
            people.PrintList();

            //
            people.Clear();
            Student student = Student.GeneratePupil();
            people.PrintCount();
            people.PrintList();
            people.Add(student);
            people.PrintCount();
            people.PrintList();
            people.AddClones(student);
            people.PrintCount();
            people.PrintList();

            //
            people.Clear();
            people.AddClones(student);
            people.PrintCount();
            people.PrintList();
            people.Insert(0, student);
            people.Insert(0, Student.GeneratePupil());
            people.Insert(0, student);
            people.Insert(0, student);
            people.Insert(0, Student.GeneratePupil());
            people.Insert(0, Student.GeneratePupil());
            people.Insert(0, student);
            people.PrintCount();
            people.PrintList();
            people.AddClones(student);
            people.PrintCount();
            people.PrintList();
        }

        private static void NewMethod()
        {
            CustomList<Person> people = new CustomList<Person>();

            people.Add(Pupil.GeneratePupil());
            people.Add(Pupil.GeneratePupil());
            people.Add(Pupil.GeneratePupil());
            people.Add(Student.GeneratePupil());
            people.Add(Student.GeneratePupil());
            people.Add(Student.GeneratePupil());

            Console.WriteLine(people.Count);

            foreach (var item in people)
            {
                Console.WriteLine(item.ToString());
            }

            foreach (var item in people)
            {
                Console.WriteLine(item.ToString());
            }

            CustomTree tree = new CustomTree();
            tree.Add(5);
            tree.Add(7);
            tree.Add(3);
            tree.Add(4);
            tree.Add(1);
            tree.Print();
            Console.WriteLine("---------------------------------");
            tree.PrintBfs();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("---------------------------------");
            tree.PrintDfs();
            Console.WriteLine("---------------------------------");

            CustomIdealTree idealTree = new CustomIdealTree();
            idealTree.Add(10);
            idealTree.Add(5);
            idealTree.Add(6);
            idealTree.Add(3);
            idealTree.Add(8);
            idealTree.Print();

            CustomTree transformed = idealTree.TransformToCustomTree();
            transformed.Print();

            CustomStack<int> customStack = new CustomStack<int>(4, false);
            customStack.Push(5);
            Console.WriteLine($"Capacity = {customStack.Capacity}");
            customStack.Push(6);
            Console.WriteLine($"Capacity = {customStack.Capacity}");
            customStack.Push(7);
            Console.WriteLine($"Capacity = {customStack.Capacity}");
            customStack.Push(8);
            Console.WriteLine($"Capacity = {customStack.Capacity}");
            customStack.Push(9);
            Console.WriteLine($"Capacity = {customStack.Capacity}");
            customStack.ReallocateMemmory();
            Console.WriteLine($"Capacity = {customStack.Capacity}");
            customStack.Push(9);
            Console.WriteLine($"Capacity = {customStack.Capacity}");
            customStack.Push(9);
            Console.WriteLine($"Capacity = {customStack.Capacity}");

            while (!customStack.IsEmpty())
            {
                Console.WriteLine(customStack.Pop());
            }

            Custom.Collections.JavaList.CustomList<int> list = new Custom.Collections.JavaList.CustomList<int>();
            list.InsertFirst(10);
            list.InsertFirst(13);
            list.InsertFirst(15);
            list.InsertFirst(3);
            list.InsertFirst(17);
            list.InsertFirst(6);
            Console.WriteLine(list.ToString());
        }
    }
}
