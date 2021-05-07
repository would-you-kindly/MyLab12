using Custom.L12.Collections.Exceptions;
using Custom.L12.Collections.OneLinkList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLab12.Models;
using System;

namespace TestProject
{
    [TestClass]
    public class OneLinkList
    {
        [TestMethod]
        [ExpectedException(typeof(ListIsEmptyException))]
        public void IndexInEmptyList_GetIndex0_IndexOutOfRangeException()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();

            // Act
            var person = list[0];

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void OutIndexInList_GetIndexMinus10_IndexOutOfRangeException()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());

            // Act
            var person = list[-10];

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void OutIndexInList_GetIndex10_IndexOutOfRangeException()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());

            // Act
            var person = list[10];

            // Assert
        }

        [TestMethod]
        public void AddIndexInList_GetIndex2_ИмяСтудента25Курс2()
        {
            // Arrange
            Student student = new Student("ИмяСтудента", 25, 2);
            LinkList<Person> list = new LinkList<Person>();
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(student);
            list.Add(Student.GeneratePupil());

            // Act
            var expectedStudent = list[2];
            var actualStudent = student;

            // Assert
            Assert.AreEqual(expectedStudent, actualStudent);
        }

        [TestMethod]
        [ExpectedException(typeof(ListIsEmptyException))]
        public void IndexInEmptyList_SetIndex0_IndexOutOfRangeException()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();

            // Act
            list[0] = Student.GeneratePupil();

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void OutIndexInList_SetIndexMinus10_IndexOutOfRangeException()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());

            // Act
            list[-10] = Student.GeneratePupil();

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void OutIndexInList_SetIndex10_IndexOutOfRangeException()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());

            // Act
            list[10] = Student.GeneratePupil();

            // Assert
        }

        [TestMethod]
        public void AddIndexInList_SetIndex2_ИмяСтудента25Курс2()
        {
            // Arrange
            Student student = new Student("ИмяСтудента", 25, 2);
            LinkList<Person> list = new LinkList<Person>();
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());

            // Act
            list[2] = student;
            var expectedStudent = list[2];
            var actualStudent = student;

            // Assert
            Assert.AreEqual(expectedStudent, actualStudent);
        }

        [TestMethod]
        public void AddListCount_OneItem_Count1()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            list.Add(Student.GeneratePupil());

            // Act
            int expectedCount = 1;
            int actualCount = list.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void AddListCount_ThreeItem_Count3()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());

            // Act
            int expectedCount = 3;
            int actualCount = list.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void ClearListCount_ThreeItemAndClear_Count0()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Clear();

            // Act
            int expectedCount = 0;
            int actualCount = list.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void AddClearAddListCount_ThreeItemAndClear_Count2()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Clear();
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());

            // Act
            int expectedCount = 2;
            int actualCount = list.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void IsEmptyInEmptyList_EmptyList_True()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();

            // Act
            bool expected = true;
            bool actual = list.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmptyInList_NotEmptyList_False()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());

            // Act
            bool expected = false;
            bool actual = list.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmptyInClearedList_EmptyList_True()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Clear();

            // Act
            bool expected = true;
            bool actual = list.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmptyInClearedAddList_NotEmptyList_False()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Clear();
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());

            // Act
            bool expected = false;
            bool actual = list.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Insert_WrongIndexMinus10_IndexOutOfRangeException()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();

            // Act
            list.Insert(-10, Student.GeneratePupil());

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Insert_WrongIndex10_IndexOutOfRangeException()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();

            // Act
            list.Insert(10, Student.GeneratePupil());

            // Assert
        }

        [TestMethod]
        public void Insert_Index0Times5_Count5()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();

            // Act
            list.Insert(0, Student.GeneratePupil());
            list.Insert(0, Student.GeneratePupil());
            list.Insert(0, Student.GeneratePupil());
            list.Insert(0, Student.GeneratePupil());
            list.Insert(0, Student.GeneratePupil());

            int expectedCount = 5;
            int actualCount = list.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void Insert_Index0123Times4_Count4()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();

            // Act
            list.Insert(0, Student.GeneratePupil());
            list.Insert(1, Student.GeneratePupil());
            list.Insert(2, Student.GeneratePupil());
            list.Insert(3, Student.GeneratePupil());

            int expectedCount = 4;
            int actualCount = list.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void InsertFirst_Times6_Count6()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();

            // Act
            list.InsertFirst(Student.GeneratePupil());
            list.InsertFirst(Student.GeneratePupil());
            list.InsertFirst(Student.GeneratePupil());
            list.InsertFirst(Student.GeneratePupil());
            list.InsertFirst(Student.GeneratePupil());
            list.InsertFirst(Student.GeneratePupil());

            int expectedCount = 6;
            int actualCount = list.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void InsertFirstAddInsert1_Times3_Count3()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            Student student1 = new Student("ИмяСтудента1", 25, 2);
            Student student2 = new Student("ИмяСтудента2", 26, 3);
            Student student3 = new Student("ИмяСтудента3", 27, 4);

            // Act
            list.InsertFirst(student1);
            list.Add(student2);
            list.Insert(1, student3);

            int expectedCount = 3;
            int actualCount = list.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(list[0], student1);
            Assert.AreEqual(list[1], student3);
            Assert.AreEqual(list[2], student2);
        }

        [TestMethod]
        [ExpectedException(typeof(ListIsEmptyException))]
        public void DeleteFirst_EmptyList_ListIsEmptyException()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();

            // Act
            list.DeleteFirst();

            // Assert
        }

        [TestMethod]
        public void DeleteFirstTimes3_IsEmpty_True()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());

            // Act
            list.DeleteFirst();
            list.DeleteFirst();
            list.DeleteFirst();

            bool expected = true;
            bool actual = list.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteFirst_Add3Delete1_Count2()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            Student student1 = new Student("ИмяСтудента1", 25, 2);
            Student student2 = new Student("ИмяСтудента2", 26, 3);
            Student student3 = new Student("ИмяСтудента3", 27, 4);

            // Act
            list.InsertFirst(student1);
            list.Add(student2);
            list.Insert(1, student3);
            list.DeleteFirst();

            int expectedCount = 2;
            int actualCount = list.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(list[0], student3);
            Assert.AreEqual(list[1], student2);
        }

        [TestMethod]
        [ExpectedException(typeof(ListIsEmptyException))]
        public void Delete_EmptyList_ListIsEmptyException()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();

            // Act
            list.Delete(Student.GeneratePupil());

            // Assert
        }

        [TestMethod]
        public void Delete_ListWith6Items_Count5()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            Student student = new Student("ИмяСтудента1", 25, 2);
            list.Add(Student.GeneratePupil());
            list.Add(student);
            list.Add(student);
            list.Add(Student.GeneratePupil());
            list.Add(student);
            list.Add(Student.GeneratePupil());

            // Act
            list.Delete(student);

            int expectedCount = 5;
            int actualCount = list.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(list[1], student);
            Assert.AreEqual(list[3], student);
        }

        [TestMethod]
        [ExpectedException(typeof(ItemNotFoundException<Person>))]
        public void Delete_NotExistedStudent_ItemNotFoundException()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            Student student = new Student("ИмяСтудента1", 25, 2);
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());

            // Act
            list.Delete(student);

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ListIsEmptyException))]
        public void DeleteAll_EmptyList_ListIsEmptyException()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();

            // Act
            list.DeleteAll(Student.GeneratePupil());

            // Assert
        }

        [TestMethod]
        public void DeleteAll_ListWith6Items_Count3()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            Student student = new Student("ИмяСтудента1", 25, 2);
            list.Add(Student.GeneratePupil());
            list.Add(student);
            list.Add(student);
            list.Add(Student.GeneratePupil());
            list.Add(student);
            list.Add(Student.GeneratePupil());

            // Act
            list.DeleteAll(student);

            int expectedCount = 3;
            int actualCount = list.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        [ExpectedException(typeof(ItemNotFoundException<Person>))]
        public void DeleteAll_NotExistedStudent_ItemNotFoundException()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            Student student = new Student("ИмяСтудента1", 25, 2);
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());

            // Act
            list.DeleteAll(student);

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ListIsEmptyException))]
        public void Find_EmptyList_ListIsEmptyException()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();

            // Act
            list.Find(Student.GeneratePupil());

            // Assert
        }

        [TestMethod]
        public void Find_ListWith6Items_Count3()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            Student student = new Student("ИмяСтудента1", 25, 2);
            list.Add(Student.GeneratePupil());
            list.Add(student);
            list.Add(student);
            list.Add(Student.GeneratePupil());
            list.Add(student);
            list.Add(Student.GeneratePupil());

            // Act
            Person expectedStudent = list.Find(student);

            // Assert
            Assert.AreEqual(expectedStudent, student);
        }

        [TestMethod]
        [ExpectedException(typeof(ItemNotFoundException<Person>))]
        public void Find_NotExistedStudent_ItemNotFoundException()
        {
            // Arrange
            LinkList<Person> list = new LinkList<Person>();
            Student student = new Student("ИмяСтудента1", 25, 2);
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());
            list.Add(Student.GeneratePupil());

            // Act
            list.Find(student);

            // Assert
        }
    }
}
