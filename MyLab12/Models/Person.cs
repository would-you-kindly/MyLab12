using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MyLab12.Models
{
    public abstract class Person : ICloneable
    {
        protected static List<string> Names = new List<string>()
        {
            "Андрей",
            "Василий",
            "Степан",
            "Евгений",
            "Георгий",
            "Алексей",
            "Светлана",
            "Мария",
            "Наталья",
        };

        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name = "", int age = 0)
        {
            Name = name;
            Age = age;
        }

        public abstract void Do();

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}\n{nameof(Age)}: {Age}";
        }

        public abstract object Clone();
    }
}
