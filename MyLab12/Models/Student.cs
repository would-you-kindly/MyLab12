using System;

namespace MyLab12.Models
{
    public class Student : Person
    {
        public int Course { get; set; }

        public Student(string name = "", int age = 0, int course = 1)
            : base(name, age)
        {
            Course = course;
        }

        public static Student GeneratePupil()
        {
            Random random = new Random();

            return new Student(Names[random.Next(Names.Count)],
                random.Next(18, 23),
                random.Next(1, 5));
        }

        public override string ToString()
        {
            return base.ToString() + $"\n{nameof(Course)}: {Course}";
        }

        public override void Do()
        {
            Console.WriteLine("Я делаю лабораторные работы");
        }

        public override object Clone()
        {
            return new Student(this.Name, this.Age, this.Course);
        }
    }
}
