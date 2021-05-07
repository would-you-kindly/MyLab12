using System;
using System.Collections.Generic;

namespace MyLab12.Models
{
    public class Pupil : Person
    {
        protected static List<string> HeadTeacherNames = new List<string>()
        {
            "Андрей Васильевич",
            "Степан Евгеньевич",
            "Георгий Алексеевич",
            "Светлана Андреевна",
            "Мария Степоновна",
            "Наталья Георгиевна",
        };

        public string HeadTeacher { get; set; }

        public Pupil(string name = "", int age = 0, string headTeacher = "")
            : base(name, age)
        {
            HeadTeacher = headTeacher;
        }

        public static Pupil GeneratePupil()
        {
            Random random = new Random();

            return new Pupil(Names[random.Next(Names.Count)],
                random.Next(7, 18),
                HeadTeacherNames[random.Next(HeadTeacherNames.Count)]);
        }

        public override string ToString()
        {
            return base.ToString() + $"\n{nameof(HeadTeacher)}: {HeadTeacher}";
        }

        public override void Do()
        {
            Console.WriteLine("Я делаю уроки");
        }

        public override object Clone()
        {
            return new Pupil(this.Name, this.Age, this.HeadTeacher);
        }
    }
}
